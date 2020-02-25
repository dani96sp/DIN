namespace _05MiniEditor
{
    partial class fmMiniEditor
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
            this.components = new System.ComponentModel.Container();
            this.pnEstado = new System.Windows.Forms.Panel();
            this.pnEstados = new System.Windows.Forms.Panel();
            this.gbAlineacion = new System.Windows.Forms.GroupBox();
            this.rbDerecha = new System.Windows.Forms.RadioButton();
            this.rbCentrada = new System.Windows.Forms.RadioButton();
            this.rbIzquierda = new System.Windows.Forms.RadioButton();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.gbEstilo = new System.Windows.Forms.GroupBox();
            this.ckTachado = new System.Windows.Forms.CheckBox();
            this.ckCursiva = new System.Windows.Forms.CheckBox();
            this.ckSubrayado = new System.Windows.Forms.CheckBox();
            this.ckNegrita = new System.Windows.Forms.CheckBox();
            this.lbColores = new System.Windows.Forms.ListBox();
            this.cbTamanyo = new System.Windows.Forms.ComboBox();
            this.cbFuente = new System.Windows.Forms.ComboBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btAbrir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.itSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ediciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.itCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.itPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.itVaciarPortapapeles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.itDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.itRehacer = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alineaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itIzquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.itCentrada = new System.Windows.Forms.ToolStripMenuItem();
            this.itDerecha = new System.Windows.Forms.ToolStripMenuItem();
            this.estiloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itNegrita = new System.Windows.Forms.ToolStripMenuItem();
            this.itSubrayado = new System.Windows.Forms.ToolStripMenuItem();
            this.itCursiva = new System.Windows.Forms.ToolStripMenuItem();
            this.itTachado = new System.Windows.Forms.ToolStripMenuItem();
            this.itColores = new System.Windows.Forms.ToolStripMenuItem();
            this.itRojo = new System.Windows.Forms.ToolStripMenuItem();
            this.itVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.itAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.itGris = new System.Windows.Forms.ToolStripMenuItem();
            this.itNaranja = new System.Windows.Forms.ToolStripMenuItem();
            this.itAmarillo = new System.Windows.Forms.ToolStripMenuItem();
            this.itNegro = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbEditor = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.citCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.citCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.citPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.citVaciarPortapapeles = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.citDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.xºx = new System.Windows.Forms.ToolStripMenuItem();
            this.pnEstados.SuspendLayout();
            this.gbAlineacion.SuspendLayout();
            this.gbEstilo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnEstado
            // 
            this.pnEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnEstado.Location = new System.Drawing.Point(0, 512);
            this.pnEstado.Margin = new System.Windows.Forms.Padding(4);
            this.pnEstado.Name = "pnEstado";
            this.pnEstado.Size = new System.Drawing.Size(1067, 42);
            this.pnEstado.TabIndex = 0;
            // 
            // pnEstados
            // 
            this.pnEstados.Controls.Add(this.gbAlineacion);
            this.pnEstados.Controls.Add(this.tbNombre);
            this.pnEstados.Controls.Add(this.gbEstilo);
            this.pnEstados.Controls.Add(this.lbColores);
            this.pnEstados.Controls.Add(this.cbTamanyo);
            this.pnEstados.Controls.Add(this.cbFuente);
            this.pnEstados.Controls.Add(this.btGuardar);
            this.pnEstados.Controls.Add(this.btAbrir);
            this.pnEstados.Controls.Add(this.label3);
            this.pnEstados.Controls.Add(this.label2);
            this.pnEstados.Controls.Add(this.label1);
            this.pnEstados.Controls.Add(this.menuStrip1);
            this.pnEstados.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnEstados.Location = new System.Drawing.Point(0, 0);
            this.pnEstados.Margin = new System.Windows.Forms.Padding(4);
            this.pnEstados.Name = "pnEstados";
            this.pnEstados.Size = new System.Drawing.Size(1067, 316);
            this.pnEstados.TabIndex = 1;
            // 
            // gbAlineacion
            // 
            this.gbAlineacion.Controls.Add(this.rbDerecha);
            this.gbAlineacion.Controls.Add(this.rbCentrada);
            this.gbAlineacion.Controls.Add(this.rbIzquierda);
            this.gbAlineacion.Location = new System.Drawing.Point(721, 80);
            this.gbAlineacion.Margin = new System.Windows.Forms.Padding(4);
            this.gbAlineacion.Name = "gbAlineacion";
            this.gbAlineacion.Padding = new System.Windows.Forms.Padding(4);
            this.gbAlineacion.Size = new System.Drawing.Size(267, 123);
            this.gbAlineacion.TabIndex = 10;
            this.gbAlineacion.TabStop = false;
            this.gbAlineacion.Text = "Alineación";
            // 
            // rbDerecha
            // 
            this.rbDerecha.AutoSize = true;
            this.rbDerecha.Location = new System.Drawing.Point(89, 80);
            this.rbDerecha.Margin = new System.Windows.Forms.Padding(4);
            this.rbDerecha.Name = "rbDerecha";
            this.rbDerecha.Size = new System.Drawing.Size(83, 21);
            this.rbDerecha.TabIndex = 2;
            this.rbDerecha.Text = "Derecha";
            this.rbDerecha.UseVisualStyleBackColor = true;
            this.rbDerecha.CheckedChanged += new System.EventHandler(this.RbIzquierda_CheckedChanged);
            // 
            // rbCentrada
            // 
            this.rbCentrada.AutoSize = true;
            this.rbCentrada.Location = new System.Drawing.Point(89, 52);
            this.rbCentrada.Margin = new System.Windows.Forms.Padding(4);
            this.rbCentrada.Name = "rbCentrada";
            this.rbCentrada.Size = new System.Drawing.Size(87, 21);
            this.rbCentrada.TabIndex = 1;
            this.rbCentrada.Text = "Centrada";
            this.rbCentrada.UseVisualStyleBackColor = true;
            this.rbCentrada.CheckedChanged += new System.EventHandler(this.RbIzquierda_CheckedChanged);
            // 
            // rbIzquierda
            // 
            this.rbIzquierda.AutoSize = true;
            this.rbIzquierda.Checked = true;
            this.rbIzquierda.Location = new System.Drawing.Point(89, 23);
            this.rbIzquierda.Margin = new System.Windows.Forms.Padding(4);
            this.rbIzquierda.Name = "rbIzquierda";
            this.rbIzquierda.Size = new System.Drawing.Size(87, 21);
            this.rbIzquierda.TabIndex = 0;
            this.rbIzquierda.TabStop = true;
            this.rbIzquierda.Text = "Izquierda";
            this.rbIzquierda.UseVisualStyleBackColor = true;
            this.rbIzquierda.CheckedChanged += new System.EventHandler(this.RbIzquierda_CheckedChanged);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(31, 261);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(132, 22);
            this.tbNombre.TabIndex = 9;
            // 
            // gbEstilo
            // 
            this.gbEstilo.Controls.Add(this.ckTachado);
            this.gbEstilo.Controls.Add(this.ckCursiva);
            this.gbEstilo.Controls.Add(this.ckSubrayado);
            this.gbEstilo.Controls.Add(this.ckNegrita);
            this.gbEstilo.Location = new System.Drawing.Point(499, 80);
            this.gbEstilo.Margin = new System.Windows.Forms.Padding(4);
            this.gbEstilo.Name = "gbEstilo";
            this.gbEstilo.Padding = new System.Windows.Forms.Padding(4);
            this.gbEstilo.Size = new System.Drawing.Size(149, 169);
            this.gbEstilo.TabIndex = 8;
            this.gbEstilo.TabStop = false;
            this.gbEstilo.Text = "Estilo";
            // 
            // ckTachado
            // 
            this.ckTachado.AutoSize = true;
            this.ckTachado.Location = new System.Drawing.Point(28, 118);
            this.ckTachado.Margin = new System.Windows.Forms.Padding(4);
            this.ckTachado.Name = "ckTachado";
            this.ckTachado.Size = new System.Drawing.Size(86, 21);
            this.ckTachado.TabIndex = 3;
            this.ckTachado.Text = "Tachado";
            this.ckTachado.UseVisualStyleBackColor = true;
            this.ckTachado.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            // 
            // ckCursiva
            // 
            this.ckCursiva.AutoSize = true;
            this.ckCursiva.Location = new System.Drawing.Point(28, 90);
            this.ckCursiva.Margin = new System.Windows.Forms.Padding(4);
            this.ckCursiva.Name = "ckCursiva";
            this.ckCursiva.Size = new System.Drawing.Size(77, 21);
            this.ckCursiva.TabIndex = 2;
            this.ckCursiva.Text = "Cursiva";
            this.ckCursiva.UseVisualStyleBackColor = true;
            this.ckCursiva.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            // 
            // ckSubrayado
            // 
            this.ckSubrayado.AutoSize = true;
            this.ckSubrayado.Location = new System.Drawing.Point(28, 62);
            this.ckSubrayado.Margin = new System.Windows.Forms.Padding(4);
            this.ckSubrayado.Name = "ckSubrayado";
            this.ckSubrayado.Size = new System.Drawing.Size(99, 21);
            this.ckSubrayado.TabIndex = 1;
            this.ckSubrayado.Text = "Subrayado";
            this.ckSubrayado.UseVisualStyleBackColor = true;
            this.ckSubrayado.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            // 
            // ckNegrita
            // 
            this.ckNegrita.AutoSize = true;
            this.ckNegrita.Location = new System.Drawing.Point(29, 33);
            this.ckNegrita.Margin = new System.Windows.Forms.Padding(4);
            this.ckNegrita.Name = "ckNegrita";
            this.ckNegrita.Size = new System.Drawing.Size(76, 21);
            this.ckNegrita.TabIndex = 0;
            this.ckNegrita.Text = "Negrita";
            this.ckNegrita.UseVisualStyleBackColor = true;
            this.ckNegrita.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            // 
            // lbColores
            // 
            this.lbColores.FormattingEnabled = true;
            this.lbColores.ItemHeight = 16;
            this.lbColores.Items.AddRange(new object[] {
            "Rojo",
            "Verde",
            "Azul",
            "Gris",
            "Naranja",
            "Amarillo",
            "Negro"});
            this.lbColores.Location = new System.Drawing.Point(292, 137);
            this.lbColores.Margin = new System.Windows.Forms.Padding(4);
            this.lbColores.Name = "lbColores";
            this.lbColores.Size = new System.Drawing.Size(119, 148);
            this.lbColores.TabIndex = 7;
            this.lbColores.SelectedIndexChanged += new System.EventHandler(this.LbColores_SelectedIndexChanged);
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
            "18"});
            this.cbTamanyo.Location = new System.Drawing.Point(292, 80);
            this.cbTamanyo.Margin = new System.Windows.Forms.Padding(4);
            this.cbTamanyo.MaxLength = 2;
            this.cbTamanyo.Name = "cbTamanyo";
            this.cbTamanyo.Size = new System.Drawing.Size(56, 24);
            this.cbTamanyo.TabIndex = 6;
            this.cbTamanyo.TextChanged += new System.EventHandler(this.CbTamanyo_TextChanged);
            this.cbTamanyo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbTamanyo_KeyPress);
            // 
            // cbFuente
            // 
            this.cbFuente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFuente.FormattingEnabled = true;
            this.cbFuente.Location = new System.Drawing.Point(31, 80);
            this.cbFuente.Margin = new System.Windows.Forms.Padding(4);
            this.cbFuente.Name = "cbFuente";
            this.cbFuente.Size = new System.Drawing.Size(192, 24);
            this.cbFuente.TabIndex = 5;
            this.cbFuente.TextChanged += new System.EventHandler(this.CbFuente_TextChanged);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(31, 220);
            this.btGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 28);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // btAbrir
            // 
            this.btAbrir.Location = new System.Drawing.Point(31, 185);
            this.btAbrir.Margin = new System.Windows.Forms.Padding(4);
            this.btAbrir.Name = "btAbrir";
            this.btAbrir.Size = new System.Drawing.Size(100, 28);
            this.btAbrir.TabIndex = 3;
            this.btAbrir.Text = "Abrir";
            this.btAbrir.UseVisualStyleBackColor = true;
            this.btAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Color de la Fuente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tamaño";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fuente";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ediciónToolStripMenuItem,
            this.formatoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNuevo,
            this.toolStripMenuItem1,
            this.itAbrir,
            this.itGuardar,
            this.toolStripMenuItem2,
            this.itSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "A&rchivo";
            // 
            // itNuevo
            // 
            this.itNuevo.Name = "itNuevo";
            this.itNuevo.Size = new System.Drawing.Size(145, 26);
            this.itNuevo.Text = "&Nuevo";
            this.itNuevo.Click += new System.EventHandler(this.ItNuevo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 6);
            // 
            // itAbrir
            // 
            this.itAbrir.Name = "itAbrir";
            this.itAbrir.Size = new System.Drawing.Size(145, 26);
            this.itAbrir.Text = "&Abrir";
            this.itAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // itGuardar
            // 
            this.itGuardar.Name = "itGuardar";
            this.itGuardar.Size = new System.Drawing.Size(145, 26);
            this.itGuardar.Text = "&Guardar";
            this.itGuardar.Click += new System.EventHandler(this.BtGuardar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 6);
            // 
            // itSalir
            // 
            this.itSalir.Name = "itSalir";
            this.itSalir.Size = new System.Drawing.Size(145, 26);
            this.itSalir.Text = "Salir";
            this.itSalir.Click += new System.EventHandler(this.ItSalir_Click);
            // 
            // ediciónToolStripMenuItem
            // 
            this.ediciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itCortar,
            this.itCopiar,
            this.itPegar,
            this.toolStripMenuItem3,
            this.itVaciarPortapapeles,
            this.toolStripMenuItem4,
            this.itDeshacer,
            this.itRehacer});
            this.ediciónToolStripMenuItem.Name = "ediciónToolStripMenuItem";
            this.ediciónToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.ediciónToolStripMenuItem.Text = "Edición";
            // 
            // itCortar
            // 
            this.itCortar.Name = "itCortar";
            this.itCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.itCortar.Size = new System.Drawing.Size(222, 26);
            this.itCortar.Text = "Cortar";
            this.itCortar.Click += new System.EventHandler(this.ItCortar_Click);
            // 
            // itCopiar
            // 
            this.itCopiar.Name = "itCopiar";
            this.itCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.itCopiar.Size = new System.Drawing.Size(222, 26);
            this.itCopiar.Text = "Copiar";
            this.itCopiar.Click += new System.EventHandler(this.ItCopiar_Click);
            // 
            // itPegar
            // 
            this.itPegar.Name = "itPegar";
            this.itPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.itPegar.Size = new System.Drawing.Size(222, 26);
            this.itPegar.Text = "Pegar";
            this.itPegar.Click += new System.EventHandler(this.ItPegar_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(219, 6);
            // 
            // itVaciarPortapapeles
            // 
            this.itVaciarPortapapeles.Name = "itVaciarPortapapeles";
            this.itVaciarPortapapeles.Size = new System.Drawing.Size(222, 26);
            this.itVaciarPortapapeles.Text = "Vaciar Portapapeles";
            this.itVaciarPortapapeles.Click += new System.EventHandler(this.ItVaciarPortapapeles_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(219, 6);
            // 
            // itDeshacer
            // 
            this.itDeshacer.Name = "itDeshacer";
            this.itDeshacer.Size = new System.Drawing.Size(222, 26);
            this.itDeshacer.Text = "Deshacer";
            this.itDeshacer.Click += new System.EventHandler(this.ItDeshacer_Click);
            // 
            // itRehacer
            // 
            this.itRehacer.Name = "itRehacer";
            this.itRehacer.Size = new System.Drawing.Size(222, 26);
            this.itRehacer.Text = "Rehacer";
            this.itRehacer.Click += new System.EventHandler(this.ItRehacer_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alineaciónToolStripMenuItem,
            this.estiloToolStripMenuItem,
            this.itColores});
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.formatoToolStripMenuItem.Text = "Formato";
            // 
            // alineaciónToolStripMenuItem
            // 
            this.alineaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itIzquierda,
            this.itCentrada,
            this.itDerecha});
            this.alineaciónToolStripMenuItem.Name = "alineaciónToolStripMenuItem";
            this.alineaciónToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.alineaciónToolStripMenuItem.Text = "&Alineación";
            // 
            // itIzquierda
            // 
            this.itIzquierda.Checked = true;
            this.itIzquierda.CheckState = System.Windows.Forms.CheckState.Checked;
            this.itIzquierda.Name = "itIzquierda";
            this.itIzquierda.Size = new System.Drawing.Size(154, 26);
            this.itIzquierda.Text = "&Izquierda";
            this.itIzquierda.CheckedChanged += new System.EventHandler(this.RbIzquierda_CheckedChanged);
            this.itIzquierda.Click += new System.EventHandler(this.ItIzquierda_Click);
            // 
            // itCentrada
            // 
            this.itCentrada.Name = "itCentrada";
            this.itCentrada.Size = new System.Drawing.Size(154, 26);
            this.itCentrada.Text = "Centrada";
            this.itCentrada.CheckedChanged += new System.EventHandler(this.RbIzquierda_CheckedChanged);
            this.itCentrada.Click += new System.EventHandler(this.ItIzquierda_Click);
            // 
            // itDerecha
            // 
            this.itDerecha.Name = "itDerecha";
            this.itDerecha.Size = new System.Drawing.Size(154, 26);
            this.itDerecha.Text = "Derecha";
            this.itDerecha.CheckedChanged += new System.EventHandler(this.RbIzquierda_CheckedChanged);
            this.itDerecha.Click += new System.EventHandler(this.ItIzquierda_Click);
            // 
            // estiloToolStripMenuItem
            // 
            this.estiloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNegrita,
            this.itSubrayado,
            this.itCursiva,
            this.itTachado});
            this.estiloToolStripMenuItem.Name = "estiloToolStripMenuItem";
            this.estiloToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.estiloToolStripMenuItem.Text = "Estilo";
            // 
            // itNegrita
            // 
            this.itNegrita.Name = "itNegrita";
            this.itNegrita.Size = new System.Drawing.Size(163, 26);
            this.itNegrita.Text = "Negrita";
            this.itNegrita.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            this.itNegrita.Click += new System.EventHandler(this.ItNegrita_Click);
            // 
            // itSubrayado
            // 
            this.itSubrayado.Name = "itSubrayado";
            this.itSubrayado.Size = new System.Drawing.Size(163, 26);
            this.itSubrayado.Text = "Subrayado";
            this.itSubrayado.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            this.itSubrayado.Click += new System.EventHandler(this.ItNegrita_Click);
            // 
            // itCursiva
            // 
            this.itCursiva.Name = "itCursiva";
            this.itCursiva.Size = new System.Drawing.Size(163, 26);
            this.itCursiva.Text = "Cursiva";
            this.itCursiva.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            this.itCursiva.Click += new System.EventHandler(this.ItNegrita_Click);
            // 
            // itTachado
            // 
            this.itTachado.Name = "itTachado";
            this.itTachado.Size = new System.Drawing.Size(163, 26);
            this.itTachado.Text = "Tachado";
            this.itTachado.CheckedChanged += new System.EventHandler(this.CkNegrita_CheckedChanged);
            this.itTachado.Click += new System.EventHandler(this.ItNegrita_Click);
            // 
            // itColores
            // 
            this.itColores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itRojo,
            this.itVerde,
            this.itAzul,
            this.itGris,
            this.itNaranja,
            this.itAmarillo,
            this.itNegro});
            this.itColores.Name = "itColores";
            this.itColores.Size = new System.Drawing.Size(162, 26);
            this.itColores.Text = "Colores";
            // 
            // itRojo
            // 
            this.itRojo.Name = "itRojo";
            this.itRojo.Size = new System.Drawing.Size(149, 26);
            this.itRojo.Text = "Rojo";
            this.itRojo.Click += new System.EventHandler(this.LbColores_SelectedIndexChanged);
            // 
            // itVerde
            // 
            this.itVerde.Name = "itVerde";
            this.itVerde.Size = new System.Drawing.Size(149, 26);
            this.itVerde.Text = "Verde";
            this.itVerde.Click += new System.EventHandler(this.LbColores_SelectedIndexChanged);
            // 
            // itAzul
            // 
            this.itAzul.Name = "itAzul";
            this.itAzul.Size = new System.Drawing.Size(149, 26);
            this.itAzul.Text = "Azul";
            this.itAzul.Click += new System.EventHandler(this.LbColores_SelectedIndexChanged);
            // 
            // itGris
            // 
            this.itGris.Name = "itGris";
            this.itGris.Size = new System.Drawing.Size(149, 26);
            this.itGris.Text = "Gris";
            this.itGris.Click += new System.EventHandler(this.LbColores_SelectedIndexChanged);
            // 
            // itNaranja
            // 
            this.itNaranja.Name = "itNaranja";
            this.itNaranja.Size = new System.Drawing.Size(149, 26);
            this.itNaranja.Text = "Naranja";
            this.itNaranja.Click += new System.EventHandler(this.LbColores_SelectedIndexChanged);
            // 
            // itAmarillo
            // 
            this.itAmarillo.Name = "itAmarillo";
            this.itAmarillo.Size = new System.Drawing.Size(149, 26);
            this.itAmarillo.Text = "Amarillo";
            this.itAmarillo.Click += new System.EventHandler(this.LbColores_SelectedIndexChanged);
            // 
            // itNegro
            // 
            this.itNegro.Name = "itNegro";
            this.itNegro.Size = new System.Drawing.Size(149, 26);
            this.itNegro.Text = "Negro";
            this.itNegro.Click += new System.EventHandler(this.LbColores_SelectedIndexChanged);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // rtbEditor
            // 
            this.rtbEditor.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbEditor.Location = new System.Drawing.Point(0, 316);
            this.rtbEditor.Margin = new System.Windows.Forms.Padding(4);
            this.rtbEditor.Name = "rtbEditor";
            this.rtbEditor.Size = new System.Drawing.Size(1067, 196);
            this.rtbEditor.TabIndex = 2;
            this.rtbEditor.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citCortar,
            this.citCopiar,
            this.citPegar,
            this.toolStripSeparator1,
            this.citVaciarPortapapeles,
            this.toolStripSeparator2,
            this.citDeshacer,
            this.xºx});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(209, 160);
            // 
            // citCortar
            // 
            this.citCortar.Name = "citCortar";
            this.citCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.citCortar.Size = new System.Drawing.Size(208, 24);
            this.citCortar.Text = "Cortar";
            this.citCortar.Click += new System.EventHandler(this.ItCortar_Click);
            // 
            // citCopiar
            // 
            this.citCopiar.Name = "citCopiar";
            this.citCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.citCopiar.Size = new System.Drawing.Size(208, 24);
            this.citCopiar.Text = "Copiar";
            this.citCopiar.Click += new System.EventHandler(this.ItCopiar_Click);
            // 
            // citPegar
            // 
            this.citPegar.Name = "citPegar";
            this.citPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.citPegar.Size = new System.Drawing.Size(208, 24);
            this.citPegar.Text = "Pegar";
            this.citPegar.Click += new System.EventHandler(this.ItPegar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // citVaciarPortapapeles
            // 
            this.citVaciarPortapapeles.Name = "citVaciarPortapapeles";
            this.citVaciarPortapapeles.Size = new System.Drawing.Size(208, 24);
            this.citVaciarPortapapeles.Text = "Vaciar Portapapeles";
            this.citVaciarPortapapeles.Click += new System.EventHandler(this.ItVaciarPortapapeles_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // citDeshacer
            // 
            this.citDeshacer.Name = "citDeshacer";
            this.citDeshacer.Size = new System.Drawing.Size(208, 24);
            this.citDeshacer.Text = "Deshacer";
            this.citDeshacer.Click += new System.EventHandler(this.ItDeshacer_Click);
            // 
            // xºx
            // 
            this.xºx.Name = "xºx";
            this.xºx.Size = new System.Drawing.Size(208, 24);
            this.xºx.Text = "Rehacer";
            this.xºx.Click += new System.EventHandler(this.ItRehacer_Click);
            // 
            // fmMiniEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rtbEditor);
            this.Controls.Add(this.pnEstados);
            this.Controls.Add(this.pnEstado);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmMiniEditor";
            this.Text = "Editor de Textos";
            this.Load += new System.EventHandler(this.FmMiniEditor_Load);
            this.pnEstados.ResumeLayout(false);
            this.pnEstados.PerformLayout();
            this.gbAlineacion.ResumeLayout(false);
            this.gbAlineacion.PerformLayout();
            this.gbEstilo.ResumeLayout(false);
            this.gbEstilo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnEstado;
        private System.Windows.Forms.Panel pnEstados;
        private System.Windows.Forms.GroupBox gbAlineacion;
        private System.Windows.Forms.RadioButton rbDerecha;
        private System.Windows.Forms.RadioButton rbCentrada;
        private System.Windows.Forms.RadioButton rbIzquierda;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.GroupBox gbEstilo;
        private System.Windows.Forms.CheckBox ckTachado;
        private System.Windows.Forms.CheckBox ckCursiva;
        private System.Windows.Forms.CheckBox ckSubrayado;
        private System.Windows.Forms.CheckBox ckNegrita;
        private System.Windows.Forms.ListBox lbColores;
        private System.Windows.Forms.ComboBox cbTamanyo;
        private System.Windows.Forms.ComboBox cbFuente;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btAbrir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbEditor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itAbrir;
        private System.Windows.Forms.ToolStripMenuItem itGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itSalir;
        private System.Windows.Forms.ToolStripMenuItem ediciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itCortar;
        private System.Windows.Forms.ToolStripMenuItem itCopiar;
        private System.Windows.Forms.ToolStripMenuItem itPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem itVaciarPortapapeles;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem itDeshacer;
        private System.Windows.Forms.ToolStripMenuItem itRehacer;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alineaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itIzquierda;
        private System.Windows.Forms.ToolStripMenuItem itCentrada;
        private System.Windows.Forms.ToolStripMenuItem itDerecha;
        private System.Windows.Forms.ToolStripMenuItem estiloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itNegrita;
        private System.Windows.Forms.ToolStripMenuItem itSubrayado;
        private System.Windows.Forms.ToolStripMenuItem itCursiva;
        private System.Windows.Forms.ToolStripMenuItem itTachado;
        private System.Windows.Forms.ToolStripMenuItem itColores;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itRojo;
        private System.Windows.Forms.ToolStripMenuItem itVerde;
        private System.Windows.Forms.ToolStripMenuItem itAzul;
        private System.Windows.Forms.ToolStripMenuItem itGris;
        private System.Windows.Forms.ToolStripMenuItem itNaranja;
        private System.Windows.Forms.ToolStripMenuItem itAmarillo;
        private System.Windows.Forms.ToolStripMenuItem itNegro;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem citCortar;
        private System.Windows.Forms.ToolStripMenuItem citCopiar;
        private System.Windows.Forms.ToolStripMenuItem citPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem citVaciarPortapapeles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem citDeshacer;
        private System.Windows.Forms.ToolStripMenuItem xºx;
    }
}

