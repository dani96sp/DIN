namespace _04ArrastarSoltar {
    partial class fmArrastrarSoltar {
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
            this.lb1.ItemHeight = 16;
            this.lb1.Items.AddRange(new object[] {
            "pepe",
            "dasd"});
            this.lb1.Location = new System.Drawing.Point(155, 142);
            this.lb1.Margin = new System.Windows.Forms.Padding(4);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(159, 212);
            this.lb1.TabIndex = 0;
            this.lb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb2_DragEnter);
            this.lb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseDown_1);
            // 
            // lb2
            // 
            this.lb2.AllowDrop = true;
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 16;
            this.lb2.Items.AddRange(new object[] {
            "qweqweqwe",
            "123"});
            this.lb2.Location = new System.Drawing.Point(437, 142);
            this.lb2.Margin = new System.Windows.Forms.Padding(4);
            this.lb2.Name = "lb2";
            this.lb2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb2.Size = new System.Drawing.Size(159, 212);
            this.lb2.TabIndex = 0;
            this.lb2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb2_DragEnter);
            this.lb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseDown_1);
            // 
            // btBorrar1
            // 
            this.btBorrar1.Image = global::_04ArrastarSoltar.Properties.Resources.Clearwindowcontent_6304_32;
            this.btBorrar1.Location = new System.Drawing.Point(224, 106);
            this.btBorrar1.Margin = new System.Windows.Forms.Padding(4);
            this.btBorrar1.Name = "btBorrar1";
            this.btBorrar1.Size = new System.Drawing.Size(32, 28);
            this.btBorrar1.TabIndex = 2;
            this.btBorrar1.UseVisualStyleBackColor = true;
            this.btBorrar1.Click += new System.EventHandler(this.btBorrar1_Click);
            // 
            // ckOrdena1
            // 
            this.ckOrdena1.AutoSize = true;
            this.ckOrdena1.Location = new System.Drawing.Point(175, 362);
            this.ckOrdena1.Margin = new System.Windows.Forms.Padding(4);
            this.ckOrdena1.Name = "ckOrdena1";
            this.ckOrdena1.Size = new System.Drawing.Size(78, 21);
            this.ckOrdena1.TabIndex = 3;
            this.ckOrdena1.Text = "Ordena";
            this.ckOrdena1.UseVisualStyleBackColor = true;
            this.ckOrdena1.CheckedChanged += new System.EventHandler(this.ckOrdena1_CheckedChanged);
            // 
            // ckOrdena2
            // 
            this.ckOrdena2.AutoSize = true;
            this.ckOrdena2.Location = new System.Drawing.Point(465, 362);
            this.ckOrdena2.Margin = new System.Windows.Forms.Padding(4);
            this.ckOrdena2.Name = "ckOrdena2";
            this.ckOrdena2.Size = new System.Drawing.Size(78, 21);
            this.ckOrdena2.TabIndex = 3;
            this.ckOrdena2.Text = "Ordena";
            this.ckOrdena2.UseVisualStyleBackColor = true;
            this.ckOrdena2.CheckedChanged += new System.EventHandler(this.ckOrdena2_CheckedChanged);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(636, 423);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 28);
            this.btSalir.TabIndex = 4;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(513, 423);
            this.btAcercade.Margin = new System.Windows.Forms.Padding(4);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(100, 28);
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
            this.laPrincipal.Location = new System.Drawing.Point(149, 11);
            this.laPrincipal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.laPrincipal.Name = "laPrincipal";
            this.laPrincipal.Size = new System.Drawing.Size(443, 58);
            this.laPrincipal.TabIndex = 6;
            this.laPrincipal.Text = "Arrastra un archivo de texto a los ListBox\r\nIntercambia los elementos entre ellos" +
    "";
            // 
            // btBorrar2
            // 
            this.btBorrar2.Image = global::_04ArrastarSoltar.Properties.Resources.Clearwindowcontent_6304_32;
            this.btBorrar2.Location = new System.Drawing.Point(513, 106);
            this.btBorrar2.Margin = new System.Windows.Forms.Padding(4);
            this.btBorrar2.Name = "btBorrar2";
            this.btBorrar2.Size = new System.Drawing.Size(32, 28);
            this.btBorrar2.TabIndex = 2;
            this.btBorrar2.UseVisualStyleBackColor = true;
            this.btBorrar2.Click += new System.EventHandler(this.btBorrar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 464);
            this.Controls.Add(this.laPrincipal);
            this.Controls.Add(this.btAcercade);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.ckOrdena2);
            this.Controls.Add(this.ckOrdena1);
            this.Controls.Add(this.btBorrar2);
            this.Controls.Add(this.btBorrar1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Arrastrar y Soltar";
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

