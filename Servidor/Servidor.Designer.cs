namespace Servidor
{
    partial class Servidor
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
            this.txtNotas = new System.Windows.Forms.TextBox();
            this.txtTotalClientes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEventos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btnEnviarNotif = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtNotas
            // 
            this.txtNotas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotas.Location = new System.Drawing.Point(12, 64);
            this.txtNotas.Multiline = true;
            this.txtNotas.Name = "txtNotas";
            this.txtNotas.Size = new System.Drawing.Size(572, 107);
            this.txtNotas.TabIndex = 4;
            // 
            // txtTotalClientes
            // 
            this.txtTotalClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTotalClientes.Location = new System.Drawing.Point(130, 17);
            this.txtTotalClientes.Name = "txtTotalClientes";
            this.txtTotalClientes.ReadOnly = true;
            this.txtTotalClientes.Size = new System.Drawing.Size(171, 20);
            this.txtTotalClientes.TabIndex = 6;
            this.txtTotalClientes.Text = "0.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Clientes Conectados:";
            // 
            // txtEventos
            // 
            this.txtEventos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventos.Location = new System.Drawing.Point(12, 237);
            this.txtEventos.Multiline = true;
            this.txtEventos.Name = "txtEventos";
            this.txtEventos.ReadOnly = true;
            this.txtEventos.Size = new System.Drawing.Size(572, 104);
            this.txtEventos.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Comentarios para los clientes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Eventos del sistema de clientes:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Salir.Location = new System.Drawing.Point(474, 363);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(110, 23);
            this.btn_Salir.TabIndex = 14;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btnEnviarNotif
            // 
            this.btnEnviarNotif.Location = new System.Drawing.Point(240, 173);
            this.btnEnviarNotif.Name = "btnEnviarNotif";
            this.btnEnviarNotif.Size = new System.Drawing.Size(109, 23);
            this.btnEnviarNotif.TabIndex = 15;
            this.btnEnviarNotif.Text = "Enviar Notif.";
            this.btnEnviarNotif.UseVisualStyleBackColor = true;
            this.btnEnviarNotif.Click += new System.EventHandler(this.btnEnviarNotif_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Usuario a notificar:";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(113, 175);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(121, 21);
            this.cboClientes.TabIndex = 17;
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 398);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnEnviarNotif);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEventos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalClientes);
            this.Controls.Add(this.txtNotas);
            this.Name = "Servidor";
            this.Text = "Servidor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Servidor_FormClosed);
            this.Load += new System.EventHandler(this.Servidor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtNotas;
        private System.Windows.Forms.TextBox txtTotalClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEventos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btnEnviarNotif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboClientes;
    }
}

