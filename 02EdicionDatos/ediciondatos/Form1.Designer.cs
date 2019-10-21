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
            this.pnDatos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.laNombre = new System.Windows.Forms.Label();
            this.laTelefono = new System.Windows.Forms.Label();
            this.laDireccion = new System.Windows.Forms.Label();
            this.laLocalidad = new System.Windows.Forms.Label();
            this.laCodigoPostal = new System.Windows.Forms.Label();
            this.laEmail = new System.Windows.Forms.Label();
            this.laDNICIF = new System.Windows.Forms.Label();
            this.pnDatos.SuspendLayout();
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
            // pnDatos
            // 
            this.pnDatos.Controls.Add(this.laDNICIF);
            this.pnDatos.Controls.Add(this.label7);
            this.pnDatos.Controls.Add(this.laEmail);
            this.pnDatos.Controls.Add(this.label4);
            this.pnDatos.Controls.Add(this.laCodigoPostal);
            this.pnDatos.Controls.Add(this.label8);
            this.pnDatos.Controls.Add(this.laLocalidad);
            this.pnDatos.Controls.Add(this.label6);
            this.pnDatos.Controls.Add(this.laDireccion);
            this.pnDatos.Controls.Add(this.label3);
            this.pnDatos.Controls.Add(this.laTelefono);
            this.pnDatos.Controls.Add(this.label5);
            this.pnDatos.Controls.Add(this.laNombre);
            this.pnDatos.Controls.Add(this.label2);
            this.pnDatos.Controls.Add(this.label1);
            this.pnDatos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.pnDatos.Location = new System.Drawing.Point(0, 292);
            this.pnDatos.Name = "pnDatos";
            this.pnDatos.Size = new System.Drawing.Size(800, 158);
            this.pnDatos.TabIndex = 6;
            this.pnDatos.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOS DATOS INTRODUCIDOS SON:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Dirección";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(303, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Teléfono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(242, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Localidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(303, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "DNI/CIF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(418, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Código Postal";
            // 
            // laNombre
            // 
            this.laNombre.AutoSize = true;
            this.laNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laNombre.Location = new System.Drawing.Point(91, 64);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(14, 17);
            this.laNombre.TabIndex = 1;
            this.laNombre.Text = "x";
            // 
            // laTelefono
            // 
            this.laTelefono.AutoSize = true;
            this.laTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laTelefono.Location = new System.Drawing.Point(381, 64);
            this.laTelefono.Name = "laTelefono";
            this.laTelefono.Size = new System.Drawing.Size(14, 17);
            this.laTelefono.TabIndex = 1;
            this.laTelefono.Text = "x";
            // 
            // laDireccion
            // 
            this.laDireccion.AutoSize = true;
            this.laDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laDireccion.Location = new System.Drawing.Point(91, 93);
            this.laDireccion.Name = "laDireccion";
            this.laDireccion.Size = new System.Drawing.Size(14, 17);
            this.laDireccion.TabIndex = 1;
            this.laDireccion.Text = "x";
            // 
            // laLocalidad
            // 
            this.laLocalidad.AutoSize = true;
            this.laLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laLocalidad.Location = new System.Drawing.Point(326, 93);
            this.laLocalidad.Name = "laLocalidad";
            this.laLocalidad.Size = new System.Drawing.Size(14, 17);
            this.laLocalidad.TabIndex = 1;
            this.laLocalidad.Text = "x";
            // 
            // laCodigoPostal
            // 
            this.laCodigoPostal.AutoSize = true;
            this.laCodigoPostal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laCodigoPostal.Location = new System.Drawing.Point(532, 93);
            this.laCodigoPostal.Name = "laCodigoPostal";
            this.laCodigoPostal.Size = new System.Drawing.Size(14, 17);
            this.laCodigoPostal.TabIndex = 1;
            this.laCodigoPostal.Text = "x";
            // 
            // laEmail
            // 
            this.laEmail.AutoSize = true;
            this.laEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laEmail.Location = new System.Drawing.Point(91, 120);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(14, 17);
            this.laEmail.TabIndex = 1;
            this.laEmail.Text = "x";
            // 
            // laDNICIF
            // 
            this.laDNICIF.AutoSize = true;
            this.laDNICIF.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.laDNICIF.Location = new System.Drawing.Point(381, 120);
            this.laDNICIF.Name = "laDNICIF";
            this.laDNICIF.Size = new System.Drawing.Size(14, 17);
            this.laDNICIF.TabIndex = 1;
            this.laDNICIF.Text = "x";
            // 
            // fmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnDatos);
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
            this.pnDatos.ResumeLayout(false);
            this.pnDatos.PerformLayout();
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
        private System.Windows.Forms.Panel pnDatos;
        private System.Windows.Forms.Label laDNICIF;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label laEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label laCodigoPostal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label laLocalidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label laDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label laNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

