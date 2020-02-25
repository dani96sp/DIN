namespace _06Editor {
    partial class fmMargenes {
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbIzquierda = new System.Windows.Forms.ComboBox();
            this.cbDerecha = new System.Windows.Forms.ComboBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce Márgenes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Izquierda";
            // 
            // cbIzquierda
            // 
            this.cbIzquierda.FormattingEnabled = true;
            this.cbIzquierda.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100"});
            this.cbIzquierda.Location = new System.Drawing.Point(63, 122);
            this.cbIzquierda.Name = "cbIzquierda";
            this.cbIzquierda.Size = new System.Drawing.Size(70, 24);
            this.cbIzquierda.TabIndex = 2;
            this.cbIzquierda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIzquierda_KeyPress);
            // 
            // cbDerecha
            // 
            this.cbDerecha.FormattingEnabled = true;
            this.cbDerecha.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "50",
            "100"});
            this.cbDerecha.Location = new System.Drawing.Point(180, 122);
            this.cbDerecha.Name = "cbDerecha";
            this.cbDerecha.Size = new System.Drawing.Size(70, 24);
            this.cbDerecha.TabIndex = 3;
            this.cbDerecha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIzquierda_KeyPress);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(63, 192);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(180, 192);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Derecha";
            // 
            // fmMargenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 243);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.cbDerecha);
            this.Controls.Add(this.cbIzquierda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "fmMargenes";
            this.Text = "fmMargenes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cbIzquierda;
        public System.Windows.Forms.ComboBox cbDerecha;
    }
}