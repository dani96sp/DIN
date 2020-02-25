namespace _03Datos {
    partial class fmActualizar {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCapital = new System.Windows.Forms.TextBox();
            this.cbContinentes = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbPoblacion = new System.Windows.Forms.TextBox();
            this.tbPIB = new System.Windows.Forms.TextBox();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNombrePais = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // tbCapital
            // 
            this.tbCapital.Location = new System.Drawing.Point(37, 140);
            this.tbCapital.Name = "tbCapital";
            this.tbCapital.Size = new System.Drawing.Size(163, 22);
            this.tbCapital.TabIndex = 2;
            // 
            // cbContinentes
            // 
            this.cbContinentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinentes.FormattingEnabled = true;
            this.cbContinentes.Location = new System.Drawing.Point(310, 140);
            this.cbContinentes.Name = "cbContinentes";
            this.cbContinentes.Size = new System.Drawing.Size(163, 24);
            this.cbContinentes.TabIndex = 3;
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(68, 285);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(101, 26);
            this.btAceptar.TabIndex = 6;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(341, 285);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(101, 26);
            this.btCancelar.TabIndex = 7;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbPoblacion
            // 
            this.tbPoblacion.Location = new System.Drawing.Point(37, 217);
            this.tbPoblacion.Name = "tbPoblacion";
            this.tbPoblacion.Size = new System.Drawing.Size(163, 22);
            this.tbPoblacion.TabIndex = 4;
            this.tbPoblacion.Text = "0";
            this.tbPoblacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPoblacion_KeyPress);
            // 
            // tbPIB
            // 
            this.tbPIB.Location = new System.Drawing.Point(310, 217);
            this.tbPIB.Name = "tbPIB";
            this.tbPIB.Size = new System.Drawing.Size(163, 22);
            this.tbPIB.TabIndex = 5;
            this.tbPIB.Text = "0";
            this.tbPIB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPoblacion_KeyPress);
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(37, 55);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(163, 22);
            this.tbId.TabIndex = 1;
            this.tbId.TabStop = false;
            // 
            // tbNombrePais
            // 
            this.tbNombrePais.Location = new System.Drawing.Point(310, 55);
            this.tbNombrePais.Name = "tbNombrePais";
            this.tbNombrePais.Size = new System.Drawing.Size(163, 22);
            this.tbNombrePais.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre Pais";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Capital";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Continente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Poblacion (En Miles)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "PiB (En miles de millones)";
            // 
            // fmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 377);
            this.Controls.Add(this.cbContinentes);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbPIB);
            this.Controls.Add(this.tbPoblacion);
            this.Controls.Add(this.tbNombrePais);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbCapital);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "fmActualizar";
            this.Text = "Actualizar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbContinentes;
        public System.Windows.Forms.TextBox tbCapital;
        public System.Windows.Forms.TextBox tbPoblacion;
        public System.Windows.Forms.TextBox tbPIB;
        public System.Windows.Forms.TextBox tbId;
        public System.Windows.Forms.TextBox tbNombrePais;
    }
}