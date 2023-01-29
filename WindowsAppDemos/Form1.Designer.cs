namespace WindowsAppDemos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearObjetos = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnCrearMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearObjetos
            // 
            this.btnCrearObjetos.Location = new System.Drawing.Point(194, 22);
            this.btnCrearObjetos.Name = "btnCrearObjetos";
            this.btnCrearObjetos.Size = new System.Drawing.Size(373, 38);
            this.btnCrearObjetos.TabIndex = 0;
            this.btnCrearObjetos.Text = "Crear objetos";
            this.btnCrearObjetos.UseVisualStyleBackColor = true;
            this.btnCrearObjetos.Click += new System.EventHandler(this.btnCrearObjetos_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(194, 80);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(373, 38);
            this.btnSuma.TabIndex = 1;
            this.btnSuma.Text = "Sumar";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(374, 317);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 2;
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(194, 140);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(373, 39);
            this.btnClientes.TabIndex = 3;
            this.btnClientes.Text = "Crear clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Location = new System.Drawing.Point(194, 200);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(373, 44);
            this.btnListaClientes.TabIndex = 4;
            this.btnListaClientes.Text = "Crear lista de clientes";
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.Location = new System.Drawing.Point(194, 343);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(373, 82);
            this.lstClientes.TabIndex = 5;
            // 
            // btnCrearMedico
            // 
            this.btnCrearMedico.Location = new System.Drawing.Point(194, 265);
            this.btnCrearMedico.Name = "btnCrearMedico";
            this.btnCrearMedico.Size = new System.Drawing.Size(373, 49);
            this.btnCrearMedico.TabIndex = 6;
            this.btnCrearMedico.Text = "Crear Medico";
            this.btnCrearMedico.UseVisualStyleBackColor = true;
            this.btnCrearMedico.Click += new System.EventHandler(this.btnCrearMedico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearMedico);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.btnListaClientes);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnCrearObjetos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearObjetos;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnCrearMedico;
    }
}

