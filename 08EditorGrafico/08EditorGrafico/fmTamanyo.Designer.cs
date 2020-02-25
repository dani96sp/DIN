namespace _08EditorGrafico
{
    partial class fmTamanyo
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
            if (disposing && (components != null))
            {
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
            this.laIzda = new System.Windows.Forms.Label();
            this.laDcha = new System.Windows.Forms.Label();
            this.tbIzda = new System.Windows.Forms.TextBox();
            this.tbDcha = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laIzda
            // 
            this.laIzda.AutoSize = true;
            this.laIzda.Location = new System.Drawing.Point(29, 23);
            this.laIzda.Name = "laIzda";
            this.laIzda.Size = new System.Drawing.Size(38, 13);
            this.laIzda.TabIndex = 0;
            this.laIzda.Text = "Ancho";
            // 
            // laDcha
            // 
            this.laDcha.AutoSize = true;
            this.laDcha.Location = new System.Drawing.Point(141, 23);
            this.laDcha.Name = "laDcha";
            this.laDcha.Size = new System.Drawing.Size(38, 13);
            this.laDcha.TabIndex = 1;
            this.laDcha.Text = "Ancho";
            // 
            // tbIzda
            // 
            this.tbIzda.Location = new System.Drawing.Point(12, 39);
            this.tbIzda.Name = "tbIzda";
            this.tbIzda.Size = new System.Drawing.Size(100, 20);
            this.tbIzda.TabIndex = 2;
            this.tbIzda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlto_KeyPress);
            // 
            // tbDcha
            // 
            this.tbDcha.Location = new System.Drawing.Point(144, 39);
            this.tbDcha.Name = "tbDcha";
            this.tbDcha.Size = new System.Drawing.Size(100, 20);
            this.tbDcha.TabIndex = 3;
            this.tbDcha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlto_KeyPress);
            // 
            // btAceptar
            // 
            this.btAceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAceptar.Location = new System.Drawing.Point(23, 80);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 4;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(155, 80);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // fmTamanyo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 136);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbDcha);
            this.Controls.Add(this.tbIzda);
            this.Controls.Add(this.laDcha);
            this.Controls.Add(this.laIzda);
            this.Name = "fmTamanyo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        public System.Windows.Forms.TextBox tbIzda;
        public System.Windows.Forms.TextBox tbDcha;
        public System.Windows.Forms.Label laIzda;
        public System.Windows.Forms.Label laDcha;
    }
}