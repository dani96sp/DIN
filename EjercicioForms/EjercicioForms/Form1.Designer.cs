namespace EjercicioForms
{
    partial class fmElformulario
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
        private void InitializeComponent()
        {
            this.laPrincipal = new System.Windows.Forms.Label();
            this.laMover = new System.Windows.Forms.Label();
            this.btDerecha = new System.Windows.Forms.Button();
            this.btArriba = new System.Windows.Forms.Button();
            this.laPrincipalSize = new System.Windows.Forms.Label();
            this.btAbajo = new System.Windows.Forms.Button();
            this.btIzquierda = new System.Windows.Forms.Button();
            this.pnBotones = new System.Windows.Forms.Panel();
            this.btDetras = new System.Windows.Forms.Button();
            this.btDelante = new System.Windows.Forms.Button();
            this.btDisminuye = new System.Windows.Forms.Button();
            this.btAumenta = new System.Windows.Forms.Button();
            this.btVisible = new System.Windows.Forms.Button();
            this.btController = new System.Windows.Forms.Button();
            this.btPanel = new System.Windows.Forms.Button();
            this.btAcercade = new System.Windows.Forms.Button();
            this.btUno = new System.Windows.Forms.Button();
            this.btDos = new System.Windows.Forms.Button();
            this.btTres = new System.Windows.Forms.Button();
            this.laPruebaSender = new System.Windows.Forms.Label();
            this.pnBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // laPrincipal
            // 
            this.laPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.laPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.laPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPrincipal.ForeColor = System.Drawing.Color.RoyalBlue;
            this.laPrincipal.Location = new System.Drawing.Point(0, 0);
            this.laPrincipal.Name = "laPrincipal";
            this.laPrincipal.Size = new System.Drawing.Size(800, 30);
            this.laPrincipal.TabIndex = 0;
            this.laPrincipal.Text = "Bienvenido a la Aplicación";
            this.laPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laMover
            // 
            this.laMover.AutoSize = true;
            this.laMover.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.laMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laMover.Location = new System.Drawing.Point(658, 41);
            this.laMover.Name = "laMover";
            this.laMover.Size = new System.Drawing.Size(130, 24);
            this.laMover.TabIndex = 1;
            this.laMover.Text = "XXXXXXXX";
            this.laMover.Click += new System.EventHandler(this.laMover_Click);
            // 
            // btDerecha
            // 
            this.btDerecha.Location = new System.Drawing.Point(193, 88);
            this.btDerecha.Name = "btDerecha";
            this.btDerecha.Size = new System.Drawing.Size(75, 32);
            this.btDerecha.TabIndex = 3;
            this.btDerecha.Text = "Derecha";
            this.btDerecha.UseVisualStyleBackColor = true;
            this.btDerecha.Click += new System.EventHandler(this.btDerecha_Click);
            // 
            // btArriba
            // 
            this.btArriba.Location = new System.Drawing.Point(123, 41);
            this.btArriba.Name = "btArriba";
            this.btArriba.Size = new System.Drawing.Size(67, 29);
            this.btArriba.TabIndex = 4;
            this.btArriba.Text = "Arriba";
            this.btArriba.UseVisualStyleBackColor = true;
            this.btArriba.Click += new System.EventHandler(this.btArriba_Click);
            // 
            // laPrincipalSize
            // 
            this.laPrincipalSize.AutoSize = true;
            this.laPrincipalSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPrincipalSize.Location = new System.Drawing.Point(92, 34);
            this.laPrincipalSize.Name = "laPrincipalSize";
            this.laPrincipalSize.Size = new System.Drawing.Size(30, 24);
            this.laPrincipalSize.TabIndex = 1;
            this.laPrincipalSize.Text = "14";
            // 
            // btAbajo
            // 
            this.btAbajo.Location = new System.Drawing.Point(115, 135);
            this.btAbajo.Name = "btAbajo";
            this.btAbajo.Size = new System.Drawing.Size(75, 32);
            this.btAbajo.TabIndex = 3;
            this.btAbajo.Text = "Abajo";
            this.btAbajo.UseVisualStyleBackColor = true;
            this.btAbajo.Click += new System.EventHandler(this.btAbajo_Click);
            // 
            // btIzquierda
            // 
            this.btIzquierda.Location = new System.Drawing.Point(55, 91);
            this.btIzquierda.Name = "btIzquierda";
            this.btIzquierda.Size = new System.Drawing.Size(67, 29);
            this.btIzquierda.TabIndex = 4;
            this.btIzquierda.Text = "Izquierda";
            this.btIzquierda.UseVisualStyleBackColor = true;
            this.btIzquierda.Click += new System.EventHandler(this.btIzquierda_Click);
            // 
            // pnBotones
            // 
            this.pnBotones.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnBotones.Controls.Add(this.btAcercade);
            this.pnBotones.Controls.Add(this.btPanel);
            this.pnBotones.Controls.Add(this.btController);
            this.pnBotones.Controls.Add(this.btDetras);
            this.pnBotones.Controls.Add(this.btDelante);
            this.pnBotones.Controls.Add(this.btDisminuye);
            this.pnBotones.Controls.Add(this.btAumenta);
            this.pnBotones.Controls.Add(this.laPrincipalSize);
            this.pnBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBotones.Location = new System.Drawing.Point(0, 350);
            this.pnBotones.Name = "pnBotones";
            this.pnBotones.Size = new System.Drawing.Size(800, 100);
            this.pnBotones.TabIndex = 5;
            // 
            // btDetras
            // 
            this.btDetras.Location = new System.Drawing.Point(150, 52);
            this.btDetras.Name = "btDetras";
            this.btDetras.Size = new System.Drawing.Size(90, 25);
            this.btDetras.TabIndex = 0;
            this.btDetras.Text = "Detras";
            this.btDetras.UseVisualStyleBackColor = true;
            this.btDetras.Click += new System.EventHandler(this.btDetras_Click);
            // 
            // btDelante
            // 
            this.btDelante.Location = new System.Drawing.Point(150, 15);
            this.btDelante.Name = "btDelante";
            this.btDelante.Size = new System.Drawing.Size(90, 25);
            this.btDelante.TabIndex = 0;
            this.btDelante.Text = "Delante";
            this.btDelante.UseVisualStyleBackColor = true;
            this.btDelante.Click += new System.EventHandler(this.btDelante_Click);
            // 
            // btDisminuye
            // 
            this.btDisminuye.Location = new System.Drawing.Point(3, 52);
            this.btDisminuye.Name = "btDisminuye";
            this.btDisminuye.Size = new System.Drawing.Size(90, 25);
            this.btDisminuye.TabIndex = 0;
            this.btDisminuye.Text = "Disminuye";
            this.btDisminuye.UseVisualStyleBackColor = true;
            this.btDisminuye.Click += new System.EventHandler(this.btDisminuye_Click);
            // 
            // btAumenta
            // 
            this.btAumenta.Location = new System.Drawing.Point(4, 15);
            this.btAumenta.Name = "btAumenta";
            this.btAumenta.Size = new System.Drawing.Size(90, 25);
            this.btAumenta.TabIndex = 0;
            this.btAumenta.Text = "Aumenta";
            this.btAumenta.UseVisualStyleBackColor = true;
            this.btAumenta.Click += new System.EventHandler(this.btAumenta_Click);
            // 
            // btVisible
            // 
            this.btVisible.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btVisible.Location = new System.Drawing.Point(703, 302);
            this.btVisible.Name = "btVisible";
            this.btVisible.Size = new System.Drawing.Size(75, 23);
            this.btVisible.TabIndex = 6;
            this.btVisible.Text = "Visible";
            this.btVisible.UseVisualStyleBackColor = true;
            this.btVisible.Click += new System.EventHandler(this.btVisible_Click);
            // 
            // btController
            // 
            this.btController.Location = new System.Drawing.Point(258, 17);
            this.btController.Name = "btController";
            this.btController.Size = new System.Drawing.Size(75, 23);
            this.btController.TabIndex = 7;
            this.btController.Text = "ControlForm";
            this.btController.UseVisualStyleBackColor = true;
            this.btController.Click += new System.EventHandler(this.btController_Click);
            // 
            // btPanel
            // 
            this.btPanel.Location = new System.Drawing.Point(258, 52);
            this.btPanel.Name = "btPanel";
            this.btPanel.Size = new System.Drawing.Size(75, 23);
            this.btPanel.TabIndex = 7;
            this.btPanel.Text = "ControlPanel";
            this.btPanel.UseVisualStyleBackColor = true;
            this.btPanel.Click += new System.EventHandler(this.btPanel_Click);
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(703, 52);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(75, 23);
            this.btAcercade.TabIndex = 7;
            this.btAcercade.Text = "Acerca de";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // btUno
            // 
            this.btUno.Location = new System.Drawing.Point(513, 135);
            this.btUno.Name = "btUno";
            this.btUno.Size = new System.Drawing.Size(75, 23);
            this.btUno.TabIndex = 7;
            this.btUno.Text = "Uno";
            this.btUno.UseVisualStyleBackColor = true;
            this.btUno.Click += new System.EventHandler(this.btUno_Click);
            // 
            // btDos
            // 
            this.btDos.Location = new System.Drawing.Point(594, 135);
            this.btDos.Name = "btDos";
            this.btDos.Size = new System.Drawing.Size(75, 23);
            this.btDos.TabIndex = 7;
            this.btDos.Text = "Dos";
            this.btDos.UseVisualStyleBackColor = true;
            this.btDos.Click += new System.EventHandler(this.btUno_Click);
            // 
            // btTres
            // 
            this.btTres.Location = new System.Drawing.Point(675, 135);
            this.btTres.Name = "btTres";
            this.btTres.Size = new System.Drawing.Size(75, 23);
            this.btTres.TabIndex = 7;
            this.btTres.Text = "Tres";
            this.btTres.UseVisualStyleBackColor = true;
            this.btTres.Click += new System.EventHandler(this.btUno_Click);
            // 
            // laPruebaSender
            // 
            this.laPruebaSender.AutoSize = true;
            this.laPruebaSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.laPruebaSender.Location = new System.Drawing.Point(554, 108);
            this.laPruebaSender.Name = "laPruebaSender";
            this.laPruebaSender.Size = new System.Drawing.Size(165, 24);
            this.laPruebaSender.TabIndex = 8;
            this.laPruebaSender.Text = "Prueba de Sender";
            // 
            // fmElformulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.laPruebaSender);
            this.Controls.Add(this.btTres);
            this.Controls.Add(this.btDos);
            this.Controls.Add(this.btUno);
            this.Controls.Add(this.btVisible);
            this.Controls.Add(this.btIzquierda);
            this.Controls.Add(this.btAbajo);
            this.Controls.Add(this.btArriba);
            this.Controls.Add(this.btDerecha);
            this.Controls.Add(this.laMover);
            this.Controls.Add(this.laPrincipal);
            this.Controls.Add(this.pnBotones);
            this.Name = "fmElformulario";
            this.Text = "Form1";
            this.pnBotones.ResumeLayout(false);
            this.pnBotones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laPrincipal;
        private System.Windows.Forms.Label laMover;
        private System.Windows.Forms.Button btDerecha;
        private System.Windows.Forms.Button btArriba;
        private System.Windows.Forms.Label laPrincipalSize;
        private System.Windows.Forms.Button btAbajo;
        private System.Windows.Forms.Button btIzquierda;
        private System.Windows.Forms.Panel pnBotones;
        private System.Windows.Forms.Button btDisminuye;
        private System.Windows.Forms.Button btAumenta;
        private System.Windows.Forms.Button btDetras;
        private System.Windows.Forms.Button btDelante;
        private System.Windows.Forms.Button btVisible;
        private System.Windows.Forms.Button btController;
        private System.Windows.Forms.Button btAcercade;
        private System.Windows.Forms.Button btPanel;
        private System.Windows.Forms.Button btUno;
        private System.Windows.Forms.Button btDos;
        private System.Windows.Forms.Button btTres;
        private System.Windows.Forms.Label laPruebaSender;
    }
}

