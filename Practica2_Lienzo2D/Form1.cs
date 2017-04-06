using Irony.Parsing;
using Proyecto2_Lienzo2D.Interprete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2_Lienzo2D
{
    public partial class Form1 : Form
    {

        ParseTreeNode resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Normal;
                richTextBoxCaja.Height = 350;
            }
            else
            {
                this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                richTextBoxCaja.Height = 600;
            }
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAnalizar_Click(object sender, EventArgs e)
        {
            resultado = Sintactico.analizar(richTextBoxCaja.Text);
            if (resultado != null)
            {
                try
                {
                    MessageBox.Show("Analisis exitoso");
                    Sintactico.generarImagen(resultado);
                    MessageBox.Show("AST generado");
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        private void buttonAST_Click(object sender, EventArgs e)
        {

        }

        private void buttonTablas_Click(object sender, EventArgs e)
        {

        }

    }
}
