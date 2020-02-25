namespace fmDibujo {
    partial class fmDibujo {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmDibujo));
            this.stGrafico = new System.Windows.Forms.StatusStrip();
            this.tsl1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsl2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbDemostracion = new System.Windows.Forms.ToolStripProgressBar();
            this.tsBarraBotones = new System.Windows.Forms.ToolStrip();
            this.tsbLinea = new System.Windows.Forms.ToolStripButton();
            this.tsbCuadrado = new System.Windows.Forms.ToolStripButton();
            this.tsbRectangulo = new System.Windows.Forms.ToolStripButton();
            this.tsbArco = new System.Windows.Forms.ToolStripButton();
            this.tsbCirculo = new System.Windows.Forms.ToolStripButton();
            this.tsbElipse = new System.Windows.Forms.ToolStripButton();
            this.tsbPoligono = new System.Windows.Forms.ToolStripButton();
            this.tsbCurva = new System.Windows.Forms.ToolStripButton();
            this.tsbCurvaCerrada = new System.Windows.Forms.ToolStripButton();
            this.tsbTexto = new System.Windows.Forms.ToolStripButton();
            this.pbEditor = new System.Windows.Forms.PictureBox();
            this.btnPruebaColores = new System.Windows.Forms.Button();
            this.pnColores = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.laPrueba = new System.Windows.Forms.Label();
            this.traAzul = new System.Windows.Forms.TrackBar();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.traVerde = new System.Windows.Forms.TrackBar();
            this.traRojo = new System.Windows.Forms.TrackBar();
            this.ckRelleno = new System.Windows.Forms.CheckBox();
            this.btDemostracion = new System.Windows.Forms.Button();
            this.pbaDemo = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.itAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.itGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.itSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgAbrirDibujo = new System.Windows.Forms.OpenFileDialog();
            this.dlgGuardarDibujo = new System.Windows.Forms.SaveFileDialog();
            this.itAcercade = new System.Windows.Forms.ToolStripMenuItem();
            this.stGrafico.SuspendLayout();
            this.tsBarraBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).BeginInit();
            this.pnColores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traAzul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.traRojo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stGrafico
            // 
            this.stGrafico.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stGrafico.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsl1,
            this.tsl2,
            this.tspbDemostracion});
            this.stGrafico.Location = new System.Drawing.Point(0, 527);
            this.stGrafico.Name = "stGrafico";
            this.stGrafico.Size = new System.Drawing.Size(988, 26);
            this.stGrafico.TabIndex = 0;
            this.stGrafico.Text = "statusStrip1";
            // 
            // tsl1
            // 
            this.tsl1.AutoSize = false;
            this.tsl1.Name = "tsl1";
            this.tsl1.Size = new System.Drawing.Size(120, 20);
            // 
            // tsl2
            // 
            this.tsl2.AutoSize = false;
            this.tsl2.Name = "tsl2";
            this.tsl2.Size = new System.Drawing.Size(120, 20);
            // 
            // tspbDemostracion
            // 
            this.tspbDemostracion.Name = "tspbDemostracion";
            this.tspbDemostracion.Size = new System.Drawing.Size(100, 18);
            this.tspbDemostracion.Step = 5;
            this.tspbDemostracion.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // tsBarraBotones
            // 
            this.tsBarraBotones.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsBarraBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLinea,
            this.tsbCuadrado,
            this.tsbRectangulo,
            this.tsbArco,
            this.tsbCirculo,
            this.tsbElipse,
            this.tsbPoligono,
            this.tsbCurva,
            this.tsbCurvaCerrada,
            this.tsbTexto});
            this.tsBarraBotones.Location = new System.Drawing.Point(0, 30);
            this.tsBarraBotones.Name = "tsBarraBotones";
            this.tsBarraBotones.Size = new System.Drawing.Size(988, 31);
            this.tsBarraBotones.TabIndex = 1;
            this.tsBarraBotones.Text = "toolStrip1";
            // 
            // tsbLinea
            // 
            this.tsbLinea.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLinea.Image = ((System.Drawing.Image)(resources.GetObject("tsbLinea.Image")));
            this.tsbLinea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLinea.Name = "tsbLinea";
            this.tsbLinea.Size = new System.Drawing.Size(35, 28);
            this.tsbLinea.Text = "LIN";
            this.tsbLinea.Click += new System.EventHandler(this.tsbLinea_Click);
            // 
            // tsbCuadrado
            // 
            this.tsbCuadrado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCuadrado.Image = ((System.Drawing.Image)(resources.GetObject("tsbCuadrado.Image")));
            this.tsbCuadrado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCuadrado.Name = "tsbCuadrado";
            this.tsbCuadrado.Size = new System.Drawing.Size(42, 28);
            this.tsbCuadrado.Text = "CUA";
            this.tsbCuadrado.Click += new System.EventHandler(this.tsbCuadrado_Click);
            // 
            // tsbRectangulo
            // 
            this.tsbRectangulo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbRectangulo.Image = ((System.Drawing.Image)(resources.GetObject("tsbRectangulo.Image")));
            this.tsbRectangulo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRectangulo.Name = "tsbRectangulo";
            this.tsbRectangulo.Size = new System.Drawing.Size(39, 28);
            this.tsbRectangulo.Text = "REC";
            this.tsbRectangulo.Click += new System.EventHandler(this.tsbRectangulo_Click);
            // 
            // tsbArco
            // 
            this.tsbArco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbArco.Image = ((System.Drawing.Image)(resources.GetObject("tsbArco.Image")));
            this.tsbArco.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbArco.Name = "tsbArco";
            this.tsbArco.Size = new System.Drawing.Size(41, 28);
            this.tsbArco.Text = "ARC";
            this.tsbArco.Click += new System.EventHandler(this.tsbArco_Click);
            // 
            // tsbCirculo
            // 
            this.tsbCirculo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCirculo.Image = ((System.Drawing.Image)(resources.GetObject("tsbCirculo.Image")));
            this.tsbCirculo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCirculo.Name = "tsbCirculo";
            this.tsbCirculo.Size = new System.Drawing.Size(35, 28);
            this.tsbCirculo.Text = "CIR";
            this.tsbCirculo.Click += new System.EventHandler(this.tsbCirculo_Click);
            // 
            // tsbElipse
            // 
            this.tsbElipse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbElipse.Image = ((System.Drawing.Image)(resources.GetObject("tsbElipse.Image")));
            this.tsbElipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbElipse.Name = "tsbElipse";
            this.tsbElipse.Size = new System.Drawing.Size(40, 28);
            this.tsbElipse.Text = "ELIP";
            this.tsbElipse.Click += new System.EventHandler(this.tsbElipse_Click);
            // 
            // tsbPoligono
            // 
            this.tsbPoligono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPoligono.Image = ((System.Drawing.Image)(resources.GetObject("tsbPoligono.Image")));
            this.tsbPoligono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPoligono.Name = "tsbPoligono";
            this.tsbPoligono.Size = new System.Drawing.Size(39, 28);
            this.tsbPoligono.Text = "POL";
            this.tsbPoligono.Click += new System.EventHandler(this.tsbPoligono_Click);
            // 
            // tsbCurva
            // 
            this.tsbCurva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCurva.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurva.Image")));
            this.tsbCurva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurva.Name = "tsbCurva";
            this.tsbCurva.Size = new System.Drawing.Size(51, 28);
            this.tsbCurva.Text = "CURA";
            this.tsbCurva.Click += new System.EventHandler(this.tsbCurva_Click);
            // 
            // tsbCurvaCerrada
            // 
            this.tsbCurvaCerrada.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCurvaCerrada.Image = ((System.Drawing.Image)(resources.GetObject("tsbCurvaCerrada.Image")));
            this.tsbCurvaCerrada.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCurvaCerrada.Name = "tsbCurvaCerrada";
            this.tsbCurvaCerrada.Size = new System.Drawing.Size(50, 28);
            this.tsbCurvaCerrada.Text = "CURC";
            this.tsbCurvaCerrada.Click += new System.EventHandler(this.tsbCurvaCerrada_Click);
            // 
            // tsbTexto
            // 
            this.tsbTexto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbTexto.Image = ((System.Drawing.Image)(resources.GetObject("tsbTexto.Image")));
            this.tsbTexto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTexto.Name = "tsbTexto";
            this.tsbTexto.Size = new System.Drawing.Size(38, 28);
            this.tsbTexto.Text = "TXT";
            this.tsbTexto.Click += new System.EventHandler(this.tsbTexto_Click);
            // 
            // pbEditor
            // 
            this.pbEditor.BackColor = System.Drawing.Color.White;
            this.pbEditor.Location = new System.Drawing.Point(12, 95);
            this.pbEditor.Name = "pbEditor";
            this.pbEditor.Size = new System.Drawing.Size(697, 362);
            this.pbEditor.TabIndex = 2;
            this.pbEditor.TabStop = false;
            this.pbEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnPruebaColores
            // 
            this.btnPruebaColores.Location = new System.Drawing.Point(762, 62);
            this.btnPruebaColores.Name = "btnPruebaColores";
            this.btnPruebaColores.Size = new System.Drawing.Size(148, 29);
            this.btnPruebaColores.TabIndex = 3;
            this.btnPruebaColores.Text = "Prueba de Colores";
            this.btnPruebaColores.UseVisualStyleBackColor = true;
            this.btnPruebaColores.Click += new System.EventHandler(this.btnPruebaColores_Click);
            // 
            // pnColores
            // 
            this.pnColores.Controls.Add(this.label3);
            this.pnColores.Controls.Add(this.label2);
            this.pnColores.Controls.Add(this.label1);
            this.pnColores.Controls.Add(this.laPrueba);
            this.pnColores.Controls.Add(this.traAzul);
            this.pnColores.Controls.Add(this.btnAplicar);
            this.pnColores.Controls.Add(this.traVerde);
            this.pnColores.Controls.Add(this.traRojo);
            this.pnColores.Enabled = false;
            this.pnColores.Location = new System.Drawing.Point(730, 95);
            this.pnColores.Name = "pnColores";
            this.pnColores.Size = new System.Drawing.Size(200, 362);
            this.pnColores.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Azul";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Verde";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Rojo";
            // 
            // laPrueba
            // 
            this.laPrueba.AutoSize = true;
            this.laPrueba.BackColor = System.Drawing.Color.Black;
            this.laPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPrueba.ForeColor = System.Drawing.SystemColors.ControlText;
            this.laPrueba.Location = new System.Drawing.Point(13, 13);
            this.laPrueba.Name = "laPrueba";
            this.laPrueba.Size = new System.Drawing.Size(175, 25);
            this.laPrueba.TabIndex = 6;
            this.laPrueba.Text = "Prueba de Colores";
            // 
            // traAzul
            // 
            this.traAzul.Location = new System.Drawing.Point(3, 256);
            this.traAzul.Maximum = 255;
            this.traAzul.Name = "traAzul";
            this.traAzul.Size = new System.Drawing.Size(194, 56);
            this.traAzul.TabIndex = 5;
            this.traAzul.Scroll += new System.EventHandler(this.traRojo_Scroll);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(32, 318);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(106, 33);
            this.btnAplicar.TabIndex = 3;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // traVerde
            // 
            this.traVerde.Location = new System.Drawing.Point(3, 169);
            this.traVerde.Maximum = 255;
            this.traVerde.Name = "traVerde";
            this.traVerde.Size = new System.Drawing.Size(194, 56);
            this.traVerde.TabIndex = 5;
            this.traVerde.Scroll += new System.EventHandler(this.traRojo_Scroll);
            // 
            // traRojo
            // 
            this.traRojo.Location = new System.Drawing.Point(3, 77);
            this.traRojo.Maximum = 255;
            this.traRojo.Name = "traRojo";
            this.traRojo.Size = new System.Drawing.Size(194, 56);
            this.traRojo.TabIndex = 1;
            this.traRojo.Scroll += new System.EventHandler(this.traRojo_Scroll);
            // 
            // ckRelleno
            // 
            this.ckRelleno.AutoSize = true;
            this.ckRelleno.Location = new System.Drawing.Point(12, 62);
            this.ckRelleno.Name = "ckRelleno";
            this.ckRelleno.Size = new System.Drawing.Size(107, 21);
            this.ckRelleno.TabIndex = 1;
            this.ckRelleno.Text = "Con Relleno";
            this.ckRelleno.UseVisualStyleBackColor = true;
            // 
            // btDemostracion
            // 
            this.btDemostracion.Location = new System.Drawing.Point(44, 481);
            this.btDemostracion.Name = "btDemostracion";
            this.btDemostracion.Size = new System.Drawing.Size(106, 33);
            this.btDemostracion.TabIndex = 3;
            this.btDemostracion.Text = "Demostracion";
            this.btDemostracion.UseVisualStyleBackColor = true;
            this.btDemostracion.Click += new System.EventHandler(this.btDemostracion_Click);
            // 
            // pbaDemo
            // 
            this.pbaDemo.Location = new System.Drawing.Point(188, 481);
            this.pbaDemo.Name = "pbaDemo";
            this.pbaDemo.Size = new System.Drawing.Size(499, 33);
            this.pbaDemo.Step = 5;
            this.pbaDemo.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbaDemo.TabIndex = 6;
            this.pbaDemo.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(988, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itNuevo,
            this.toolStripMenuItem1,
            this.itAbrir,
            this.itGuardar,
            this.toolStripMenuItem2,
            this.itSalir});
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.nuevoToolStripMenuItem.Text = "Archivo";
            // 
            // itNuevo
            // 
            this.itNuevo.Name = "itNuevo";
            this.itNuevo.Size = new System.Drawing.Size(224, 26);
            this.itNuevo.Text = "Nuevo";
            this.itNuevo.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
            // 
            // itAbrir
            // 
            this.itAbrir.Name = "itAbrir";
            this.itAbrir.Size = new System.Drawing.Size(224, 26);
            this.itAbrir.Text = "Abrir";
            this.itAbrir.Click += new System.EventHandler(this.itAbrir_Click);
            // 
            // itGuardar
            // 
            this.itGuardar.Name = "itGuardar";
            this.itGuardar.Size = new System.Drawing.Size(224, 26);
            this.itGuardar.Text = "Guardar";
            this.itGuardar.Click += new System.EventHandler(this.itGuardar_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(221, 6);
            // 
            // itSalir
            // 
            this.itSalir.Name = "itSalir";
            this.itSalir.Size = new System.Drawing.Size(224, 26);
            this.itSalir.Text = "Salir";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itAcercade});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // dlgAbrirDibujo
            // 
            this.dlgAbrirDibujo.DefaultExt = "bmp";
            this.dlgAbrirDibujo.FileName = "openFileDialog1";
            this.dlgAbrirDibujo.Filter = "Archivo Mapa de Bits (*.bmp)|*.bmp|Archivo JPG(.jpg)|*.jpg|Todos los Archivos (*." +
    "*)|*.*";
            // 
            // itAcercade
            // 
            this.itAcercade.Name = "itAcercade";
            this.itAcercade.Size = new System.Drawing.Size(224, 26);
            this.itAcercade.Text = "Acerca de";
            this.itAcercade.Click += new System.EventHandler(this.itAcercade_Click);
            // 
            // fmDibujo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 553);
            this.Controls.Add(this.pbaDemo);
            this.Controls.Add(this.ckRelleno);
            this.Controls.Add(this.pnColores);
            this.Controls.Add(this.btnPruebaColores);
            this.Controls.Add(this.pbEditor);
            this.Controls.Add(this.tsBarraBotones);
            this.Controls.Add(this.btDemostracion);
            this.Controls.Add(this.stGrafico);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmDibujo";
            this.Load += new System.EventHandler(this.fmDibujo_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fmDibujo_KeyDown);
            this.stGrafico.ResumeLayout(false);
            this.stGrafico.PerformLayout();
            this.tsBarraBotones.ResumeLayout(false);
            this.tsBarraBotones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEditor)).EndInit();
            this.pnColores.ResumeLayout(false);
            this.pnColores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.traAzul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.traRojo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stGrafico;
        private System.Windows.Forms.ToolStrip tsBarraBotones;
        private System.Windows.Forms.PictureBox pbEditor;
        private System.Windows.Forms.Button btnPruebaColores;
        private System.Windows.Forms.Panel pnColores;
        private System.Windows.Forms.CheckBox ckRelleno;
        private System.Windows.Forms.Label laPrueba;
        private System.Windows.Forms.TrackBar traAzul;
        private System.Windows.Forms.TrackBar traVerde;
        private System.Windows.Forms.TrackBar traRojo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAplicar;
        private System.Windows.Forms.ToolStripStatusLabel tsl1;
        private System.Windows.Forms.ToolStripStatusLabel tsl2;
        private System.Windows.Forms.ToolStripButton tsbLinea;
        private System.Windows.Forms.ToolStripButton tsbCuadrado;
        private System.Windows.Forms.ToolStripButton tsbRectangulo;
        private System.Windows.Forms.ToolStripButton tsbArco;
        private System.Windows.Forms.ToolStripButton tsbCirculo;
        private System.Windows.Forms.ToolStripButton tsbElipse;
        private System.Windows.Forms.ToolStripButton tsbPoligono;
        private System.Windows.Forms.ToolStripButton tsbCurva;
        private System.Windows.Forms.ToolStripButton tsbCurvaCerrada;
        private System.Windows.Forms.ToolStripButton tsbTexto;
        private System.Windows.Forms.Button btDemostracion;
        private System.Windows.Forms.ToolStripProgressBar tspbDemostracion;
        private System.Windows.Forms.ProgressBar pbaDemo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itNuevo;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem itAbrir;
        private System.Windows.Forms.ToolStripMenuItem itGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem itSalir;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgAbrirDibujo;
        private System.Windows.Forms.SaveFileDialog dlgGuardarDibujo;
        private System.Windows.Forms.ToolStripMenuItem itAcercade;
    }
}

