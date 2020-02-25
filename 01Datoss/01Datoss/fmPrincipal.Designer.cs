namespace _01Datoss {
    partial class fmPrincipal {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.btConsultasFiltros = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAutomatico = new System.Windows.Forms.Button();
            this.btComandos = new System.Windows.Forms.Button();
            this.btAcercade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mantenimiento de Tablas";
            // 
            // btConsultasFiltros
            // 
            this.btConsultasFiltros.Location = new System.Drawing.Point(114, 175);
            this.btConsultasFiltros.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConsultasFiltros.Name = "btConsultasFiltros";
            this.btConsultasFiltros.Size = new System.Drawing.Size(173, 41);
            this.btConsultasFiltros.TabIndex = 2;
            this.btConsultasFiltros.Text = "Consultas y Filtros";
            this.btConsultasFiltros.UseVisualStyleBackColor = true;
            this.btConsultasFiltros.Click += new System.EventHandler(this.btConsultasFiltros_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(114, 221);
            this.btSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(173, 41);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btAutomatico
            // 
            this.btAutomatico.Location = new System.Drawing.Point(114, 130);
            this.btAutomatico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAutomatico.Name = "btAutomatico";
            this.btAutomatico.Size = new System.Drawing.Size(173, 41);
            this.btAutomatico.TabIndex = 4;
            this.btAutomatico.Text = "Automatico";
            this.btAutomatico.UseVisualStyleBackColor = true;
            this.btAutomatico.Click += new System.EventHandler(this.btAutomatico_Click_1);
            // 
            // btComandos
            // 
            this.btComandos.Location = new System.Drawing.Point(114, 83);
            this.btComandos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btComandos.Name = "btComandos";
            this.btComandos.Size = new System.Drawing.Size(173, 41);
            this.btComandos.TabIndex = 5;
            this.btComandos.Text = "Por Comandos";
            this.btComandos.UseVisualStyleBackColor = true;
            this.btComandos.Click += new System.EventHandler(this.btComandos_Click);
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(403, 237);
            this.btAcercade.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(134, 35);
            this.btAcercade.TabIndex = 7;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 324);
            this.Controls.Add(this.btAcercade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConsultasFiltros);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAutomatico);
            this.Controls.Add(this.btComandos);
            this.Name = "fmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConsultasFiltros;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAutomatico;
        private System.Windows.Forms.Button btComandos;
        private System.Windows.Forms.Button btAcercade;
    }
}

