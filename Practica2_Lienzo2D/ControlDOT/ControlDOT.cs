using Irony.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2_Lienzo2D.ControlDOT
{
    class ControlDOT
    {
        private static int contador;
        private static String grafo;

        public static String getDOT(ParseTreeNode raiz)
        {
            grafo = "digraph G{";
            grafo += "node[shape=\"box\"];";
            grafo += "nodo0[label=\"" + escapar(raiz.ToString()) + "\"];\n";
            contador = 1;
            recorrerAST("nodo0", raiz);
            grafo += "}";

            return grafo;
        }

        private static string escapar(string raiz)
        {
            raiz = raiz.Replace("\\", "\\\\");
            raiz = raiz.Replace("\"", "\\\"");

            return raiz;
        }

        private static void recorrerAST(string nodo, ParseTreeNode raiz)
        {
            foreach (ParseTreeNode item in raiz.ChildNodes)
            {
                String hijo = "nodo" + contador.ToString();
                grafo += hijo + "[label=\"" + escapar(item.ToString()) + "\"];";
                grafo += nodo + "->" + hijo + ";\n";
                contador++;

                recorrerAST(hijo, item);
            }
        }
    }
}
