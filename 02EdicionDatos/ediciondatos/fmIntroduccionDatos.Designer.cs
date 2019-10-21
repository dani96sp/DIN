namespace ediciondatos
{
    partial class fmIntroduccionDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.laNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.laDireccion = new System.Windows.Forms.Label();
            this.laTelefono = new System.Windows.Forms.Label();
            this.laDni = new System.Windows.Forms.Label();
            this.tbCodigoPostal = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.laCodigoPostal = new System.Windows.Forms.Label();
            this.laLocalidad = new System.Windows.Forms.Label();
            this.laEmail = new System.Windows.Forms.Label();
            this.laPassword1 = new System.Windows.Forms.Label();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.laPassword2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(32, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(334, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // laNombre
            // 
            this.laNombre.AutoSize = true;
            this.laNombre.Location = new System.Drawing.Point(54, 32);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(44, 13);
            this.laNombre.TabIndex = 1;
            this.laNombre.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Los datos marcados con * son obligatorios";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(32, 121);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(181, 20);
            this.tbDireccion.TabIndex = 2;
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(32, 195);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(100, 20);
            this.tbTelefono.TabIndex = 5;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(32, 276);
            this.tbDni.Name = "tbDni";
            this.tbDni.Size = new System.Drawing.Size(100, 20);
            this.tbDni.TabIndex = 8;
            this.tbDni.Leave += new System.EventHandler(this.tbDni_Leave);
            // 
            // laDireccion
            // 
            this.laDireccion.AutoSize = true;
            this.laDireccion.Location = new System.Drawing.Point(54, 105);
            this.laDireccion.Name = "laDireccion";
            this.laDireccion.Size = new System.Drawing.Size(52, 13);
            this.laDireccion.TabIndex = 1;
            this.laDireccion.Text = "Dirección";
            // 
            // laTelefono
            // 
            this.laTelefono.AutoSize = true;
            this.laTelefono.Location = new System.Drawing.Point(54, 179);
            this.laTelefono.Name = "laTelefono";
            this.laTelefono.Size = new System.Drawing.Size(49, 13);
            this.laTelefono.TabIndex = 1;
            this.laTelefono.Text = "Teléfono";
            // 
            // laDni
            // 
            this.laDni.AutoSize = true;
            this.laDni.Location = new System.Drawing.Point(54, 260);
            this.laDni.Name = "laDni";
            this.laDni.Size = new System.Drawing.Size(47, 13);
            this.laDni.TabIndex = 1;
            this.laDni.Text = "DNI/CIF";
            // 
            // tbCodigoPostal
            // 
            this.tbCodigoPostal.Location = new System.Drawing.Point(393, 121);
            this.tbCodigoPostal.Name = "tbCodigoPostal";
            this.tbCodigoPostal.Size = new System.Drawing.Size(70, 20);
            this.tbCodigoPostal.TabIndex = 4;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(240, 121);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(126, 20);
            this.tbLocalidad.TabIndex = 3;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(240, 195);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(178, 20);
            this.tbEmail.TabIndex = 7;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            this.tbEmail.Leave += new System.EventHandler(this.tbEmail_Leave);
            // 
            // tbPassword1
            // 
            this.tbPassword1.Location = new System.Drawing.Point(240, 276);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.PasswordChar = '*';
            this.tbPassword1.Size = new System.Drawing.Size(126, 20);
            this.tbPassword1.TabIndex = 9;
            // 
            // laCodigoPostal
            // 
            this.laCodigoPostal.AutoSize = true;
            this.laCodigoPostal.Location = new System.Drawing.Point(392, 105);
            this.laCodigoPostal.Name = "laCodigoPostal";
            this.laCodigoPostal.Size = new System.Drawing.Size(72, 13);
            this.laCodigoPostal.TabIndex = 1;
            this.laCodigoPostal.Text = "Código Postal";
            // 
            // laLocalidad
            // 
            this.laLocalidad.AutoSize = true;
            this.laLocalidad.Location = new System.Drawing.Point(246, 105);
            this.laLocalidad.Name = "laLocalidad";
            this.laLocalidad.Size = new System.Drawing.Size(53, 13);
            this.laLocalidad.TabIndex = 1;
            this.laLocalidad.Text = "Localidad";
            // 
            // laEmail
            // 
            this.laEmail.AutoSize = true;
            this.laEmail.Location = new System.Drawing.Point(246, 179);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(31, 13);
            this.laEmail.TabIndex = 1;
            this.laEmail.Text = "email";
            // 
            // laPassword1
            // 
            this.laPassword1.AutoSize = true;
            this.laPassword1.Location = new System.Drawing.Point(246, 260);
            this.laPassword1.Name = "laPassword1";
            this.laPassword1.Size = new System.Drawing.Size(61, 13);
            this.laPassword1.TabIndex = 1;
            this.laPassword1.Text = "Contraseña";
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(240, 315);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '*';
            this.tbPassword2.Size = new System.Drawing.Size(126, 20);
            this.tbPassword2.TabIndex = 10;
            // 
            // laPassword2
            // 
            this.laPassword2.AutoSize = true;
            this.laPassword2.Location = new System.Drawing.Point(246, 299);
            this.laPassword2.Name = "laPassword2";
            this.laPassword2.Size = new System.Drawing.Size(95, 13);
            this.laPassword2.TabIndex = 1;
            this.laPassword2.Text = "Repite Contraseña";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(372, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(138, 279);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "*";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(32, 346);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 11;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(138, 346);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 12;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(442, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "A58818501";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(461, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "P0300008J";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(457, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "G03548005";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(457, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "P0305900C";
            // 
            // fmIntroduccionDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 386);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.laPassword2);
            this.Controls.Add(this.laPassword1);
            this.Controls.Add(this.laDni);
            this.Controls.Add(this.laEmail);
            this.Controls.Add(this.laTelefono);
            this.Controls.Add(this.laLocalidad);
            this.Controls.Add(this.laDireccion);
            this.Controls.Add(this.tbPassword2);
            this.Controls.Add(this.laCodigoPostal);
            this.Controls.Add(this.tbPassword1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.laNombre);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbDni);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.tbTelefono);
            this.Controls.Add(this.tbCodigoPostal);
            this.Controls.Add(this.tbDireccion);
            this.Controls.Add(this.tbNombre);
            this.KeyPreview = true;
            this.Name = "fmIntroduccionDatos";
            this.Text = "fmIntroduccionDatos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fmIntroduccionDatos_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label laDireccion;
        private System.Windows.Forms.Label laTelefono;
        private System.Windows.Forms.Label laDni;
        private System.Windows.Forms.Label laCodigoPostal;
        private System.Windows.Forms.Label laLocalidad;
        private System.Windows.Forms.Label laEmail;
        private System.Windows.Forms.Label laPassword1;
        private System.Windows.Forms.Label laPassword2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDireccion;
        public System.Windows.Forms.TextBox tbLocalidad;
        public System.Windows.Forms.TextBox tbCodigoPostal;
        public System.Windows.Forms.TextBox tbTelefono;
        public System.Windows.Forms.TextBox tbEmail;
        public System.Windows.Forms.TextBox tbDni;
        public System.Windows.Forms.TextBox tbPassword1;
        public System.Windows.Forms.TextBox tbPassword2;
    }
}