namespace _05miniEditor
{
    partial class Form1
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
            this.pnEditor = new System.Windows.Forms.Panel();
            this.pnEstado = new System.Windows.Forms.Panel();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbColores = new System.Windows.Forms.ListBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.rbIzquierda = new System.Windows.Forms.RadioButton();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbEstilo = new System.Windows.Forms.GroupBox();
            this.ckbNegrita = new System.Windows.Forms.CheckBox();
            this.btAbrir = new System.Windows.Forms.Button();
            this.cbFuentes = new System.Windows.Forms.ComboBox();
            this.cbTamanyo = new System.Windows.Forms.ComboBox();
            this.gbAlineacion = new System.Windows.Forms.GroupBox();
            this.ckbSubrayado = new System.Windows.Forms.CheckBox();
            this.ckbCursiva = new System.Windows.Forms.CheckBox();
            this.ckbTachado = new System.Windows.Forms.CheckBox();
            this.rbCentro = new System.Windows.Forms.RadioButton();
            this.rbDerecha = new System.Windows.Forms.RadioButton();
            this.pnEditor.SuspendLayout();
            this.gbEstilo.SuspendLayout();
            this.gbAlineacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEditor
            // 
            this.pnEditor.Controls.Add(this.cbTamanyo);
            this.pnEditor.Controls.Add(this.gbAlineacion);
            this.pnEditor.Controls.Add(this.cbFuentes);
            this.pnEditor.Controls.Add(this.gbEstilo);
            this.pnEditor.Controls.Add(this.tbNombre);
            this.pnEditor.Controls.Add(this.btAbrir);
            this.pnEditor.Controls.Add(this.btGuardar);
            this.pnEditor.Controls.Add(this.lbColores);
            this.pnEditor.Controls.Add(this.label3);
            this.pnEditor.Controls.Add(this.label2);
            this.pnEditor.Controls.Add(this.label1);
            this.pnEditor.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEditor.Location = new System.Drawing.Point(0, 0);
            this.pnEditor.Name = "pnEditor";
            this.pnEditor.Size = new System.Drawing.Size(800, 290);
            this.pnEditor.TabIndex = 0;
            // 
            // pnEstado
            // 
            this.pnEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnEstado.Location = new System.Drawing.Point(0, 421);
            this.pnEstado.Name = "pnEstado";
            this.pnEstado.Size = new System.Drawing.Size(800, 29);
            this.pnEstado.TabIndex = 1;
            // 
            // rtbEditor
            // 
            this.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditor.Location = new System.Drawing.Point(0, 290);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(800, 131);
            this.rtbEditor.TabIndex = 2;
            this.rtbEditor.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tamaño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Color de Fuente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbColores
            // 
            this.lbColores.FormattingEnabled = true;
            this.lbColores.ItemHeight = 16;
            this.lbColores.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Gril",
            "Naranja",
            "Amarillo",
            "Negro"});
            this.lbColores.Location = new System.Drawing.Point(147, 130);
            this.lbColores.Name = "lbColores";
            this.lbColores.Size = new System.Drawing.Size(120, 116);
            this.lbColores.TabIndex = 1;
            this.lbColores.SelectedIndexChanged += new System.EventHandler(this.lbColores_SelectedIndexChanged);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(12, 216);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 2;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // rbIzquierda
            // 
            this.rbIzquierda.AutoSize = true;
            this.rbIzquierda.Location = new System.Drawing.Point(6, 24);
            this.rbIzquierda.Name = "rbIzquierda";
            this.rbIzquierda.Size = new System.Drawing.Size(87, 21);
            this.rbIzquierda.TabIndex = 3;
            this.rbIzquierda.TabStop = true;
            this.rbIzquierda.Text = "Izquierda";
            this.rbIzquierda.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(8, 252);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 22);
            this.tbNombre.TabIndex = 4;
            // 
            // gbEstilo
            // 
            this.gbEstilo.Controls.Add(this.ckbTachado);
            this.gbEstilo.Controls.Add(this.ckbCursiva);
            this.gbEstilo.Controls.Add(this.ckbSubrayado);
            this.gbEstilo.Controls.Add(this.ckbNegrita);
            this.gbEstilo.Location = new System.Drawing.Point(353, 39);
            this.gbEstilo.Name = "gbEstilo";
            this.gbEstilo.Size = new System.Drawing.Size(138, 143);
            this.gbEstilo.TabIndex = 5;
            this.gbEstilo.TabStop = false;
            this.gbEstilo.Text = "Estilo";
            // 
            // ckbNegrita
            // 
            this.ckbNegrita.AutoSize = true;
            this.ckbNegrita.Location = new System.Drawing.Point(3, 18);
            this.ckbNegrita.Name = "ckbNegrita";
            this.ckbNegrita.Size = new System.Drawing.Size(76, 21);
            this.ckbNegrita.TabIndex = 0;
            this.ckbNegrita.Text = "Negrita";
            this.ckbNegrita.UseVisualStyleBackColor = true;
            this.ckbNegrita.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(12, 187);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 2;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            // 
            // cbFuentes
            // 
            this.cbFuentes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuentes.FormattingEnabled = true;
            this.cbFuentes.Location = new System.Drawing.Point(15, 39);
            this.cbFuentes.Name = "cbFuentes";
            this.cbFuentes.Size = new System.Drawing.Size(121, 24);
            this.cbFuentes.TabIndex = 6;
            // 
            // cbTamanyo
            // 
            this.cbTamanyo.FormattingEnabled = true;
            this.cbTamanyo.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "24"});
            this.cbTamanyo.Location = new System.Drawing.Point(174, 39);
            this.cbTamanyo.MaxLength = 2;
            this.cbTamanyo.Name = "cbTamanyo";
            this.cbTamanyo.Size = new System.Drawing.Size(66, 24);
            this.cbTamanyo.TabIndex = 6;
            this.cbTamanyo.TextChanged += new System.EventHandler(this.cbTamanyo_TextChanged);
            this.cbTamanyo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbTamanyo_KeyPress);
            // 
            // gbAlineacion
            // 
            this.gbAlineacion.Controls.Add(this.rbDerecha);
            this.gbAlineacion.Controls.Add(this.rbCentro);
            this.gbAlineacion.Controls.Add(this.rbIzquierda);
            this.gbAlineacion.Location = new System.Drawing.Point(600, 57);
            this.gbAlineacion.Name = "gbAlineacion";
            this.gbAlineacion.Size = new System.Drawing.Size(117, 100);
            this.gbAlineacion.TabIndex = 5;
            this.gbAlineacion.TabStop = false;
            this.gbAlineacion.Text = "Alineacion";
            // 
            // ckbSubrayado
            // 
            this.ckbSubrayado.AutoSize = true;
            this.ckbSubrayado.Location = new System.Drawing.Point(3, 45);
            this.ckbSubrayado.Name = "ckbSubrayado";
            this.ckbSubrayado.Size = new System.Drawing.Size(99, 21);
            this.ckbSubrayado.TabIndex = 0;
            this.ckbSubrayado.Text = "Subrayado";
            this.ckbSubrayado.UseVisualStyleBackColor = true;
            this.ckbSubrayado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbCursiva
            // 
            this.ckbCursiva.AutoSize = true;
            this.ckbCursiva.Location = new System.Drawing.Point(3, 72);
            this.ckbCursiva.Name = "ckbCursiva";
            this.ckbCursiva.Size = new System.Drawing.Size(77, 21);
            this.ckbCursiva.TabIndex = 0;
            this.ckbCursiva.Text = "Cursiva";
            this.ckbCursiva.UseVisualStyleBackColor = true;
            this.ckbCursiva.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ckbTachado
            // 
            this.ckbTachado.AutoSize = true;
            this.ckbTachado.Location = new System.Drawing.Point(3, 99);
            this.ckbTachado.Name = "ckbTachado";
            this.ckbTachado.Size = new System.Drawing.Size(86, 21);
            this.ckbTachado.TabIndex = 0;
            this.ckbTachado.Text = "Tachado";
            this.ckbTachado.UseVisualStyleBackColor = true;
            this.ckbTachado.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rbCentro
            // 
            this.rbCentro.AutoSize = true;
            this.rbCentro.Location = new System.Drawing.Point(6, 46);
            this.rbCentro.Name = "rbCentro";
            this.rbCentro.Size = new System.Drawing.Size(71, 21);
            this.rbCentro.TabIndex = 3;
            this.rbCentro.TabStop = true;
            this.rbCentro.Text = "Centro";
            this.rbCentro.UseVisualStyleBackColor = true;
            // 
            // rbDerecha
            // 
            this.rbDerecha.AutoSize = true;
            this.rbDerecha.Location = new System.Drawing.Point(6, 73);
            this.rbDerecha.Name = "rbDerecha";
            this.rbDerecha.Size = new System.Drawing.Size(83, 21);
            this.rbDerecha.TabIndex = 3;
            this.rbDerecha.TabStop = true;
            this.rbDerecha.Text = "Derecha";
            this.rbDerecha.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.pnEstado);
            this.Controls.Add(this.pnEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnEditor.ResumeLayout(false);
            this.pnEditor.PerformLayout();
            this.gbEstilo.ResumeLayout(false);
            this.gbEstilo.PerformLayout();
            this.gbAlineacion.ResumeLayout(false);
            this.gbAlineacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnEditor;
        private System.Windows.Forms.ComboBox cbFuentes;
        private System.Windows.Forms.GroupBox gbEstilo;
        private System.Windows.Forms.CheckBox ckbNegrita;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.RadioButton rbIzquierda;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.ListBox lbColores;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnEstado;
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.ComboBox cbTamanyo;
        private System.Windows.Forms.GroupBox gbAlineacion;
        private System.Windows.Forms.RadioButton rbDerecha;
        private System.Windows.Forms.RadioButton rbCentro;
        private System.Windows.Forms.CheckBox ckbTachado;
        private System.Windows.Forms.CheckBox ckbCursiva;
        private System.Windows.Forms.CheckBox ckbSubrayado;
    }
}

