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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelBarra = new System.Windows.Forms.Panel();
            this.buttonMin = new System.Windows.Forms.Button();
            this.buttonMax = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.richTextBoxCaja = new System.Windows.Forms.RichTextBox();
            this.buttonAnalizar = new System.Windows.Forms.Button();
            this.buttonAST = new System.Windows.Forms.Button();
            this.buttonTablas = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBarra
            // 
            this.panelBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBarra.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelBarra.Controls.Add(this.buttonMin);
            this.panelBarra.Controls.Add(this.buttonMax);
            this.panelBarra.Controls.Add(this.buttonSalir);
            this.panelBarra.Location = new System.Drawing.Point(0, 0);
            this.panelBarra.Name = "panelBarra";
            this.panelBarra.Size = new System.Drawing.Size(684, 46);
            this.panelBarra.TabIndex = 0;
            // 
            // buttonMin
            // 
            this.buttonMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMin.FlatAppearance.BorderSize = 0;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMin.Image = ((System.Drawing.Image)(resources.GetObject("buttonMin.Image")));
            this.buttonMin.Location = new System.Drawing.Point(570, 12);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(30, 30);
            this.buttonMin.TabIndex = 0;
            this.buttonMin.UseVisualStyleBackColor = true;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // buttonMax
            // 
            this.buttonMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMax.FlatAppearance.BorderSize = 0;
            this.buttonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMax.Image = ((System.Drawing.Image)(resources.GetObject("buttonMax.Image")));
            this.buttonMax.Location = new System.Drawing.Point(606, 12);
            this.buttonMax.Name = "buttonMax";
            this.buttonMax.Size = new System.Drawing.Size(30, 30);
            this.buttonMax.TabIndex = 0;
            this.buttonMax.UseVisualStyleBackColor = true;
            this.buttonMax.Click += new System.EventHandler(this.buttonMax_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalir.Image")));
            this.buttonSalir.Location = new System.Drawing.Point(642, 12);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(30, 30);
            this.buttonSalir.TabIndex = 0;
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // richTextBoxCaja
            // 
            this.richTextBoxCaja.AcceptsTab = true;
            this.richTextBoxCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCaja.AutoWordSelection = true;
            this.richTextBoxCaja.BulletIndent = 4;
            this.richTextBoxCaja.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxCaja.Location = new System.Drawing.Point(12, 90);
            this.richTextBoxCaja.Name = "richTextBoxCaja";
            this.richTextBoxCaja.Size = new System.Drawing.Size(660, 358);
            this.richTextBoxCaja.TabIndex = 2;
            this.richTextBoxCaja.Text = resources.GetString("richTextBoxCaja.Text");
            // 
            // buttonAnalizar
            // 
            this.buttonAnalizar.FlatAppearance.BorderSize = 0;
            this.buttonAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalizar.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnalizar.ForeColor = System.Drawing.Color.Azure;
            this.buttonAnalizar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAnalizar.Image")));
            this.buttonAnalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAnalizar.Location = new System.Drawing.Point(12, 52);
            this.buttonAnalizar.Name = "buttonAnalizar";
            this.buttonAnalizar.Size = new System.Drawing.Size(100, 30);
            this.buttonAnalizar.TabIndex = 3;
            this.buttonAnalizar.Text = "Compilar";
            this.buttonAnalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAnalizar.UseVisualStyleBackColor = true;
            this.buttonAnalizar.Click += new System.EventHandler(this.buttonAnalizar_Click);
            // 
            // buttonAST
            // 
            this.buttonAST.FlatAppearance.BorderSize = 0;
            this.buttonAST.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAST.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAST.ForeColor = System.Drawing.Color.Azure;
            this.buttonAST.Image = ((System.Drawing.Image)(resources.GetObject("buttonAST.Image")));
            this.buttonAST.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAST.Location = new System.Drawing.Point(118, 53);
            this.buttonAST.Name = "buttonAST";
            this.buttonAST.Size = new System.Drawing.Size(110, 30);
            this.buttonAST.TabIndex = 3;
            this.buttonAST.Text = "Ver Arbol";
            this.buttonAST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAST.UseVisualStyleBackColor = true;
            this.buttonAST.Click += new System.EventHandler(this.buttonAST_Click);
            // 
            // buttonTablas
            // 
            this.buttonTablas.FlatAppearance.BorderSize = 0;
            this.buttonTablas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTablas.Font = new System.Drawing.Font("Bell MT", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTablas.ForeColor = System.Drawing.Color.Azure;
            this.buttonTablas.Image = ((System.Drawing.Image)(resources.GetObject("buttonTablas.Image")));
            this.buttonTablas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTablas.Location = new System.Drawing.Point(234, 52);
            this.buttonTablas.Name = "buttonTablas";
            this.buttonTablas.Size = new System.Drawing.Size(115, 30);
            this.buttonTablas.TabIndex = 3;
            this.buttonTablas.Text = "Ver Tablas";
            this.buttonTablas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonTablas.UseVisualStyleBackColor = true;
            this.buttonTablas.Click += new System.EventHandler(this.buttonTablas_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 500;
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

