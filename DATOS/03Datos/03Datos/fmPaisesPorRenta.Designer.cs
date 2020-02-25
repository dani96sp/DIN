namespace _03Datos {
    partial class fmPaisesPorRenta {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.colPos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRentaCap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvDatos = new System.Windows.Forms.ListView();
            this.btMostrar2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btMostrar2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 73);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Mostrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colPos
            // 
            this.colPos.Text = "Pos.";
            // 
            // colPais
            // 
            this.colPais.Text = "Pais";
            this.colPais.Width = 153;
            // 
            // colRentaCap
            // 
            this.colRentaCap.Text = "RentaCapita";
            this.colRentaCap.Width = 94;
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPos,
            this.colPais,
            this.colRentaCap});
            this.lvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDatos.FullRowSelect = true;
            this.lvDatos.HideSelection = false;
            this.lvDatos.Location = new System.Drawing.Point(0, 73);
            this.lvDatos.MultiSelect = false;
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(800, 377);
            this.lvDatos.TabIndex = 1;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            // 
            // btMostrar2
            // 
            this.btMostrar2.Location = new System.Drawing.Point(108, 29);
            this.btMostrar2.Name = "btMostrar2";
            this.btMostrar2.Size = new System.Drawing.Size(75, 23);
            this.btMostrar2.TabIndex = 0;
            this.btMostrar2.Text = "Mostrar2";
            this.btMostrar2.UseVisualStyleBackColor = true;
            this.btMostrar2.Click += new System.EventHandler(this.btMostrar2_Click);
            // 
            // fmPaisesPorRenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvDatos);
            this.Controls.Add(this.panel1);
            this.Name = "fmPaisesPorRenta";
            this.Text = "Paises por Renta";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader colPos;
        private System.Windows.Forms.ColumnHeader colPais;
        private System.Windows.Forms.ColumnHeader colRentaCap;
        private System.Windows.Forms.ListView lvDatos;
        private System.Windows.Forms.Button btMostrar2;
    }
}