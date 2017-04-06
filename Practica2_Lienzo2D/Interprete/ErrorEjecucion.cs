using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practica2_Lienzo2D.Interprete
{
    public class ErrorEjecucion
    {
        /*
         * String, String, int, int, String
         * new ErrorEjecucion(tipo, error, columna, fila "sintáctico");
         */
        String tipo;
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        String error;
        public String Error
        {
            get { return error; }
            set { error = value; }
        }
        
        int columna;
        public int Columna
        {
            get { return columna; }
            set { columna = value; }
        }
        
        int fila;
        public int Fila
        {
            get { return fila; }
            set { fila = value; }
        }

        public ErrorEjecucion() { }

        public ErrorEjecucion(String tipo, String error, int columna, int fila)
        {
            this.tipo = tipo;
            this.error = error;
            this.columna = columna;
            this.fila = fila;
        }
    }
}
