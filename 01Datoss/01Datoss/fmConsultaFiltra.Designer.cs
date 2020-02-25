namespace _01Datoss {
    partial class fmConsultaFiltra {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmConsultaFiltra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckFiltrarLetra = new System.Windows.Forms.CheckBox();
            this.ckFiltrarProvincia = new System.Windows.Forms.CheckBox();
            this.btBuscarNombre = new System.Windows.Forms.Button();
            this.cbLetras = new System.Windows.Forms.ComboBox();
            this.cbProvincias = new System.Windows.Forms.ComboBox();
            this.tbBuscar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckAscendente = new System.Windows.Forms.CheckBox();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.bd_telefonosDataSet = new _01Datoss.bd_telefonosDataSet();
            this.teléfonosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teléfonosTableAdapter = new _01Datoss.bd_telefonosDataSetTableAdapters.teléfonosTableAdapter();
            this.tableAdapterManager = new _01Datoss.bd_telefonosDataSetTableAdapters.TableAdapterManager();
            this.teléfonosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.teléfonosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teléfonosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teléfonosBindingNavigator)).BeginInit();
            this.teléfonosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teléfonosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ckFiltrarLetra);
            this.panel1.Controls.Add(this.ckFiltrarProvincia);
            this.panel1.Controls.Add(this.btBuscarNombre);
            this.panel1.Controls.Add(this.cbLetras);
            this.panel1.Controls.Add(this.cbProvincias);
            this.panel1.Controls.Add(this.tbBuscar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbCodigo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 441);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 199);
            this.panel1.TabIndex = 0;
            // 
            // ckFiltrarLetra
            // 
            this.ckFiltrarLetra.AutoSize = true;
            this.ckFiltrarLetra.Location = new System.Drawing.Point(789, 107);
            this.ckFiltrarLetra.Name = "ckFiltrarLetra";
            this.ckFiltrarLetra.Size = new System.Drawing.Size(225, 21);
            this.ckFiltrarLetra.TabIndex = 1;
            this.ckFiltrarLetra.Text = "Filtrar Nombres empiezan por..";
            this.ckFiltrarLetra.UseVisualStyleBackColor = true;
            this.ckFiltrarLetra.CheckedChanged += new System.EventHandler(this.ckFiltrarLetra_CheckedChanged);
            // 
            // ckFiltrarProvincia
            // 
            this.ckFiltrarProvincia.AutoSize = true;
            this.ckFiltrarProvincia.Location = new System.Drawing.Point(633, 109);
            this.ckFiltrarProvincia.Name = "ckFiltrarProvincia";
            this.ckFiltrarProvincia.Size = new System.Drawing.Size(66, 21);
            this.ckFiltrarProvincia.TabIndex = 1;
            this.ckFiltrarProvincia.Text = "Filtrar";
            this.ckFiltrarProvincia.UseVisualStyleBackColor = true;
            this.ckFiltrarProvincia.CheckedChanged += new System.EventHandler(this.ckFiltrarProvincia_CheckedChanged);
            // 
            // btBuscarNombre
            // 
            this.btBuscarNombre.Location = new System.Drawing.Point(503, 107);
            this.btBuscarNombre.Name = "btBuscarNombre";
            this.btBuscarNombre.Size = new System.Drawing.Size(75, 23);
            this.btBuscarNombre.TabIndex = 5;
            this.btBuscarNombre.Text = "Buscar";
            this.btBuscarNombre.UseVisualStyleBackColor = true;
            this.btBuscarNombre.Click += new System.EventHandler(this.btBuscarNombre_Click);
            // 
            // cbLetras
            // 
            this.cbLetras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLetras.FormattingEnabled = true;
            this.cbLetras.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cbLetras.Location = new System.Drawing.Point(789, 77);
            this.cbLetras.Name = "cbLetras";
            this.cbLetras.Size = new System.Drawing.Size(121, 24);
            this.cbLetras.TabIndex = 4;
            this.cbLetras.SelectedIndexChanged += new System.EventHandler(this.ckFiltrarLetra_CheckedChanged);
            // 
            // cbProvincias
            // 
            this.cbProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProvincias.FormattingEnabled = true;
            this.cbProvincias.Items.AddRange(new object[] {
            "A Coruña",
            "Álava",
            "Albacete",
            "Alicante",
            "Almería",
            "Asturias",
            "Ávila",
            "Badajoz",
            "Baleares",
            "Barcelona",
            "Burgos",
            "Cáceres",
            "Cádiz",
            "Cantabria",
            "Castellón",
            "Ciudad Real",
            "Córdoba",
            "Cuenca",
            "Girona",
            "Granada",
            "Guadalajara",
            "Gipuzkoa",
            "Huelva",
            "Huesca",
            "Jaén",
            "La Rioja",
            "Las Palmas",
            "León",
            "Lérida",
            "Lugo",
            "Madrid",
            "Málaga",
            "Murcia",
            "Navarra",
            "Ourense",
            "Palencia",
            "Pontevedra",
            "Salamanca",
            "Segovia",
            "Sevilla",
            "Soria",
            "Tarragona",
            "Santa Cruz de Tenerife",
            "Teruel",
            "Toledo",
            "Valencia",
            "Valladolid",
            "Vizcaya",
            "Zamora",
            "Zaragoza"});
            this.cbProvincias.Location = new System.Drawing.Point(617, 77);
            this.cbProvincias.Name = "cbProvincias";
            this.cbProvincias.Size = new System.Drawing.Size(121, 24);
            this.cbProvincias.TabIndex = 4;
            this.cbProvincias.SelectedIndexChanged += new System.EventHandler(this.ckFiltrarProvincia_CheckedChanged);
            // 
            // tbBuscar
            // 
            this.tbBuscar.Location = new System.Drawing.Point(374, 105);
            this.tbBuscar.Name = "tbBuscar";
            this.tbBuscar.Size = new System.Drawing.Size(123, 22);
            this.tbBuscar.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(793, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Letras";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provincia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(380, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Busca Nombre";
            // 
            // tbCodigo
            // 
            this.tbCodigo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.teléfonosBindingSource, "Id", true));
            this.tbCodigo.Location = new System.Drawing.Point(424, 25);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.ReadOnly = true;
            this.tbCodigo.Size = new System.Drawing.Size(123, 22);
            this.tbCodigo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Seleccionado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckAscendente);
            this.groupBox1.Controls.Add(this.rbCodigo);
            this.groupBox1.Controls.Add(this.rbNombre);
            this.groupBox1.Location = new System.Drawing.Point(49, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 146);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordenar por";
            // 
            // ckAscendente
            // 
            this.ckAscendente.AutoSize = true;
            this.ckAscendente.Checked = true;
            this.ckAscendente.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckAscendente.Location = new System.Drawing.Point(45, 82);
            this.ckAscendente.Name = "ckAscendente";
            this.ckAscendente.Size = new System.Drawing.Size(105, 21);
            this.ckAscendente.TabIndex = 1;
            this.ckAscendente.Text = "Ascendente";
            this.ckAscendente.UseVisualStyleBackColor = true;
            this.ckAscendente.CheckedChanged += new System.EventHandler(this.ckAscendente_CheckedChanged);
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Location = new System.Drawing.Point(33, 55);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(90, 21);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo ID";
            this.rbCodigo.UseVisualStyleBackColor = true;
            this.rbCodigo.CheckedChanged += new System.EventHandler(this.ckAscendente_CheckedChanged);
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(33, 28);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(79, 21);
            this.rbNombre.TabIndex = 0;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            this.rbNombre.CheckedChanged += new System.EventHandler(this.ckAscendente_CheckedChanged);
            // 
            // bd_telefonosDataSet
            // 
            this.bd_telefonosDataSet.DataSetName = "bd_telefonosDataSet";
            this.bd_telefonosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teléfonosBindingSource
            // 
            this.teléfonosBindingSource.DataMember = "teléfonos";
            this.teléfonosBindingSource.DataSource = this.bd_telefonosDataSet;
            // 
            // teléfonosTableAdapter
            // 
            this.teléfonosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.teléfonosTableAdapter = this.teléfonosTableAdapter;
            this.tableAdapterManager.UpdateOrder = _01Datoss.bd_telefonosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // teléfonosBindingNavigator
            // 
            this.teléfonosBindingNavigator.AddNewItem = null;
            this.teléfonosBindingNavigator.BindingSource = this.teléfonosBindingSource;
            this.teléfonosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.teléfonosBindingNavigator.DeleteItem = null;
            this.teléfonosBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.teléfonosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.teléfonosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.teléfonosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.teléfonosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.teléfonosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.teléfonosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.teléfonosBindingNavigator.Name = "teléfonosBindingNavigator";
            this.teléfonosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.teléfonosBindingNavigator.Size = new System.Drawing.Size(1042, 27);
            this.teléfonosBindingNavigator.TabIndex = 1;
            this.teléfonosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 24);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // teléfonosDataGridView
            // 
            this.teléfonosDataGridView.AllowUserToAddRows = false;
            this.teléfonosDataGridView.AutoGenerateColumns = false;
            this.teléfonosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teléfonosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.teléfonosDataGridView.DataSource = this.teléfonosBindingSource;
            this.teléfonosDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teléfonosDataGridView.Location = new System.Drawing.Point(0, 27);
            this.teléfonosDataGridView.Name = "teléfonosDataGridView";
            this.teléfonosDataGridView.RowHeadersWidth = 51;
            this.teléfonosDataGridView.RowTemplate.Height = 24;
            this.teléfonosDataGridView.Size = new System.Drawing.Size(1042, 414);
            this.teléfonosDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Direccion";
            this.dataGridViewTextBoxColumn3.HeaderText = "Direccion";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "Telefono";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Observaciones";
            this.dataGridViewTextBoxColumn5.HeaderText = "Observaciones";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Ciudad";
            this.dataGridViewTextBoxColumn6.HeaderText = "Ciudad";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Provincia";
            this.dataGridViewTextBoxColumn7.HeaderText = "Provincia";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Pais";
            this.dataGridViewTextBoxColumn8.HeaderText = "Pais";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // fmConsultaFiltra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 640);
            this.Controls.Add(this.teléfonosDataGridView);
            this.Controls.Add(this.teléfonosBindingNavigator);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsultaFiltra";
            this.Text = "Consultas y Filtros";
            this.Load += new System.EventHandler(this.fmConsultaFiltra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bd_telefonosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teléfonosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teléfonosBindingNavigator)).EndInit();
            this.teléfonosBindingNavigator.ResumeLayout(false);
            this.teléfonosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teléfonosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private bd_telefonosDataSet bd_telefonosDataSet;
        private System.Windows.Forms.BindingSource teléfonosBindingSource;
        private bd_telefonosDataSetTableAdapters.teléfonosTableAdapter teléfonosTableAdapter;
        private bd_telefonosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator teléfonosBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.DataGridView teléfonosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckAscendente;
        private System.Windows.Forms.Button btBuscarNombre;
        private System.Windows.Forms.ComboBox cbLetras;
        private System.Windows.Forms.ComboBox cbProvincias;
        private System.Windows.Forms.TextBox tbBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckFiltrarProvincia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckFiltrarLetra;
        private System.Windows.Forms.Label label4;
    }
}