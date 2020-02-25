namespace _03Datos {
    partial class fmPrincipal {
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.panel1 = new System.Windows.Forms.Panel();
            this.btAcercade = new System.Windows.Forms.Button();
            this.btPaisesRenta = new System.Windows.Forms.Button();
            this.btCalcula = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btConsulta = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btAnyadir = new System.Windows.Forms.Button();
            this.btMostrar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ckDescendente = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbContinente = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.rbIdentificador = new System.Windows.Forms.RadioButton();
            this.rbPIB = new System.Windows.Forms.RadioButton();
            this.rbCapital = new System.Windows.Forms.RadioButton();
            this.rbPoblacion = new System.Windows.Forms.RadioButton();
            this.lvDatos = new System.Windows.Forms.ListView();
            this.ColID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCapital = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colContinente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPoblacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentaCapita = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btAcercade);
            this.panel1.Controls.Add(this.btPaisesRenta);
            this.panel1.Controls.Add(this.btCalcula);
            this.panel1.Controls.Add(this.btBorrar);
            this.panel1.Controls.Add(this.btConsulta);
            this.panel1.Controls.Add(this.btModificar);
            this.panel1.Controls.Add(this.btAnyadir);
            this.panel1.Controls.Add(this.btMostrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 100);
            this.panel1.TabIndex = 0;
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(839, 46);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(75, 23);
            this.btAcercade.TabIndex = 0;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // btPaisesRenta
            // 
            this.btPaisesRenta.Location = new System.Drawing.Point(657, 12);
            this.btPaisesRenta.Name = "btPaisesRenta";
            this.btPaisesRenta.Size = new System.Drawing.Size(165, 23);
            this.btPaisesRenta.TabIndex = 0;
            this.btPaisesRenta.Text = "Paises por renta";
            this.btPaisesRenta.UseVisualStyleBackColor = true;
            this.btPaisesRenta.Click += new System.EventHandler(this.btPaisesRenta_Click);
            // 
            // btCalcula
            // 
            this.btCalcula.Location = new System.Drawing.Point(491, 46);
            this.btCalcula.Name = "btCalcula";
            this.btCalcula.Size = new System.Drawing.Size(165, 23);
            this.btCalcula.TabIndex = 0;
            this.btCalcula.Text = "Calcula Renta/Capita";
            this.btCalcula.UseVisualStyleBackColor = true;
            this.btCalcula.Click += new System.EventHandler(this.btCalcula_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(360, 46);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 0;
            this.btBorrar.Text = "Borrar";
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(279, 46);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(75, 23);
            this.btConsulta.TabIndex = 0;
            this.btConsulta.Text = "Consulta";
            this.btConsulta.UseVisualStyleBackColor = true;
            this.btConsulta.Click += new System.EventHandler(this.btConsulta_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(198, 46);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 0;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btAnyadir
            // 
            this.btAnyadir.Location = new System.Drawing.Point(117, 46);
            this.btAnyadir.Name = "btAnyadir";
            this.btAnyadir.Size = new System.Drawing.Size(75, 23);
            this.btAnyadir.TabIndex = 0;
            this.btAnyadir.Text = "Añadir";
            this.btAnyadir.UseVisualStyleBackColor = true;
            this.btAnyadir.Click += new System.EventHandler(this.btAnyadir_Click);
            // 
            // btMostrar
            // 
            this.btMostrar.Location = new System.Drawing.Point(36, 46);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(75, 23);
            this.btMostrar.TabIndex = 0;
            this.btMostrar.Text = "Mostrar";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ckDescendente);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rbContinente);
            this.panel2.Controls.Add(this.rbPais);
            this.panel2.Controls.Add(this.rbIdentificador);
            this.panel2.Controls.Add(this.rbPIB);
            this.panel2.Controls.Add(this.rbCapital);
            this.panel2.Controls.Add(this.rbPoblacion);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(955, 75);
            this.panel2.TabIndex = 1;
            // 
            // ckDescendente
            // 
            this.ckDescendente.AutoSize = true;
            this.ckDescendente.Location = new System.Drawing.Point(733, 29);
            this.ckDescendente.Name = "ckDescendente";
            this.ckDescendente.Size = new System.Drawing.Size(114, 21);
            this.ckDescendente.TabIndex = 2;
            this.ckDescendente.Text = "Descendente";
            this.ckDescendente.UseVisualStyleBackColor = true;
            this.ckDescendente.Click += new System.EventHandler(this.rbContinente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ordenar por ..";
            // 
            // rbContinente
            // 
            this.rbContinente.AutoSize = true;
            this.rbContinente.Location = new System.Drawing.Point(184, 42);
            this.rbContinente.Name = "rbContinente";
            this.rbContinente.Size = new System.Drawing.Size(97, 21);
            this.rbContinente.TabIndex = 0;
            this.rbContinente.Text = "Continente";
            this.rbContinente.UseVisualStyleBackColor = true;
            this.rbContinente.Click += new System.EventHandler(this.rbContinente_Click);
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Location = new System.Drawing.Point(184, 16);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(56, 21);
            this.rbPais.TabIndex = 0;
            this.rbPais.Text = "Pais";
            this.rbPais.UseVisualStyleBackColor = true;
            this.rbPais.Click += new System.EventHandler(this.rbContinente_Click);
            // 
            // rbIdentificador
            // 
            this.rbIdentificador.AutoSize = true;
            this.rbIdentificador.Checked = true;
            this.rbIdentificador.Location = new System.Drawing.Point(460, 42);
            this.rbIdentificador.Name = "rbIdentificador";
            this.rbIdentificador.Size = new System.Drawing.Size(106, 21);
            this.rbIdentificador.TabIndex = 0;
            this.rbIdentificador.TabStop = true;
            this.rbIdentificador.Text = "Identificador";
            this.rbIdentificador.UseVisualStyleBackColor = true;
            this.rbIdentificador.Click += new System.EventHandler(this.rbContinente_Click);
            // 
            // rbPIB
            // 
            this.rbPIB.AutoSize = true;
            this.rbPIB.Location = new System.Drawing.Point(325, 42);
            this.rbPIB.Name = "rbPIB";
            this.rbPIB.Size = new System.Drawing.Size(50, 21);
            this.rbPIB.TabIndex = 0;
            this.rbPIB.Text = "PIB";
            this.rbPIB.UseVisualStyleBackColor = true;
            this.rbPIB.Click += new System.EventHandler(this.rbContinente_Click);
            // 
            // rbCapital
            // 
            this.rbCapital.AutoSize = true;
            this.rbCapital.Location = new System.Drawing.Point(460, 16);
            this.rbCapital.Name = "rbCapital";
            this.rbCapital.Size = new System.Drawing.Size(72, 21);
            this.rbCapital.TabIndex = 0;
            this.rbCapital.Text = "Capital";
            this.rbCapital.UseVisualStyleBackColor = true;
            this.rbCapital.Click += new System.EventHandler(this.rbContinente_Click);
            // 
            // rbPoblacion
            // 
            this.rbPoblacion.AutoSize = true;
            this.rbPoblacion.Location = new System.Drawing.Point(325, 16);
            this.rbPoblacion.Name = "rbPoblacion";
            this.rbPoblacion.Size = new System.Drawing.Size(91, 21);
            this.rbPoblacion.TabIndex = 0;
            this.rbPoblacion.Text = "Poblacion";
            this.rbPoblacion.UseVisualStyleBackColor = true;
            this.rbPoblacion.Click += new System.EventHandler(this.rbContinente_Click);
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
            this.lvDatos.Location = new System.Drawing.Point(0, 100);
            this.lvDatos.MultiSelect = false;
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(955, 392);
            this.lvDatos.TabIndex = 0;
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
            // fmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 567);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmPrincipal";
            this.Text = "Datos Paises";
            this.Load += new System.EventHandler(this.fmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvDatos;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.Button btAcercade;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btAnyadir;
        private System.Windows.Forms.ColumnHeader ColID;
        private System.Windows.Forms.ColumnHeader colNombre;
        private System.Windows.Forms.ColumnHeader colCapital;
        private System.Windows.Forms.ColumnHeader colContinente;
        private System.Windows.Forms.ColumnHeader colPoblacion;
        private System.Windows.Forms.ColumnHeader colPIB;
        private System.Windows.Forms.ColumnHeader colRentaCapita;
        private System.Windows.Forms.CheckBox ckDescendente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPoblacion;
        private System.Windows.Forms.RadioButton rbContinente;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.RadioButton rbPIB;
        private System.Windows.Forms.RadioButton rbIdentificador;
        private System.Windows.Forms.RadioButton rbCapital;
        private System.Windows.Forms.Button btCalcula;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btPaisesRenta;
    }
}

