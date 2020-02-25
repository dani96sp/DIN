namespace Examen {
    partial class Examen {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNuevoPrincipal = new System.Windows.Forms.TextBox();
            this.cbAlmacenesPrincipales = new System.Windows.Forms.ComboBox();
            this.btAnyadirPrincipal = new System.Windows.Forms.Button();
            this.lbAlmacenesPrincipales = new System.Windows.Forms.ListBox();
            this.chkOrdenaPrincipales = new System.Windows.Forms.CheckBox();
            this.btDerechaSel = new System.Windows.Forms.Button();
            this.btIzquierdaSel = new System.Windows.Forms.Button();
            this.btDerechaTodos = new System.Windows.Forms.Button();
            this.btIzquierdaTodos = new System.Windows.Forms.Button();
            this.btEliminarPrincipal = new System.Windows.Forms.Button();
            this.btGuardarPrincipal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNuevoSecundario = new System.Windows.Forms.TextBox();
            this.cbAlmacenesSecundarios = new System.Windows.Forms.ComboBox();
            this.btAnyadirSecundarios = new System.Windows.Forms.Button();
            this.btEliminarSecundarios = new System.Windows.Forms.Button();
            this.btGuardarSecundarios = new System.Windows.Forms.Button();
            this.lbAlmacenesSecundarios = new System.Windows.Forms.ListBox();
            this.chkOrdenaSecundarios = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Almacenes Principales";
            // 
            // tbNuevoPrincipal
            // 
            this.tbNuevoPrincipal.Location = new System.Drawing.Point(99, 352);
            this.tbNuevoPrincipal.Name = "tbNuevoPrincipal";
            this.tbNuevoPrincipal.Size = new System.Drawing.Size(149, 22);
            this.tbNuevoPrincipal.TabIndex = 1;
            this.tbNuevoPrincipal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevoPrincipal_KeyPress);
            // 
            // cbAlmacenesPrincipales
            // 
            this.cbAlmacenesPrincipales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlmacenesPrincipales.FormattingEnabled = true;
            this.cbAlmacenesPrincipales.Items.AddRange(new object[] {
            "Almacen1",
            "Almacen2",
            "Almacen3"});
            this.cbAlmacenesPrincipales.Location = new System.Drawing.Point(100, 76);
            this.cbAlmacenesPrincipales.Name = "cbAlmacenesPrincipales";
            this.cbAlmacenesPrincipales.Size = new System.Drawing.Size(148, 24);
            this.cbAlmacenesPrincipales.TabIndex = 2;
            this.cbAlmacenesPrincipales.SelectedIndexChanged += new System.EventHandler(this.cbAlmacenesPrincipales_SelectedIndexChanged);
            // 
            // btAnyadirPrincipal
            // 
            this.btAnyadirPrincipal.Enabled = false;
            this.btAnyadirPrincipal.Image = global::Examen.Properties.Resources.action_add_16xLG;
            this.btAnyadirPrincipal.Location = new System.Drawing.Point(110, 317);
            this.btAnyadirPrincipal.Name = "btAnyadirPrincipal";
            this.btAnyadirPrincipal.Size = new System.Drawing.Size(36, 29);
            this.btAnyadirPrincipal.TabIndex = 3;
            this.btAnyadirPrincipal.UseVisualStyleBackColor = true;
            this.btAnyadirPrincipal.Click += new System.EventHandler(this.btAnyadirPrincipal_Click);
            // 
            // lbAlmacenesPrincipales
            // 
            this.lbAlmacenesPrincipales.AllowDrop = true;
            this.lbAlmacenesPrincipales.FormattingEnabled = true;
            this.lbAlmacenesPrincipales.ItemHeight = 16;
            this.lbAlmacenesPrincipales.Location = new System.Drawing.Point(101, 133);
            this.lbAlmacenesPrincipales.Name = "lbAlmacenesPrincipales";
            this.lbAlmacenesPrincipales.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAlmacenesPrincipales.Size = new System.Drawing.Size(147, 164);
            this.lbAlmacenesPrincipales.TabIndex = 4;
            this.lbAlmacenesPrincipales.SelectedIndexChanged += new System.EventHandler(this.lbAlmacenesPrincipales_SelectedIndexChanged);
            this.lbAlmacenesPrincipales.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbAlmacenesPrincipales_DragDrop);
            this.lbAlmacenesPrincipales.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbAlmacenesPrincipales_DragEnter);
            this.lbAlmacenesPrincipales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAlmacenesPrincipales_MouseDown);
            // 
            // chkOrdenaPrincipales
            // 
            this.chkOrdenaPrincipales.AutoSize = true;
            this.chkOrdenaPrincipales.Location = new System.Drawing.Point(110, 106);
            this.chkOrdenaPrincipales.Name = "chkOrdenaPrincipales";
            this.chkOrdenaPrincipales.Size = new System.Drawing.Size(78, 21);
            this.chkOrdenaPrincipales.TabIndex = 5;
            this.chkOrdenaPrincipales.Text = "Ordena";
            this.chkOrdenaPrincipales.UseVisualStyleBackColor = true;
            this.chkOrdenaPrincipales.CheckedChanged += new System.EventHandler(this.chkOrdenaPrincipales_CheckedChanged);
            // 
            // btDerechaSel
            // 
            this.btDerechaSel.Location = new System.Drawing.Point(277, 133);
            this.btDerechaSel.Name = "btDerechaSel";
            this.btDerechaSel.Size = new System.Drawing.Size(56, 23);
            this.btDerechaSel.TabIndex = 3;
            this.btDerechaSel.Text = ">";
            this.btDerechaSel.UseVisualStyleBackColor = true;
            this.btDerechaSel.Click += new System.EventHandler(this.btDerechaSel_Click);
            // 
            // btIzquierdaSel
            // 
            this.btIzquierdaSel.Location = new System.Drawing.Point(277, 162);
            this.btIzquierdaSel.Name = "btIzquierdaSel";
            this.btIzquierdaSel.Size = new System.Drawing.Size(56, 23);
            this.btIzquierdaSel.TabIndex = 3;
            this.btIzquierdaSel.Text = "<";
            this.btIzquierdaSel.UseVisualStyleBackColor = true;
            this.btIzquierdaSel.Click += new System.EventHandler(this.btIzquierdaSel_Click);
            // 
            // btDerechaTodos
            // 
            this.btDerechaTodos.Location = new System.Drawing.Point(277, 191);
            this.btDerechaTodos.Name = "btDerechaTodos";
            this.btDerechaTodos.Size = new System.Drawing.Size(56, 23);
            this.btDerechaTodos.TabIndex = 3;
            this.btDerechaTodos.Text = ">>";
            this.btDerechaTodos.UseVisualStyleBackColor = true;
            this.btDerechaTodos.Click += new System.EventHandler(this.btDerechaTodos_Click);
            // 
            // btIzquierdaTodos
            // 
            this.btIzquierdaTodos.Location = new System.Drawing.Point(277, 220);
            this.btIzquierdaTodos.Name = "btIzquierdaTodos";
            this.btIzquierdaTodos.Size = new System.Drawing.Size(56, 23);
            this.btIzquierdaTodos.TabIndex = 3;
            this.btIzquierdaTodos.Text = "<<";
            this.btIzquierdaTodos.UseVisualStyleBackColor = true;
            this.btIzquierdaTodos.Click += new System.EventHandler(this.btIzquierdaTodos_Click);
            // 
            // btEliminarPrincipal
            // 
            this.btEliminarPrincipal.Enabled = false;
            this.btEliminarPrincipal.Image = global::Examen.Properties.Resources._112_Minus_Orange_16x16_72;
            this.btEliminarPrincipal.Location = new System.Drawing.Point(160, 317);
            this.btEliminarPrincipal.Name = "btEliminarPrincipal";
            this.btEliminarPrincipal.Size = new System.Drawing.Size(36, 29);
            this.btEliminarPrincipal.TabIndex = 3;
            this.btEliminarPrincipal.UseVisualStyleBackColor = true;
            this.btEliminarPrincipal.Click += new System.EventHandler(this.btEliminarPrincipal_Click);
            // 
            // btGuardarPrincipal
            // 
            this.btGuardarPrincipal.Image = global::Examen.Properties.Resources.save_16xLG;
            this.btGuardarPrincipal.Location = new System.Drawing.Point(212, 317);
            this.btGuardarPrincipal.Name = "btGuardarPrincipal";
            this.btGuardarPrincipal.Size = new System.Drawing.Size(36, 29);
            this.btGuardarPrincipal.TabIndex = 3;
            this.btGuardarPrincipal.UseVisualStyleBackColor = true;
            this.btGuardarPrincipal.Click += new System.EventHandler(this.btGuardarPrincipal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(428, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Organización de Artículos por Almacén";
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.Location = new System.Drawing.Point(516, 384);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(105, 27);
            this.btAcercaDe.TabIndex = 3;
            this.btAcercaDe.Text = "Acerca de";
            this.btAcercaDe.UseVisualStyleBackColor = true;
            this.btAcercaDe.Click += new System.EventHandler(this.btAcercaDe_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(255, 384);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(92, 27);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Almacenes Secundarios";
            // 
            // tbNuevoSecundario
            // 
            this.tbNuevoSecundario.Location = new System.Drawing.Point(384, 352);
            this.tbNuevoSecundario.Name = "tbNuevoSecundario";
            this.tbNuevoSecundario.Size = new System.Drawing.Size(149, 22);
            this.tbNuevoSecundario.TabIndex = 1;
            this.tbNuevoSecundario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNuevoSecundario_KeyPress);
            // 
            // cbAlmacenesSecundarios
            // 
            this.cbAlmacenesSecundarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAlmacenesSecundarios.FormattingEnabled = true;
            this.cbAlmacenesSecundarios.Items.AddRange(new object[] {
            "Almacen4",
            "Almacen5",
            "Almacen6"});
            this.cbAlmacenesSecundarios.Location = new System.Drawing.Point(385, 76);
            this.cbAlmacenesSecundarios.Name = "cbAlmacenesSecundarios";
            this.cbAlmacenesSecundarios.Size = new System.Drawing.Size(148, 24);
            this.cbAlmacenesSecundarios.TabIndex = 2;
            this.cbAlmacenesSecundarios.SelectedIndexChanged += new System.EventHandler(this.cbAlmacenesSecundarios_SelectedIndexChanged);
            // 
            // btAnyadirSecundarios
            // 
            this.btAnyadirSecundarios.Enabled = false;
            this.btAnyadirSecundarios.Image = global::Examen.Properties.Resources.action_add_16xLG;
            this.btAnyadirSecundarios.Location = new System.Drawing.Point(395, 317);
            this.btAnyadirSecundarios.Name = "btAnyadirSecundarios";
            this.btAnyadirSecundarios.Size = new System.Drawing.Size(36, 29);
            this.btAnyadirSecundarios.TabIndex = 3;
            this.btAnyadirSecundarios.UseVisualStyleBackColor = true;
            this.btAnyadirSecundarios.Click += new System.EventHandler(this.btAnyadirSecundarios_Click);
            // 
            // btEliminarSecundarios
            // 
            this.btEliminarSecundarios.Enabled = false;
            this.btEliminarSecundarios.Image = global::Examen.Properties.Resources._112_Minus_Orange_16x16_72;
            this.btEliminarSecundarios.Location = new System.Drawing.Point(445, 317);
            this.btEliminarSecundarios.Name = "btEliminarSecundarios";
            this.btEliminarSecundarios.Size = new System.Drawing.Size(36, 29);
            this.btEliminarSecundarios.TabIndex = 3;
            this.btEliminarSecundarios.UseVisualStyleBackColor = true;
            this.btEliminarSecundarios.Click += new System.EventHandler(this.btEliminarSecundarios_Click);
            // 
            // btGuardarSecundarios
            // 
            this.btGuardarSecundarios.Image = global::Examen.Properties.Resources.save_16xLG;
            this.btGuardarSecundarios.Location = new System.Drawing.Point(497, 317);
            this.btGuardarSecundarios.Name = "btGuardarSecundarios";
            this.btGuardarSecundarios.Size = new System.Drawing.Size(36, 29);
            this.btGuardarSecundarios.TabIndex = 3;
            this.btGuardarSecundarios.UseVisualStyleBackColor = true;
            this.btGuardarSecundarios.Click += new System.EventHandler(this.btGuardarSecundarios_Click);
            // 
            // lbAlmacenesSecundarios
            // 
            this.lbAlmacenesSecundarios.AllowDrop = true;
            this.lbAlmacenesSecundarios.FormattingEnabled = true;
            this.lbAlmacenesSecundarios.ItemHeight = 16;
            this.lbAlmacenesSecundarios.Location = new System.Drawing.Point(386, 133);
            this.lbAlmacenesSecundarios.Name = "lbAlmacenesSecundarios";
            this.lbAlmacenesSecundarios.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbAlmacenesSecundarios.Size = new System.Drawing.Size(147, 164);
            this.lbAlmacenesSecundarios.TabIndex = 4;
            this.lbAlmacenesSecundarios.SelectedIndexChanged += new System.EventHandler(this.lbAlmacenesSecundarios_SelectedIndexChanged);
            this.lbAlmacenesSecundarios.DragDrop += new System.Windows.Forms.DragEventHandler(this.lbAlmacenesPrincipales_DragDrop);
            this.lbAlmacenesSecundarios.DragEnter += new System.Windows.Forms.DragEventHandler(this.lbAlmacenesPrincipales_DragEnter);
            this.lbAlmacenesSecundarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbAlmacenesSecundarios_MouseDown);
            // 
            // chkOrdenaSecundarios
            // 
            this.chkOrdenaSecundarios.AutoSize = true;
            this.chkOrdenaSecundarios.Location = new System.Drawing.Point(395, 106);
            this.chkOrdenaSecundarios.Name = "chkOrdenaSecundarios";
            this.chkOrdenaSecundarios.Size = new System.Drawing.Size(78, 21);
            this.chkOrdenaSecundarios.TabIndex = 5;
            this.chkOrdenaSecundarios.Text = "Ordena";
            this.chkOrdenaSecundarios.UseVisualStyleBackColor = true;
            this.chkOrdenaSecundarios.CheckedChanged += new System.EventHandler(this.chkOrdenaSecundarios_CheckedChanged);
            // 
            // Examen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkOrdenaSecundarios);
            this.Controls.Add(this.chkOrdenaPrincipales);
            this.Controls.Add(this.lbAlmacenesSecundarios);
            this.Controls.Add(this.lbAlmacenesPrincipales);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btIzquierdaTodos);
            this.Controls.Add(this.btDerechaTodos);
            this.Controls.Add(this.btIzquierdaSel);
            this.Controls.Add(this.btAcercaDe);
            this.Controls.Add(this.btGuardarSecundarios);
            this.Controls.Add(this.btDerechaSel);
            this.Controls.Add(this.btEliminarSecundarios);
            this.Controls.Add(this.btGuardarPrincipal);
            this.Controls.Add(this.btAnyadirSecundarios);
            this.Controls.Add(this.btEliminarPrincipal);
            this.Controls.Add(this.cbAlmacenesSecundarios);
            this.Controls.Add(this.btAnyadirPrincipal);
            this.Controls.Add(this.tbNuevoSecundario);
            this.Controls.Add(this.cbAlmacenesPrincipales);
            this.Controls.Add(this.tbNuevoPrincipal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Examen";
            this.Text = "Examen 1ª Evaluación Curso 2019-2020";
            this.Load += new System.EventHandler(this.Examen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNuevoPrincipal;
        private System.Windows.Forms.ComboBox cbAlmacenesPrincipales;
        private System.Windows.Forms.Button btAnyadirPrincipal;
        private System.Windows.Forms.ListBox lbAlmacenesPrincipales;
        private System.Windows.Forms.CheckBox chkOrdenaPrincipales;
        private System.Windows.Forms.Button btDerechaSel;
        private System.Windows.Forms.Button btIzquierdaSel;
        private System.Windows.Forms.Button btDerechaTodos;
        private System.Windows.Forms.Button btIzquierdaTodos;
        private System.Windows.Forms.Button btEliminarPrincipal;
        private System.Windows.Forms.Button btGuardarPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAcercaDe;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNuevoSecundario;
        private System.Windows.Forms.ComboBox cbAlmacenesSecundarios;
        private System.Windows.Forms.Button btAnyadirSecundarios;
        private System.Windows.Forms.Button btEliminarSecundarios;
        private System.Windows.Forms.Button btGuardarSecundarios;
        private System.Windows.Forms.ListBox lbAlmacenesSecundarios;
        private System.Windows.Forms.CheckBox chkOrdenaSecundarios;
    }
}

