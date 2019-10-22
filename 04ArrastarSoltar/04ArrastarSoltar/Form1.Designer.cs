namespace _04ArrastarSoltar {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
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
        private void InitializeComponent() {
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btBorrar1 = new System.Windows.Forms.Button();
            this.ckOrdena1 = new System.Windows.Forms.CheckBox();
            this.ckOrdena2 = new System.Windows.Forms.CheckBox();
            this.btSalir = new System.Windows.Forms.Button();
            this.btAcercade = new System.Windows.Forms.Button();
            this.laPrincipal = new System.Windows.Forms.Label();
            this.btBorrar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AllowDrop = true;
            this.lb1.FormattingEnabled = true;
            this.lb1.Items.AddRange(new object[] {
            "pepe",
            "dasd"});
            this.lb1.Location = new System.Drawing.Point(116, 115);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb1.Size = new System.Drawing.Size(120, 173);
            this.lb1.TabIndex = 0;
            this.lb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseClick);
            this.lb1.SelectedValueChanged += new System.EventHandler(this.lb1_SelectedValueChanged);
            this.lb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb2_DragEnter);
            this.lb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseDown_1);
            this.lb1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseMove);
            this.lb1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseUp);
            // 
            // lb2
            // 
            this.lb2.AllowDrop = true;
            this.lb2.FormattingEnabled = true;
            this.lb2.Items.AddRange(new object[] {
            "qweqweqwe",
            "123"});
            this.lb2.Location = new System.Drawing.Point(328, 115);
            this.lb2.Name = "lb2";
            this.lb2.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lb2.Size = new System.Drawing.Size(120, 173);
            this.lb2.TabIndex = 0;
            this.lb2.SelectedValueChanged += new System.EventHandler(this.lb1_SelectedValueChanged);
            this.lb2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb2_DragEnter);
            this.lb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseDown_1);
            this.lb2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseMove);
            this.lb2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseUp);
            // 
            // btBorrar1
            // 
            this.btBorrar1.Image = global::_04ArrastarSoltar.Properties.Resources.Clearwindowcontent_6304_32;
            this.btBorrar1.Location = new System.Drawing.Point(168, 86);
            this.btBorrar1.Name = "btBorrar1";
            this.btBorrar1.Size = new System.Drawing.Size(24, 23);
            this.btBorrar1.TabIndex = 2;
            this.btBorrar1.UseVisualStyleBackColor = true;
            this.btBorrar1.Click += new System.EventHandler(this.btBorrar1_Click);
            // 
            // ckOrdena1
            // 
            this.ckOrdena1.AutoSize = true;
            this.ckOrdena1.Location = new System.Drawing.Point(131, 294);
            this.ckOrdena1.Name = "ckOrdena1";
            this.ckOrdena1.Size = new System.Drawing.Size(61, 17);
            this.ckOrdena1.TabIndex = 3;
            this.ckOrdena1.Text = "Ordena";
            this.ckOrdena1.UseVisualStyleBackColor = true;
            this.ckOrdena1.CheckedChanged += new System.EventHandler(this.ckOrdena1_CheckedChanged);
            // 
            // ckOrdena2
            // 
            this.ckOrdena2.AutoSize = true;
            this.ckOrdena2.Location = new System.Drawing.Point(349, 294);
            this.ckOrdena2.Name = "ckOrdena2";
            this.ckOrdena2.Size = new System.Drawing.Size(61, 17);
            this.ckOrdena2.TabIndex = 3;
            this.ckOrdena2.Text = "Ordena";
            this.ckOrdena2.UseVisualStyleBackColor = true;
            this.ckOrdena2.CheckedChanged += new System.EventHandler(this.ckOrdena2_CheckedChanged);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(477, 344);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(385, 344);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(75, 23);
            this.btAcercade.TabIndex = 5;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // laPrincipal
            // 
            this.laPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.laPrincipal.AutoSize = true;
            this.laPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPrincipal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.laPrincipal.Location = new System.Drawing.Point(112, 9);
            this.laPrincipal.Name = "laPrincipal";
            this.laPrincipal.Size = new System.Drawing.Size(348, 48);
            this.laPrincipal.TabIndex = 6;
            this.laPrincipal.Text = "Arrastra un archivo de texto a los ListBox\r\nIntercambia los elementos entre ellos" +
    "";
            // 
            // btBorrar2
            // 
            this.btBorrar2.Image = global::_04ArrastarSoltar.Properties.Resources.Clearwindowcontent_6304_32;
            this.btBorrar2.Location = new System.Drawing.Point(385, 86);
            this.btBorrar2.Name = "btBorrar2";
            this.btBorrar2.Size = new System.Drawing.Size(24, 23);
            this.btBorrar2.TabIndex = 2;
            this.btBorrar2.UseVisualStyleBackColor = true;
            this.btBorrar2.Click += new System.EventHandler(this.btBorrar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 377);
            this.Controls.Add(this.laPrincipal);
            this.Controls.Add(this.btAcercade);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.ckOrdena2);
            this.Controls.Add(this.ckOrdena1);
            this.Controls.Add(this.btBorrar2);
            this.Controls.Add(this.btBorrar1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btBorrar1;
        private System.Windows.Forms.CheckBox ckOrdena1;
        private System.Windows.Forms.CheckBox ckOrdena2;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btAcercade;
        private System.Windows.Forms.Label laPrincipal;
        private System.Windows.Forms.Button btBorrar2;
    }
}

