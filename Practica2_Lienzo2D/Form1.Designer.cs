namespace Practica2_Lienzo2D
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBarra = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.richTextBoxCaja = new System.Windows.Forms.RichTextBox();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            this.buttonAST = new System.Windows.Forms.Button();
            this.buttonTablas = new System.Windows.Forms.Button();
            this.panelBarra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBarra.Controls.Add(this.buttonMin);
            this.panelBarra.Controls.Add(this.buttonMax);
            this.panelBarra.Controls.Add(this.buttonSalir);
            this.panelBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(684, 30);
            this.panelBarra.TabIndex = 0;
            // 
            // buttonMin
            // 
            this.buttonMin.Location = new System.Drawing.Point(435, 4);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(75, 23);
            this.buttonMin.TabIndex = 0;
            this.buttonMin.Text = "_";
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Location = new System.Drawing.Point(516, 4);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(75, 23);
            this.buttonMax.TabIndex = 0;
            this.buttonMax.Text = "O";
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(597, 4);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.Text = "X";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // richTextBoxCaja
            // 
            this.richTextBoxCaja.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxCaja.Location = new System.Drawing.Point(0, 80);
            this.richTextBoxCaja.Name = "richTextBoxCaja";
            this.richTextBoxCaja.Size = new System.Drawing.Size(684, 380);
            this.richTextBoxCaja.TabIndex = 2;
            this.richTextBoxCaja.Text = "";
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalizar.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnalizar.Location = new System.Drawing.Point(12, 36);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(100, 23);
            this.buttonAnalizar.TabIndex = 3;
            this.buttonAnalizar.Text = "Compilar";
            this.buttonAnalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnalizar.UseVisualStyleBackColor = true;
            this.buttonAnalizar.Click += new System.EventHandler(this.buttonAnalizar_Click);
            // 
            // buttonAST
            // 
            this.buttonAST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAST.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAST.Location = new System.Drawing.Point(118, 36);
            this.buttonAST.Name = "buttonAST";
            this.buttonAST.Size = new System.Drawing.Size(100, 23);
            this.buttonAST.TabIndex = 3;
            this.buttonAST.Text = "Ver Arbol";
            this.buttonAST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAST.UseVisualStyleBackColor = true;
            this.buttonAST.Click += new System.EventHandler(this.buttonAST_Click);
            // 
            // buttonTablas
            // 
            this.buttonTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTablas.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTablas.Location = new System.Drawing.Point(224, 36);
            this.buttonTablas.Name = "buttonTablas";
            this.buttonTablas.Size = new System.Drawing.Size(100, 23);
            this.buttonTablas.TabIndex = 3;
            this.buttonTablas.Text = "Ver Tablas";
            this.buttonTablas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTablas.UseVisualStyleBackColor = true;
            this.buttonTablas.Click += new System.EventHandler(this.buttonTablas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(684, 460);
            this.Controls.Add(this.buttonTablas);
            this.Controls.Add(this.buttonAST);
            this.Controls.Add(this.buttonAnalizar);
            this.Controls.Add(this.richTextBoxCaja);
            this.Controls.Add(this.panelBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lienzo2D Editor";
            this.panelBarra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBarra;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.Button buttonMax;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.RichTextBox richTextBoxCaja;
        private System.Windows.Forms.Button buttonAnalizar;
        private System.Windows.Forms.Button buttonAST;
        private System.Windows.Forms.Button buttonTablas;
    }
}

