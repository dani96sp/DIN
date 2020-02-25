namespace _06Editor {
    partial class fmDatos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.laTitulo = new System.Windows.Forms.Label();
            this.tbDato = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.laDato = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // laTitulo
            // 
            this.laTitulo.AutoSize = true;
            this.laTitulo.Location = new System.Drawing.Point(32, 9);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(38, 17);
            this.laTitulo.TabIndex = 0;
            this.laTitulo.Text = "titulo";
            // 
            // tbDato
            // 
            this.tbDato.Location = new System.Drawing.Point(35, 29);
            this.tbDato.Name = "tbDato";
            this.tbDato.Size = new System.Drawing.Size(197, 22);
            this.tbDato.TabIndex = 1;
            this.tbDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btAceptar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(35, 57);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(88, 28);
            this.btAceptar.TabIndex = 2;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(144, 57);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(88, 28);
            this.btCancelar.TabIndex = 3;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Introducción de: ";
            // 
            // laDato
            // 
            this.laDato.AutoSize = true;
            this.laDato.Location = new System.Drawing.Point(141, 94);
            this.laDato.Name = "laDato";
            this.laDato.Size = new System.Drawing.Size(0, 17);
            this.laDato.TabIndex = 5;
            // 
            // fmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 120);
            this.Controls.Add(this.laDato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbDato);
            this.Controls.Add(this.laTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "fmDatos";
            this.Text = "Peticion Dato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label laTitulo;
        public System.Windows.Forms.TextBox tbDato;
        public System.Windows.Forms.Label laDato;
    }
}