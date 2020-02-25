using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmDibujo {
    public partial class fmDibujo : Form {

        fmAcercade VentanaAcercade;
        Bitmap mig;
        Graphics imEditor;
        int rojo, verde, azul;
        Pen grosor;
        string Text;

        private void fmDibujo_Load(object sender, EventArgs e) {
            rojo = 0;
            verde = 0;
            azul = 0;
            Text = "Dibujo1";
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);
            imEditor = Graphics.FromImage(mig);
            grosor = new Pen(Color.Black, 2);
        }

        private void btnPruebaColores_Click(object sender, EventArgs e) {
            pnColores.Enabled = !pnColores.Enabled;
        }

        private void btnAplicar_Click(object sender, EventArgs e) {
            rojo = traRojo.Value;
            verde = traVerde.Value;
            azul = traAzul.Value;

            grosor = new Pen(Color.FromArgb(rojo, verde, azul), 2);

        }

        private void traRojo_Scroll(object sender, EventArgs e) {
            laPrueba.BackColor = Color.FromArgb(traRojo.Value, traVerde.Value, traAzul.Value);

            // Color invertido para la fuente
            laPrueba.ForeColor = Color.FromArgb(255 - traRojo.Value, 255 - traVerde.Value, 255 - traAzul.Value);
        }

        private void tsbLinea_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            imEditor.DrawLine(grosor, 0, 80, 500, 80);
            
        }

        private void tsbCuadrado_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            imEditor.DrawRectangle(grosor, 150, 1, 50, 50);
            SolidBrush relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
            
            if (ckRelleno.Checked) {
                imEditor.FillRectangle(relleno, new Rectangle(150, 1, 50, 50));
            } else {
                relleno = new SolidBrush(Color.White);
                imEditor.FillRectangle(relleno, new Rectangle(150, 1, 50, 50));
            }
            relleno.Dispose();
        }

        private void tsbRectangulo_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            imEditor.DrawRectangle(grosor, 60, 1, 80, 60);
            SolidBrush relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));

            if(!ckRelleno.Checked) {
                relleno = new SolidBrush(Color.White);
            }
            imEditor.FillRectangle(relleno, new Rectangle(60, 1, 80, 60));
            relleno.Dispose();
        }

        private void tsbArco_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            imEditor.DrawArc(grosor, 0, 85, 150, 50, 90, 190);
        }

        private void tsbCirculo_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            imEditor.DrawEllipse(grosor, new Rectangle(1, 1, 50, 50));
            SolidBrush relleno = new SolidBrush(Color.White);

            if(ckRelleno.Checked) {
                relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
            }

            imEditor.FillEllipse(relleno, new Rectangle(1, 1, 50, 50));
            relleno.Dispose();
        }

        private void tsbElipse_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            imEditor.DrawEllipse(grosor, new Rectangle(210, 1, 60, 40));
            SolidBrush relleno = new SolidBrush(Color.White);

            if(ckRelleno.Checked) {
                relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
            }

            imEditor.FillEllipse(relleno, new Rectangle(210, 1, 60, 40));
            relleno.Dispose();
        }

        private void tsbPoligono_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            Point[] vertices = { new Point(100, 126),
                new Point(150, 100),
                new Point(200, 126),
                new Point(200, 174),
                new Point(150, 200),
                new Point(100, 174)};
            imEditor.DrawPolygon(grosor, vertices);
            SolidBrush relleno = new SolidBrush(Color.White);

            if(ckRelleno.Checked) {
                relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
            }

            imEditor.FillPolygon(relleno, vertices);
            relleno.Dispose();
        }

        private void tsbCurva_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            Point[] vertices = { new Point(250, 126),
                new Point(300, 100),
                new Point(350, 126),
                new Point(400, 100)};
            imEditor.DrawCurve(grosor, vertices);
        }

        private void tsbCurvaCerrada_Click(object sender, EventArgs e) {
            pbEditor.Image = (Image)mig;
            Point[] vertices = {
                new Point(220, 206),
                new Point(270, 180),
                new Point(320, 206),
                new Point(370, 180)};
            imEditor.DrawClosedCurve(grosor, vertices);
        }

        private void tsbTexto_Click(object sender, EventArgs e) {
            pbEditor.Image = mig;
            Font fuente = new Font("Arial", 15);
            SolidBrush relleno = new SolidBrush(Color.FromArgb(rojo, verde, azul));
            imEditor.DrawString("Texto Incrustado En Gráfico", fuente, relleno, 50, 220);
            relleno.Dispose();
        }

        private void fmDibujo_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Up && grosor.Width < 100) {
                grosor.Width++;
            }
            if(e.KeyCode == Keys.Down && grosor.Width > 1) {
                grosor.Width--;
            }

            tsl2.Text = "Grosor Linea: " + grosor.Width.ToString(); // Barra de estado

        }

        private void btDemostracion_Click(object sender, EventArgs e) {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);
            pbEditor.Image = mig;
            imEditor = Graphics.FromImage(mig);
            pbaDemo.Visible = true;
            pbaDemo.Value = 5;
            tspbDemostracion.Value = 5;
            foreach(ToolStripButton miboton in tsBarraBotones.Items) {
                miboton.PerformClick();
                pbEditor.Update();
                Thread.Sleep(1000);
                pbaDemo.PerformStep();
                tspbDemostracion.PerformStep();
            }
            pbEditor.BackColor = Color.FromArgb(255 - rojo, 255 - verde, 255 - azul);
            pbaDemo.Value = 100;
            tspbDemostracion.Value = 100;

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e) {
            mig = new Bitmap(pbEditor.Width, pbEditor.Height);
            pbEditor.Image = mig;
            imEditor = Graphics.FromImage(mig);
            traRojo.Value = traVerde.Value = traAzul.Value = 0;
            rojo = verde = azul = 0;

            traRojo_Scroll(sender, e);

            grosor.Width = 1;
            pbEditor.BackColor = Color.White;
            pbaDemo.Value = 0;
            ckRelleno.Checked = false;
        }

        private void itAbrir_Click(object sender, EventArgs e) {
            dlgAbrirDibujo.FileName = Text;
            if (dlgAbrirDibujo.ShowDialog() == DialogResult.OK && dlgAbrirDibujo.FileName.Length > 0) {
                pbEditor.Image = Image.FromFile(dlgAbrirDibujo.FileName);
                imEditor.DrawImage(pbEditor.Image, new Point(0, 0));
                Text = dlgAbrirDibujo.FileName;
                pbEditor.SizeMode = PictureBoxSizeMode.StretchImage; // Opcional, se pone para estirar o encoger el gráfico
            }
        }

        private void itGuardar_Click(object sender, EventArgs e) {
            dlgGuardarDibujo.FileName = Text;
            if (dlgGuardarDibujo.ShowDialog() == DialogResult.OK && dlgGuardarDibujo.FileName.Length > 0) {
                pbEditor.Image.Save(dlgGuardarDibujo.FileName);
                Text = dlgGuardarDibujo.FileName;
            }
        }

        private void itAcercade_Click(object sender, EventArgs e) {
            VentanaAcercade = new fmAcercade();
            VentanaAcercade.ShowDialog();

            VentanaAcercade.Dispose();
        }

        public fmDibujo() {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) {
            pbEditor.Image = (Image)mig;
            if(e.Button == MouseButtons.Left && (e.X < pbEditor.Width && e.X > 0 && e.Y > 0 && e.Y < pbEditor.Height)) {
                ((Bitmap)pbEditor.Image).SetPixel(e.X, e.Y, Color.FromArgb(rojo, verde, azul));
            }

            stGrafico.Items[0].Text = Convert.ToString(e.X) + "       " + Convert.ToString(e.Y);


        }
    }
}
