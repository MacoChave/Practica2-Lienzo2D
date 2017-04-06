using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Irony.Ast;
using Irony.Parsing;
using System.IO;
using Practica2_Lienzo2D.ControlDOT;


namespace Proyecto2_Lienzo2D.Interprete
{
    class Sintactico : Grammar
    {
        public static ParseTreeNode analizar(String cadena)
        {
            Gramatica gramatica = new Gramatica();
            LanguageData lenguaje = new LanguageData(gramatica);
            Parser parser = new Parser(lenguaje);
            ParseTree arbol = parser.Parse(cadena);

            Reportes reporte = new Reportes();
            reporte.TablaErrores(gramatica.lista);

            return arbol.Root;
        }

        public static Image getImage(ParseTreeNode raiz)
        {
            String grafoDOT = ControlDOT.ControlDOT.getDOT(raiz);
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToPNG(grafoDOT);
            byte[] imageBytes = Convert.FromBase64String(img.ToBase64String());
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            Image imagen = Image.FromStream(ms, true);

            return imagen;
        }

        public static void generarImagen(ParseTreeNode raiz)
        {
            String grafoDOT = ControlDOT.ControlDOT.getDOT(raiz);
            WINGRAPHVIZLib.DOT dot = new WINGRAPHVIZLib.DOT();
            WINGRAPHVIZLib.BinaryImage img = dot.ToPNG(grafoDOT);
            img.Save("AST.png");
        }
    }
}
