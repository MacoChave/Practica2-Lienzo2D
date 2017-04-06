using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Irony.Ast;
using Irony.Parsing;

namespace Proyecto2_Lienzo2D.Interprete
{
    class Gramatica : Grammar
    {
        public Gramatica() : base(caseSensitive: true)
        {
            #region ER
            var numero = TerminalFactory.CreateCSharpNumber("numero");
            IdentifierTerminal id = new IdentifierTerminal("id");
            StringLiteral cadena = TerminalFactory.CreateCSharpString("cadena");
            var caracter = TerminalFactory.CreateCSharpChar("caracter");
            #endregion

            #region Terminales
            /*  OPERADORES ARITMETICOS  */
            var mas = ToTerm("+");
            var menos = ToTerm("-");
            var por = ToTerm("*");
            var div = ToTerm("/");
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
                L_ID = new NonTerminal("LST ID"),
                ASIGNACION = new NonTerminal("ASIGNACION"),
                COMPARACION = new NonTerminal("COMPARACION"),
                DECLARAR = new NonTerminal("DECLARAR"),
                COMPARAR = new NonTerminal("COMPARAR"),
                TIPO = new NonTerminal("TIPO"),
                E = new NonTerminal("E");
            #endregion

            #region Gramatica
            S.Rule = PROGRAMA;

            PROGRAMA.Rule = VISIBILIDAD + lienzo + id + EXTENDER + ToTerm("¿") + SENTENCIAS + ToTerm("?");

            VISIBILIDAD.Rule = publico | privado | Empty;

            EXTENDER.Rule = extiende + EXT | Empty;

            EXT.Rule = MakePlusRule(EXT, ToTerm(","), id);

            SENTENCIAS.Rule = MakePlusRule(SENTENCIAS, SENTENCIA);

            SENTENCIA.Rule = SI | PARA | MIENTRAS | HACER | ASIGNACION;

            /*
             * si ( CONDICION ) ¿ SENTENCIA ? sino ¿ SENTENCIA ?
             * para ( INICIO_PARA ; FIN_PARA; CONDICION) ¿ SENTENCIA ?
             * mientras ( CONDICION ) ¿ SENTENCIA ?
             * hacer ¿ SENTENCIA ? mientras ( CONDICION ) $
             */
            SI.Rule = sentencia_si + ToTerm("(") + COMPARACION + ToTerm(")") + 
                ToTerm("¿") + SENTENCIA + ToTerm("?") + 
                sentencia_sino + ToTerm("¿") + SENTENCIA + ToTerm("?");

            PARA.Rule = sentencia_para + ToTerm("(") + ASIGNACION + ToTerm(";") + COMPARACION + ToTerm(";") + COMPARACION + ToTerm(")") + 
                ToTerm("¿") + SENTENCIA + ToTerm("?");

            MIENTRAS.Rule = sentencia_mientras + ToTerm("(") + COMPARACION + ToTerm(")") + 
                ToTerm("¿") + SENTENCIA + ToTerm("?");

            HACER.Rule = sentencia_hacer + ToTerm("¿") + SENTENCIA + ToTerm("?") +
                sentencia_mientras + ToTerm("(") + COMPARACION + ToTerm(")") + ToTerm("$");

            /*
             * CONDICION -> COMPARACION
             * INICIO_PARA -> ASIGNACION
             * FIN_PARA  -> COMPARACION
             */
            ASIGNACION.Rule = DECLARAR + ToTerm("=") + E + ToTerm("$");

            DECLARAR.Rule = TIPO + id;

            COMPARACION.Rule = E + COMPARAR + E;

            TIPO.Rule = tipo_cadena | tipo_caracter | tipo_doble | tipo_entero | tipo_bool;

            COMPARAR.Rule = igual | menor | mayor | menor_igual | mayor_igual | diferente;

            E.Rule = E + mas + E
                | E + menos + E
                | E + por + E
                | E + div + E
                | ToTerm("(") + E + ToTerm(")")
                | numero
                | id
                | cadena
                | caracter;

            #endregion

            #region Preferencias
            this.Root = S;

            this.RegisterOperators(20, Associativity.Left, mas, menos);
            this.RegisterOperators(30, Associativity.Left, por, div);

            this.MarkPunctuation("(", ")", ",", ";", "=", "¿", "?", "$");

            this.MarkTransient(S, VISIBILIDAD, EXTENDER, SENTENCIAS, SENTENCIA, TIPO, COMPARAR, DECLARAR, E);

            #endregion
        }
    }
}
