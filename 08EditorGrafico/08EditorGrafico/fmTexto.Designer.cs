namespace _08EditorGrafico {
    partial class fmTexto {
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
            this.btSalir = new System.Windows.Forms.Button();
            this.btAplicar = new System.Windows.Forms.Button();
            this.tbTexto = new System.Windows.Forms.TextBox();
            this.btFuente = new System.Windows.Forms.Button();
            this.dlgFuente = new System.Windows.Forms.FontDialog();
            this.SuspendLayout();
            // 
            // btSalir
            // 
            this.btSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btSalir.Image = global::_08EditorGrafico.Properties.Resources.Close_16xLG;
            this.btSalir.Location = new System.Drawing.Point(195, 12);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(31, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.UseVisualStyleBackColor = true;
            // 
            // btAplicar
            // 
            this.btAplicar.Image = global::_08EditorGrafico.Properties.Resources.applycodechanges_6548_32;
            this.btAplicar.Location = new System.Drawing.Point(158, 12);
            this.btAplicar.Name = "btAplicar";
            this.btAplicar.Size = new System.Drawing.Size(31, 23);
            this.btAplicar.TabIndex = 3;
            this.btAplicar.UseVisualStyleBackColor = true;
            this.btAplicar.Click += new System.EventHandler(this.btAplicar_Click);
            // 
            // tbTexto
            // 
            this.tbTexto.Location = new System.Drawing.Point(12, 12);
            this.tbTexto.Name = "tbTexto";
            this.tbTexto.Size = new System.Drawing.Size(100, 22);
            this.tbTexto.TabIndex = 1;
            // 
            // btFuente
            // 
            this.btFuente.Image = global::_08EditorGrafico.Properties.Resources.letterform_Asans_16xLG;
            this.btFuente.Location = new System.Drawing.Point(121, 12);
            this.btFuente.Name = "btFuente";
            this.btFuente.Size = new System.Drawing.Size(31, 23);
            this.btFuente.TabIndex = 2;
            this.btFuente.UseVisualStyleBackColor = true;
            this.btFuente.Click += new System.EventHandler(this.btFuente_Click);
            // 
            // dlgFuente
            // 
            this.dlgFuente.ShowColor = true;
            // 
            // fmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 47);
            this.Controls.Add(this.tbTexto);
            this.Controls.Add(this.btFuente);
            this.Controls.Add(this.btAplicar);
            this.Controls.Add(this.btSalir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "fmTexto";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.fmTexto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAplicar;
        private System.Windows.Forms.Button btFuente;
        private System.Windows.Forms.TextBox tbTexto;
        private System.Windows.Forms.FontDialog dlgFuente;
    }
}