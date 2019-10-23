namespace _03listasymenus {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.cbCursos = new System.Windows.Forms.ComboBox();
            this.lbAlumnos = new System.Windows.Forms.ListBox();
            this.mncListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.btBorrar = new System.Windows.Forms.Button();
            this.laNuevo = new System.Windows.Forms.Label();
            this.tbAlumno = new System.Windows.Forms.TextBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.btInsertar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btOrdenar = new System.Windows.Forms.Button();
            this.btMostrarTodos = new System.Windows.Forms.Button();
            this.btMostrarMas = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.btDown = new System.Windows.Forms.Button();
            this.pnActualiza = new System.Windows.Forms.Panel();
            this.pnHerramientas = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.mnListas = new System.Windows.Forms.MenuStrip();
            this.itArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.itAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.itNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.itAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.itSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itcGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.mncListas.SuspendLayout();
            this.pnActualiza.SuspendLayout();
            this.pnHerramientas.SuspendLayout();
            this.mnListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cursos";
            // 
            // cbCursos
            // 
            this.cbCursos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCursos.FormattingEnabled = true;
            this.cbCursos.Items.AddRange(new object[] {
            "1A",
            "1B",
            "2A",
            "2B",
            "3A",
            "3B",
            "4A",
            "4B"});
            this.cbCursos.Location = new System.Drawing.Point(24, 61);
            this.cbCursos.Name = "cbCursos";
            this.cbCursos.Size = new System.Drawing.Size(121, 21);
            this.cbCursos.TabIndex = 1;
            this.cbCursos.TextChanged += new System.EventHandler(this.cbCursos_TextChanged);
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.ContextMenuStrip = this.mncListas;
            this.lbAlumnos.FormattingEnabled = true;
            this.lbAlumnos.Items.AddRange(new object[] {
            "Luis",
            "Pepe",
            "Ramon",
            "Jose",
            "Paco",
            "Pascual"});
            this.lbAlumnos.Location = new System.Drawing.Point(25, 120);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(120, 212);
            this.lbAlumnos.TabIndex = 2;
            this.lbAlumnos.SelectedIndexChanged += new System.EventHandler(this.lbAlumnos_SelectedIndexChanged);
            // 
            // mncListas
            // 
            this.mncListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNuevo,
            this.abrirToolStripMenuItem,
            this.tsmiEliminar,
            this.toolStripMenuItem1,
            this.itcGuardar});
            this.mncListas.Name = "cms1";
            this.mncListas.Size = new System.Drawing.Size(181, 120);
            this.mncListas.Opening += new System.ComponentModel.CancelEventHandler(this.cms1_Opening);
            // 
            // tsmiNuevo
            // 
            this.tsmiNuevo.AutoSize = false;
            this.tsmiNuevo.Name = "tsmiNuevo";
            this.tsmiNuevo.Size = new System.Drawing.Size(180, 22);
            this.tsmiNuevo.Text = "Nuevo";
            this.tsmiNuevo.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.tsmiNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // tsmiEliminar
            // 
            this.tsmiEliminar.Name = "tsmiEliminar";
            this.tsmiEliminar.Size = new System.Drawing.Size(180, 22);
            this.tsmiEliminar.Text = "Eliminar";
            this.tsmiEliminar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(14, 51);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 3;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // laNuevo
            // 
            this.laNuevo.AutoSize = true;
            this.laNuevo.Enabled = false;
            this.laNuevo.Location = new System.Drawing.Point(26, 372);
            this.laNuevo.Name = "laNuevo";
            this.laNuevo.Size = new System.Drawing.Size(39, 13);
            this.laNuevo.TabIndex = 0;
            this.laNuevo.Text = "Nuevo";
            // 
            // tbAlumno
            // 
            this.tbAlumno.Enabled = false;
            this.tbAlumno.Location = new System.Drawing.Point(24, 388);
            this.tbAlumno.Name = "tbAlumno";
            this.tbAlumno.Size = new System.Drawing.Size(100, 20);
            this.tbAlumno.TabIndex = 4;
            this.tbAlumno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAlumno_KeyPress);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(208, 385);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 23);
            this.btNuevo.TabIndex = 3;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btAnyadir
            // 
            this.btAnyadir.Location = new System.Drawing.Point(14, 13);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(75, 23);
            this.btAnyadir.TabIndex = 3;
            this.btAnyadir.Text = "Añadir";
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(289, 385);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(75, 23);
            this.btAbrir.TabIndex = 3;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // btInsertar
            // 
            this.btInsertar.Location = new System.Drawing.Point(14, 80);
            this.btInsertar.Name = "btInsertar";
            this.btInsertar.Size = new System.Drawing.Size(75, 23);
            this.btInsertar.TabIndex = 3;
            this.btInsertar.Text = "Insertar";
            this.btInsertar.UseVisualStyleBackColor = true;
            this.btInsertar.Click += new System.EventHandler(this.btInsertar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(370, 385);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 3;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(14, 109);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(451, 385);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 3;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Location = new System.Drawing.Point(451, 134);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(75, 23);
            this.btActualizar.TabIndex = 3;
            this.btActualizar.Text = "Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btOrdenar
            // 
            this.btOrdenar.Location = new System.Drawing.Point(451, 95);
            this.btOrdenar.Name = "btOrdenar";
            this.btOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btOrdenar.TabIndex = 3;
            this.btOrdenar.Text = "Ordenar";
            this.btOrdenar.UseVisualStyleBackColor = true;
            this.btOrdenar.Click += new System.EventHandler(this.btOrdenar_Click);
            // 
            // btMostrarTodos
            // 
            this.btMostrarTodos.Location = new System.Drawing.Point(169, 294);
            this.btMostrarTodos.Name = "btMostrarTodos";
            this.btMostrarTodos.Size = new System.Drawing.Size(93, 23);
            this.btMostrarTodos.TabIndex = 3;
            this.btMostrarTodos.Text = "Mostrar Todos";
            this.btMostrarTodos.UseVisualStyleBackColor = true;
            this.btMostrarTodos.Click += new System.EventHandler(this.btMostrarTodos_Click);
            // 
            // btMostrarMas
            // 
            this.btMostrarMas.Location = new System.Drawing.Point(169, 323);
            this.btMostrarMas.Name = "btMostrarMas";
            this.btMostrarMas.Size = new System.Drawing.Size(93, 23);
            this.btMostrarMas.TabIndex = 3;
            this.btMostrarMas.Text = "Mostrar Mas ..";
            this.btMostrarMas.UseVisualStyleBackColor = true;
            this.btMostrarMas.Click += new System.EventHandler(this.btMostrarMas_Click);
            // 
            // btUp
            // 
            this.btUp.BackColor = System.Drawing.SystemColors.Control;
            this.btUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btUp.Image = ((System.Drawing.Image)(resources.GetObject("btUp.Image")));
            this.btUp.Location = new System.Drawing.Point(169, 120);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(39, 59);
            this.btUp.TabIndex = 3;
            this.btUp.UseVisualStyleBackColor = false;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // btDown
            // 
            this.btDown.Image = ((System.Drawing.Image)(resources.GetObject("btDown.Image")));
            this.btDown.Location = new System.Drawing.Point(169, 185);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(39, 58);
            this.btDown.TabIndex = 3;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // pnActualiza
            // 
            this.pnActualiza.BackColor = System.Drawing.SystemColors.Control;
            this.pnActualiza.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnActualiza.Controls.Add(this.btAnyadir);
            this.pnActualiza.Controls.Add(this.btBorrar);
            this.pnActualiza.Controls.Add(this.btInsertar);
            this.pnActualiza.Controls.Add(this.btBuscar);
            this.pnActualiza.Location = new System.Drawing.Point(437, 178);
            this.pnActualiza.Name = "pnActualiza";
            this.pnActualiza.Size = new System.Drawing.Size(102, 161);
            this.pnActualiza.TabIndex = 6;
            this.pnActualiza.Visible = false;
            // 
            // pnHerramientas
            // 
            this.pnHerramientas.Controls.Add(this.mnListas);
            this.pnHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHerramientas.Location = new System.Drawing.Point(0, 0);
            this.pnHerramientas.Name = "pnHerramientas";
            this.pnHerramientas.Size = new System.Drawing.Size(800, 29);
            this.pnHerramientas.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Alumnos";
            // 
            // mnListas
            // 
            this.mnListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itArchivo,
            this.itAyuda});
            this.mnListas.Location = new System.Drawing.Point(0, 0);
            this.mnListas.Name = "mnListas";
            this.mnListas.Size = new System.Drawing.Size(800, 24);
            this.mnListas.TabIndex = 9;
            this.mnListas.Text = "menuStrip1";
            this.mnListas.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // itArchivo
            // 
            this.itArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNuevo,
            this.itAbrir,
            this.itGuardar,
            this.salirToolStripMenuItem1,
            this.itSalir});
            this.itArchivo.Name = "itArchivo";
            this.itArchivo.Size = new System.Drawing.Size(60, 20);
            this.itArchivo.Text = "A&rchivo";
            // 
            // itAyuda
            // 
            this.itAyuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.itAyuda.Name = "itAyuda";
            this.itAyuda.Size = new System.Drawing.Size(53, 20);
            this.itAyuda.Text = "A&yuda";
            // 
            // itNuevo
            // 
            this.itNuevo.Name = "itNuevo";
            this.itNuevo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.itNuevo.Size = new System.Drawing.Size(180, 22);
            this.itNuevo.Text = "Nuevo";
            this.itNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // itAbrir
            // 
            this.itAbrir.Name = "itAbrir";
            this.itAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.itAbrir.Size = new System.Drawing.Size(180, 22);
            this.itAbrir.Text = "Abrir";
            this.itAbrir.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // itGuardar
            // 
            this.itGuardar.Name = "itGuardar";
            this.itGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.itGuardar.Size = new System.Drawing.Size(180, 22);
            this.itGuardar.Text = "Guardar";
            this.itGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // itSalir
            // 
            this.itSalir.Name = "itSalir";
            this.itSalir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.itSalir.Size = new System.Drawing.Size(180, 22);
            this.itSalir.Text = "Salir";
            this.itSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.btAbrir_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // itcGuardar
            // 
            this.itcGuardar.Name = "itcGuardar";
            this.itcGuardar.Size = new System.Drawing.Size(180, 22);
            this.itcGuardar.Text = "Guardar";
            this.itcGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnHerramientas);
            this.Controls.Add(this.pnActualiza);
            this.Controls.Add(this.tbAlumno);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btAbrir);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btMostrarMas);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.btMostrarTodos);
            this.Controls.Add(this.btOrdenar);
            this.Controls.Add(this.btActualizar);
            this.Controls.Add(this.lbAlumnos);
            this.Controls.Add(this.cbCursos);
            this.Controls.Add(this.laNuevo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.mnListas;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mncListas.ResumeLayout(false);
            this.pnActualiza.ResumeLayout(false);
            this.pnHerramientas.ResumeLayout(false);
            this.pnHerramientas.PerformLayout();
            this.mnListas.ResumeLayout(false);
            this.mnListas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCursos;
        private System.Windows.Forms.ListBox lbAlumnos;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Label laNuevo;
        private System.Windows.Forms.TextBox tbAlumno;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Button btInsertar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btOrdenar;
        private System.Windows.Forms.Button btMostrarTodos;
        private System.Windows.Forms.Button btMostrarMas;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.ContextMenuStrip mncListas;
        private System.Windows.Forms.Panel pnActualiza;
        private System.Windows.Forms.Panel pnHerramientas;
        private System.Windows.Forms.ToolStripMenuItem tsmiNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip mnListas;
        private System.Windows.Forms.ToolStripMenuItem itArchivo;
        private System.Windows.Forms.ToolStripMenuItem itNuevo;
        private System.Windows.Forms.ToolStripMenuItem itAbrir;
        private System.Windows.Forms.ToolStripMenuItem itGuardar;
        private System.Windows.Forms.ToolStripMenuItem itAyuda;
        private System.Windows.Forms.ToolStripMenuItem itSalir;
        private System.Windows.Forms.ToolStripSeparator salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itcGuardar;
    }
}

