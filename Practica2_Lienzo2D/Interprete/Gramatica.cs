using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;
using Practica2_Lienzo2D.Interprete;

namespace Proyecto2_Lienzo2D.Interprete
{
    class Gramatica : Grammar
    {
        public List<ErrorEjecucion> lista = new List<ErrorEjecucion>();

        public Gramatica() : base(caseSensitive: true)
        {
            #region ER
            var numero = TerminalFactory.CreateCSharpNumber("numero");
            IdentifierTerminal id = new IdentifierTerminal("id");
            StringLiteral cadena = TerminalFactory.CreateCSharpString("cadena");
            var caracter = TerminalFactory.CreateCSharpChar("caracter");
            CommentTerminal cs = new CommentTerminal("comentario simple", ">>", "\n");
            CommentTerminal cm = new CommentTerminal("comentario multilinea", "<-", "->");
            #endregion

            #region Terminales
            /*  OPERADORES ARITMETICOS  */
            var mas = ToTerm("+");
            var menos = ToTerm("-");
            var por = ToTerm("*");
            var div = ToTerm("/");
            var pot = ToTerm("^");
            /*  OPERADORES RELACIONALES   */
            var igual = ToTerm("==");
            var menor = ToTerm("<");
            var mayor = ToTerm(">");
            var menor_igual = ToTerm("<=");
            var mayor_igual = ToTerm(">=");
            var diferente = ToTerm("!=");
            /*  OPERADORES LOGICOS  
            var or = ToTerm("||");
            var and = ToTerm("&&");
            var not = ToTerm("!");
            var nand = ToTerm("!&&");
            var nor = ToTerm("!||");
            var xor = ToTerm("&|"); */
            /*  TIPOS DE DATOS  */
            var tipo_cadena = ToTerm("cadena");
            var tipo_caracter = ToTerm("caracter");
            var tipo_entero = ToTerm("entero");
            var tipo_doble = ToTerm("doble");
            var tipo_bool = ToTerm("boolean");
            /*  SENTENCIAS DE CONTROL   */
            var sentencia_si = ToTerm("si");
            var sentencia_sino = ToTerm("sino");
            var sentencia_para = ToTerm("para");
            var sentencia_mientras = ToTerm("mientras");
            var sentencia_hacer = ToTerm("hacer");
            /*  ENCABEZADO  */
            var publico = ToTerm("publico");
            var privado = ToTerm("privado");
            var lienzo = ToTerm("Lienzo");
            var extiende = ToTerm("extiende");
            /*  VARIABLES   */
            var conservar = ToTerm("Conservar");
            var variable = ToTerm("var");
            /*  METODOS   */
            var principal = ToTerm("Principal");
            var pintorP = ToTerm("Pintar_P");
            var pintarOR = ToTerm("Pintar_OR");
            var retorno = ToTerm("Retorno");
            #endregion

            #region No Terminales
            NonTerminal S = new NonTerminal("S"),
                PROGRAMA = new NonTerminal("PROGRAMA"),
                VISIBILIDAD = new NonTerminal("VISIBILIDAD"),
                EXTENDER = new NonTerminal("EXTENDER"),
                EXT = new NonTerminal("EXT"),
                SENTENCIAS = new NonTerminal("SENTENCIAS"),
                SENTENCIA = new NonTerminal("SENTENCIA"),
                CONDICION = new NonTerminal("CONDICION"),
                INICIO_PARA = new NonTerminal("INICIO PARA"),
                FIN_PARA = new NonTerminal("FIN PARA"),
                SI = new NonTerminal("SI"),
                SINO = new NonTerminal("SINO"),
                PARA = new NonTerminal("PARA"),
                MIENTRAS = new NonTerminal("MIENTRAS"),
                HACER = new NonTerminal("HACER"),
                DECLARACION = new NonTerminal("DECLARACION"),
                DECLARAR = new NonTerminal("DECLARAR"),
                CONSERVAR = new NonTerminal("CONSERVAR"),
                L_ID = new NonTerminal("LST ID"),
                ID = new NonTerminal("ID"),
                ASIGNACION = new NonTerminal("ASIGNACION"),
                ASIGNAR = new NonTerminal("ASIGNAR"),
                MODIFICAR = new NonTerminal("MODIFICAR"),
                COMPARACION = new NonTerminal("COMPARACION"),
                COMPARAR = new NonTerminal("COMPARAR"),
                TIPO = new NonTerminal("TIPO"),
                PINTARP = new NonTerminal("PINTAR P"),
                PINTAROR = new NonTerminal("PINTAR OR"),
                PRINCIPAL = new NonTerminal("PRINCIPAL"),
                PROCEDIMIENTO = new NonTerminal("PROCEDIMIENTO"),
                MODMETODO = new NonTerminal ("MOD METODO"),
                PARAMETROS = new NonTerminal("PARAMETROS"),
                PARAMETRO = new NonTerminal("PARAMETRO"),
                RETORNO = new NonTerminal("RETORNO"),
                E = new NonTerminal("E");
            #endregion

            #region Gramatica
            /*
             *      CABECERA
             *      
             */
            S.Rule = PROGRAMA;

            PROGRAMA.Rule = VISIBILIDAD + lienzo + id + EXTENDER + ToTerm("¿") + SENTENCIAS + ToTerm("?")
                | SyntaxError;

            VISIBILIDAD.Rule = publico | privado | Empty;

            EXTENDER.Rule = extiende + EXT | Empty;

            EXT.Rule = MakePlusRule(EXT, ToTerm(","), id);

            SENTENCIAS.Rule = MakePlusRule(SENTENCIAS, SENTENCIA);

            SENTENCIA.Rule = SI | PARA | MIENTRAS | HACER | PRINCIPAL | PINTARP | PINTAROR | PROCEDIMIENTO | DECLARACION + ToTerm("$") | ASIGNAR + ToTerm("$");

            /*
             *      SENTENCIAS DE CONTROL
             *      
             */
            SI.Rule = sentencia_si + ToTerm("(") + COMPARACION + ToTerm(")") + 
                ToTerm("¿") + SENTENCIA + ToTerm("?") + 
                sentencia_sino + ToTerm("¿") + SENTENCIA + ToTerm("?");

            PARA.Rule = sentencia_para + ToTerm("(") + DECLARACION + ToTerm(";") + COMPARACION + ToTerm(";") + ASIGNAR + ToTerm(")") + 
                ToTerm("¿") + SENTENCIA + ToTerm("?");

            MIENTRAS.Rule = sentencia_mientras + ToTerm("(") + COMPARACION + ToTerm(")") + 
                ToTerm("¿") + SENTENCIA + ToTerm("?");

            HACER.Rule = sentencia_hacer + ToTerm("¿") + SENTENCIA + ToTerm("?") +
                sentencia_mientras + ToTerm("(") + COMPARACION + ToTerm(")") + ToTerm("$");
            
            /*
             *      VARIABLES
             *      
             */
            DECLARACION.Rule = DECLARAR + L_ID;

            DECLARAR.Rule = CONSERVAR + variable + TIPO | Empty;

            CONSERVAR.Rule = conservar | Empty;

            L_ID.Rule = L_ID + ToTerm(",") + ID | ID;

            ID.Rule = ASIGNACION | E;

            ASIGNACION.Rule = id + ToTerm("=") + E;

            ASIGNAR.Rule = ASIGNACION | MODIFICAR;

            MODIFICAR.Rule = E + mas + mas
                | E + menos + menos;

            COMPARACION.Rule = E + COMPARAR + E;

            TIPO.Rule = tipo_cadena | tipo_caracter | tipo_doble | tipo_entero | tipo_bool;

            COMPARAR.Rule = igual | menor | mayor | menor_igual | mayor_igual | diferente;

            /*
             *      ARITMETICA
             *      
             */
            E.Rule = E + mas + E
                | E + menos + E
                | E + por + E
                | E + div + E
                | E + pot + E
                | ToTerm("(") + E + ToTerm(")")
                | numero
                | id
                | cadena
                | caracter;
            /*
             *      PROCEDIMIENTOS
             *      
             */
            PROCEDIMIENTO.Rule = MODMETODO + id + ToTerm("(") + PARAMETROS + ToTerm(")") + ToTerm("¿") + SENTENCIAS + RETORNO + ToTerm("?");

            MODMETODO.Rule = CONSERVAR + TIPO | Empty;

            PARAMETROS.Rule = PARAMETROS + ToTerm(",") + PARAMETRO
                | PARAMETRO;

            PARAMETRO.Rule = TIPO + id;

            RETORNO.Rule = retorno + id + ToTerm("$");

            PINTARP.Rule = pintorP + ToTerm("(") + E + ToTerm(",") + E + ToTerm(",") + E + ToTerm(",") + E + ToTerm(")") + ToTerm("$");

            PINTAROR.Rule = pintarOR + ToTerm("(") + E + ToTerm(",") + E + ToTerm(",") + E + ToTerm(",") + E + ToTerm(",") + E + ToTerm(",") + E + ToTerm(")") + ToTerm("$");

            PRINCIPAL.Rule = principal + ToTerm("(") + ToTerm(")") + ToTerm("¿") + SENTENCIA + ToTerm("?");
            #endregion

            #region Preferencias
            this.Root = S;

            this.RegisterOperators(20, Associativity.Left, mas, menos);
            this.RegisterOperators(30, Associativity.Left, por, div);

            this.MarkPunctuation("(", ")", ",", ";", "=", "¿", "?", "$");

            this.MarkTransient(S, VISIBILIDAD, EXTENDER, SENTENCIAS, SENTENCIA, TIPO, COMPARAR, DECLARAR, E, L_ID, ASIGNAR, PARAMETROS, CONSERVAR);

            base.NonGrammarTerminals.Add(cs);
            base.NonGrammarTerminals.Add(cm);

            #endregion
        }

        public override void ReportParseError(ParsingContext context)
        {
            String error = (String)context.CurrentToken.ValueString;
            String tipo;
            int fila, columna;

            if (error.Contains("Invalid character"))
            {
                tipo = "Error Lexico";
                string delimStr = ":";
                char[] delimitador = delimStr.ToCharArray();
                string[] division = error.Split(delimitador, 2);
                division = division[1].Split('.');
                error = "Caracter Invalido " + division[0];
            }
            else
                tipo = "Error Sintactico";

            fila = context.Source.Location.Line;
            columna = context.Source.Location.Column;
            ErrorEjecucion nuevo = new ErrorEjecucion(tipo, error, columna, fila);
            this.lista.Add(nuevo);

            base.ReportParseError(context);
        }
    }
}
