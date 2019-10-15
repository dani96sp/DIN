namespace ediciondatos
{
    partial class fmEdicion
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
            if (disposing && (components != null)) {
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
            this.tbEuros = new System.Windows.Forms.TextBox();
            this.tbPesetas = new System.Windows.Forms.TextBox();
            this.btDatos = new System.Windows.Forms.Button();
            this.btCambiar = new System.Windows.Forms.Button();
            this.btAcercade = new System.Windows.Forms.Button();
            this.laEuros = new System.Windows.Forms.Label();
            this.laPesetas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbEuros
            // 
            this.tbEuros.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEuros.Location = new System.Drawing.Point(53, 74);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(100, 23);
            this.tbEuros.TabIndex = 0;
            this.tbEuros.Text = "0";
            this.tbEuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbEuros.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            this.tbEuros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // tbPesetas
            // 
            this.tbPesetas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPesetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPesetas.Location = new System.Drawing.Point(261, 74);
            this.tbPesetas.Name = "tbPesetas";
            this.tbPesetas.Size = new System.Drawing.Size(100, 23);
            this.tbPesetas.TabIndex = 0;
            this.tbPesetas.Text = "0";
            this.tbPesetas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbPesetas.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            this.tbPesetas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbEuros_KeyPress);
            // 
            // btDatos
            // 
            this.btDatos.Location = new System.Drawing.Point(549, 244);
            this.btDatos.Name = "btDatos";
            this.btDatos.Size = new System.Drawing.Size(104, 23);
            this.btDatos.TabIndex = 1;
            this.btDatos.Text = "Introducir Datos";
            this.btDatos.UseVisualStyleBackColor = true;
            this.btDatos.Click += new System.EventHandler(this.btDatos_Click);
            // 
            // btCambiar
            // 
            this.btCambiar.Location = new System.Drawing.Point(163, 108);
            this.btCambiar.Name = "btCambiar";
            this.btCambiar.Size = new System.Drawing.Size(75, 23);
            this.btCambiar.TabIndex = 2;
            this.btCambiar.Text = "Cambiar";
            this.btCambiar.UseVisualStyleBackColor = true;
            this.btCambiar.Click += new System.EventHandler(this.btCambiar_Click);
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(640, 36);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(75, 23);
            this.btAcercade.TabIndex = 3;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // laEuros
            // 
            this.laEuros.AutoSize = true;
            this.laEuros.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laEuros.Location = new System.Drawing.Point(75, 47);
            this.laEuros.Name = "laEuros";
            this.laEuros.Size = new System.Drawing.Size(60, 24);
            this.laEuros.TabIndex = 4;
            this.laEuros.Text = "Euros";
            // 
            // laPesetas
            // 
            this.laPesetas.AutoSize = true;
            this.laPesetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPesetas.Location = new System.Drawing.Point(273, 47);
            this.laPesetas.Name = "laPesetas";
            this.laPesetas.Size = new System.Drawing.Size(76, 24);
            this.laPesetas.TabIndex = 5;
            this.laPesetas.Text = "Pesetas";
            this.laPesetas.Validated += new System.EventHandler(this.laPesetas_Validated);
            // 
            // fmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laPesetas);
            this.Controls.Add(this.laEuros);
            this.Controls.Add(this.btAcercade);
            this.Controls.Add(this.btCambiar);
            this.Controls.Add(this.btDatos);
            this.Controls.Add(this.tbPesetas);
            this.Controls.Add(this.tbEuros);
            this.Name = "fmEdicion";
            this.Text = "Form1";
            this.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEuros;
        private System.Windows.Forms.TextBox tbPesetas;
        private System.Windows.Forms.Button btDatos;
        private System.Windows.Forms.Button btCambiar;
        private System.Windows.Forms.Button btAcercade;
        private System.Windows.Forms.Label laEuros;
        private System.Windows.Forms.Label laPesetas;
    }
}

