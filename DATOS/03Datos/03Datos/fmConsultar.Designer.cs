namespace _03Datos {
    partial class fmConsultar {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbConsultaPorPais = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btVer = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.gbContinentes = new System.Windows.Forms.GroupBox();
            this.ckOceania = new System.Windows.Forms.CheckBox();
            this.ckAfrica = new System.Windows.Forms.CheckBox();
            this.ckAsia = new System.Windows.Forms.CheckBox();
            this.ckEuropa = new System.Windows.Forms.CheckBox();
            this.ckAmerica = new System.Windows.Forms.CheckBox();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContinente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentaCapita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbContinentes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbConsultaPorPais);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btVer);
            this.panel1.Controls.Add(this.btConsulta);
            this.panel1.Controls.Add(this.gbContinentes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 208);
            this.panel1.TabIndex = 0;
            // 
            // tbConsultaPorPais
            // 
            this.tbConsultaPorPais.Location = new System.Drawing.Point(483, 42);
            this.tbConsultaPorPais.Name = "tbConsultaPorPais";
            this.tbConsultaPorPais.Size = new System.Drawing.Size(138, 22);
            this.tbConsultaPorPais.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(465, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Consulta por País";
            // 
            // btVer
            // 
            this.btVer.Location = new System.Drawing.Point(511, 70);
            this.btVer.Name = "btVer";
            this.btVer.Size = new System.Drawing.Size(75, 23);
            this.btVer.TabIndex = 1;
            this.btVer.Text = "Ver";
            this.btVer.UseVisualStyleBackColor = true;
            this.btVer.Click += new System.EventHandler(this.btVer_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(260, 102);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(75, 23);
            this.btConsulta.TabIndex = 1;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // gbContinentes
            // 
            this.gbContinentes.Controls.Add(this.ckOceania);
            this.gbContinentes.Controls.Add(this.ckAfrica);
            this.gbContinentes.Controls.Add(this.ckAsia);
            this.gbContinentes.Controls.Add(this.ckEuropa);
            this.gbContinentes.Controls.Add(this.ckAmerica);
            this.gbContinentes.Location = new System.Drawing.Point(54, 16);
            this.gbContinentes.Name = "gbContinentes";
            this.gbContinentes.Size = new System.Drawing.Size(200, 171);
            this.gbContinentes.TabIndex = 0;
            this.gbContinentes.TabStop = false;
            this.gbContinentes.Text = "Consulta por Continente";
            // 
            // ckOceania
            // 
            this.ckOceania.AutoSize = true;
            this.ckOceania.Location = new System.Drawing.Point(21, 142);
            this.ckOceania.Name = "ckOceania";
            this.ckOceania.Size = new System.Drawing.Size(83, 21);
            this.ckOceania.TabIndex = 0;
            this.ckOceania.Text = "Oceanía";
            this.ckOceania.UseVisualStyleBackColor = true;
            // 
            // ckAfrica
            // 
            this.ckAfrica.AutoSize = true;
            this.ckAfrica.Location = new System.Drawing.Point(21, 115);
            this.ckAfrica.Name = "ckAfrica";
            this.ckAfrica.Size = new System.Drawing.Size(66, 21);
            this.ckAfrica.TabIndex = 0;
            this.ckAfrica.Text = "África";
            this.ckAfrica.UseVisualStyleBackColor = true;
            // 
            // ckAsia
            // 
            this.ckAsia.AutoSize = true;
            this.ckAsia.Location = new System.Drawing.Point(21, 88);
            this.ckAsia.Name = "ckAsia";
            this.ckAsia.Size = new System.Drawing.Size(57, 21);
            this.ckAsia.TabIndex = 0;
            this.ckAsia.Text = "Asia";
            this.ckAsia.UseVisualStyleBackColor = true;
            // 
            // ckEuropa
            // 
            this.ckEuropa.AutoSize = true;
            this.ckEuropa.Location = new System.Drawing.Point(21, 61);
            this.ckEuropa.Name = "ckEuropa";
            this.ckEuropa.Size = new System.Drawing.Size(76, 21);
            this.ckEuropa.TabIndex = 0;
            this.ckEuropa.Text = "Europa";
            this.ckEuropa.UseVisualStyleBackColor = true;
            // 
            // ckAmerica
            // 
            this.ckAmerica.AutoSize = true;
            this.ckAmerica.Location = new System.Drawing.Point(21, 33);
            this.ckAmerica.Name = "ckAmerica";
            this.ckAmerica.Size = new System.Drawing.Size(81, 21);
            this.ckAmerica.TabIndex = 0;
            this.ckAmerica.Text = "América";
            this.ckAmerica.UseVisualStyleBackColor = true;
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColID,
            this.colNombre,
            this.colCapital,
            this.colContinente,
            this.colPoblacion,
            this.colPIB,
            this.colRentaCapita});
            this.lvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDatos.FullRowSelect = true;
            this.lvDatos.HideSelection = false;
            this.lvDatos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvDatos.Location = new System.Drawing.Point(0, 208);
            this.lvDatos.MultiSelect = false;
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(861, 264);
            this.lvDatos.TabIndex = 1;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            // 
            // ColID
            // 
            this.ColID.Text = "ID";
            // 
            // colNombre
            // 
            this.colNombre.Text = "Nombre";
            this.colNombre.Width = 79;
            // 
            // colCapital
            // 
            this.colCapital.Text = "Capital";
            this.colCapital.Width = 85;
            // 
            // colContinente
            // 
            this.colContinente.Text = "Continente";
            this.colContinente.Width = 119;
            // 
            // colPoblacion
            // 
            this.colPoblacion.Text = "Población";
            this.colPoblacion.Width = 100;
            // 
            // colPIB
            // 
            this.colPIB.Text = "PIB";
            this.colPIB.Width = 74;
            // 
            // colRentaCapita
            // 
            this.colRentaCapita.Text = "Renta/Capita";
            this.colRentaCapita.Width = 105;
            // 
            // fmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 472);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.panel1);
            this.Name = "fmConsultar";
            this.Text = "fmConsultar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbContinentes.ResumeLayout(false);
            this.gbContinentes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbConsultaPorPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.GroupBox gbContinentes;
        private System.Windows.Forms.CheckBox ckAmerica;
        private System.Windows.Forms.Button btVer;
        private System.Windows.Forms.CheckBox ckOceania;
        private System.Windows.Forms.CheckBox ckAfrica;
        private System.Windows.Forms.CheckBox ckAsia;
        private System.Windows.Forms.CheckBox ckEuropa;
        private System.Windows.Forms.ListView lvDatos;
        private System.Windows.Forms.ColumnHeader ColID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colCapital;
        private System.Windows.Forms.ColumnHeader colContinente;
        private System.Windows.Forms.ColumnHeader colPoblacion;
        private System.Windows.Forms.ColumnHeader colPIB;
        private System.Windows.Forms.ColumnHeader colRentaCapita;
    }
}