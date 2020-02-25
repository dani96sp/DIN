using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08EditorGrafico {
    public partial class EditorGrafico : Form {
        //fmAcercade VentanaAcerca;
        //fmTexto VentanaTexto;
        //fmTamanyo VentanaTamanyo;

        bool pulsado, rellenando;
        int OrigenX = 0;
        int OrigenY = 0;
        int actualX = 0;
        int actualY = 0;
        Point[] puntos;
        Pen lapiz, goma;
        SolidBrush relleno, colorTexto;
        HatchBrush estilorelleno;
        Bitmap mibmp;
        string accion; // Tipos de figura
        Font mifuente;
        string mitexto;
        Bitmap CuadradoBoton;

        private void desmarca() {
            for(int i = 0; i < 6; i++) {
                ((ToolStripMenuItem)itFiguras.DropDownItems[i]).Checked = false;
            }
            foreach(ToolStripMenuItem boton in tsLateral.Items) {
                boton.Checked = false;
            }
            /*
            tblapiz.Checked = false;
            tbGoma.Checked = false;
            itGoma.Checked = false;
            itBorrador.Checked = false;
            */
        }

        public EditorGrafico() {
            InitializeComponent();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e) {

        }

        private void pbEdigrafi_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                pulsado = true;
                OrigenX = e.X;
                OrigenY = e.Y;
                actualX = e.X;
                actualY = e.Y;
            }
        }

        private void pbEdigrafi_MouseMove(object sender, MouseEventArgs e) {
            tsl4.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
            if(pulsado) {
                if(accion == "Lapiz" || accion == "Goma") {
                    agregarPunto(new Point(e.X, e.Y));
                    Dibujar();
                } else {
                    Dibujar();
                    Color copiacolor = lapiz.Color;
                    if(pulsado && (lapiz.Color != pbEdigrafi.BackColor)) {
                        lapiz.Color = Color.FromArgb(255 - lapiz.Color.R, 255 - lapiz.Color.G, 255 - lapiz.Color.B);// pbEdigrafi.BackColor;
                        Dibujar();
                    }

                    actualX = e.X;
                    actualY = e.Y;
                    lapiz.Color = copiacolor;
                    Dibujar();
                }

            }
        }

        private void pbEdigrafi_MouseUp(object sender, MouseEventArgs e) {
            if(pulsado)
                Dibujar2();

            pulsado = false;

            //Aqui reinicializamos a puntos para que no se unan las lineas al volver a dibujar 
            puntos = new Point[0];
            //Marcamos como transparente  para que al cambiar de fondo no se vea lo que borramos 
            mibmp.MakeTransparent(pbEdigrafi.BackColor);
            //ponemos la imagen dibujada como fondo  para que el trabajo de dibujar sea mas rapido. 
            pbEdigrafi.Image = mibmp;
        }


        private void agregarPunto(Point punto) {
            //agrega los puntos obtenidos 
            Point[] temp = new Point[puntos.Length + 1];
            puntos.CopyTo(temp, 0);
            puntos = temp;
            puntos[puntos.Length - 1] = punto;
        }

        private void EditorGrafico_Load(object sender, EventArgs e) {
            Inicializar();
        }

        private void Dibujar() {
            Graphics g1 = pbEdigrafi.CreateGraphics();
            Graphics g2 = Graphics.FromImage(mibmp);
            Image mimage = null;
            if(accion != "Borrador")
                mimage = pbEdigrafi.Image;
            /*
                       //Con este código desplazamos el origen al punto que indique la coordenada del puntero del raton
                       if ((actualX < OrigenX) && (accion =="Rectangulo"|| accion == "Circulo"|| accion == "Elipse"))
                       {
                           int temp = OrigenX;
                           OrigenX = actualX;
                           actualX = temp;
                       }
                       if ((actualY < OrigenY) && (accion == "Rectangulo" || accion == "Circulo" || accion == "Elipse"))
                       {
                           int temp = OrigenY;
                           OrigenY = actualY;
                           actualY = temp;
                       }
           */
            switch(accion) {
                case "Recta":
                    g1.DrawLine(lapiz, OrigenX, OrigenY, actualX, actualY);
                    break;
                case "Rectangulo":
                    if(rellenando)
                        if(itSolido.Checked)
                            g1.FillRectangle(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g1.FillRectangle(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g1.DrawRectangle(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Lapiz":
                    if(puntos.Length > 1) {
                        g1.DrawLines(lapiz, puntos);
                        g2.DrawLines(lapiz, puntos);
                    }
                    break;
                case "Goma":
                    if(puntos.Length > 1) {
                        g1.DrawLines(goma, puntos);
                        g2.DrawLines(goma, puntos);
                    }
                    break;
                case "Circulo":
                    int radio = Convert.ToInt32(Math.Truncate(Math.Sqrt(Math.Pow((OrigenX - actualX), 2) + Math.Pow((OrigenY - actualY), 2))));
                    if(rellenando)
                        if(itSolido.Checked)
                            g1.FillEllipse(relleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                        else
                            g1.FillEllipse(estilorelleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    g1.DrawEllipse(lapiz, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    break;
                case "Elipse":
                    if(rellenando)
                        if(itSolido.Checked)
                            g1.FillEllipse(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g1.FillEllipse(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g1.DrawEllipse(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Texto":
                    g1.DrawString(mitexto, mifuente, colorTexto, actualX, actualY - 10);
                    break;
                case "Borrador":
                    SolidBrush rellenoborra = new SolidBrush(Color.White);
                    g1.FillRectangle(rellenoborra, new Rectangle(OrigenX, OrigenY, Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    break;
            }
            g1.Dispose();
            g2.Dispose();
            if(accion != "Borrador")
                pbEdigrafi.Image = mimage;
        }


        private void Dibujar2() {
            Graphics g2 = Graphics.FromImage(mibmp);
            switch(accion) {
                case "Recta":
                    g2.DrawLine(lapiz, OrigenX, OrigenY, actualX, actualY);
                    break;
                case "Rectangulo":
                    if(rellenando)
                        if(itSolido.Checked) {
                            g2.FillRectangle(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        } else {
                            g2.FillRectangle(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        }
                    g2.DrawRectangle(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Elipse":
                    if(rellenando)
                        if(itSolido.Checked)
                            g2.FillEllipse(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g2.FillEllipse(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g2.DrawEllipse(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Circulo":
                    int radio = Convert.ToInt32(Math.Truncate(Math.Sqrt(Math.Pow((OrigenX - actualX), 2) + Math.Pow((OrigenY - actualY), 2))));
                    if(rellenando)
                        if(itSolido.Checked)
                            g2.FillEllipse(relleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                        else
                            g2.FillEllipse(estilorelleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    g2.DrawEllipse(lapiz, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    break;
                case "Texto":
                    g2.DrawString(mitexto, mifuente, colorTexto, actualX, actualY - 10);
                    break;
                case "Borrador":
                    SolidBrush rellenoborra = new SolidBrush(Color.White);
                    g2.FillRectangle(rellenoborra, new Rectangle(OrigenX, OrigenY, Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    break;
            }

            g2.Dispose();
        }

        private void tblapiz_Click(object sender, EventArgs e) {
            CrearCursorLapiz();
            desmarca();
            tblapiz.Checked = true;
        }

        private void tbGoma_Click(object sender, EventArgs e) {
            CrearCursorGoma();
            desmarca();
            tbGoma.Checked = true;
        }

        private void tbGuardar_Click(object sender, EventArgs e) {

        }

        private void tbAbrir_Click(object sender, EventArgs e) {

        }

        private void tbNuevo_Click(object sender, EventArgs e) {

        }

        private void Inicializar() {
            accion = "Lapiz";
            puntos = new Point[0];
            lapiz = new Pen(Color.Black, 1);
            colorTexto = new SolidBrush(Color.FromArgb(0, 0, 0));
            goma = new Pen(Color.White, 10);  //Color.White
            relleno = new SolidBrush(Color.FromArgb(255, 255, 255));//
            mibmp = new Bitmap(pbEdigrafi.Width, pbEdigrafi.Height);
            pbEdigrafi.Image = mibmp;
            pbEdigrafi.BackColor = Color.White;
            tblapiz.Checked = true;  //para que funcione esto hay que desmarcar todo antes
            itLapiz.Checked = true;
            itLinea5.Checked = true;
            itSinRelleno.Checked = true;
            rellenando = false;

            tbColorlapiz.Image = Properties.Resources.colorlapiz;
            tbColorFondo.Image = Properties.Resources.colorfondo;
            tbColorRelleno.Image = Properties.Resources.brocha;

            CrearCursorLapiz();
            tsl2.Text = "Grosor Linea: " + lapiz.Width.ToString(); //label status strip
            tsl3.Text = "Grosor Goma: " + goma.Width.ToString();
        }

        private void CrearCursorLapiz() {
            IntPtr intprCursor = Properties.Resources.lapizcortoNuevo1.GetHicon();
            pbEdigrafi.Cursor = new Cursor(intprCursor);
        }

        private void CrearCursorGoma() {
            int diametroG = Convert.ToInt32(goma.Width);
            Bitmap Goma = new Bitmap(diametroG, diametroG);

            Graphics gGoma = Graphics.FromImage(Goma);
            gGoma.FillRectangle(Brushes.Magenta, 0, 0, diametroG, diametroG);
            SolidBrush rellenoborra = new SolidBrush(pbEdigrafi.BackColor);
            gGoma.FillEllipse(rellenoborra, 0, 0, diametroG - 1, diametroG - 1);
            gGoma.DrawEllipse(new Pen(Color.Black, 1), 0, 0, diametroG - 1, diametroG - 1);
            Goma.MakeTransparent(Color.Magenta);
            gGoma.Dispose();
            IntPtr intprCursorGoma = Goma.GetHicon();
            pbEdigrafi.Cursor = new Cursor(intprCursorGoma);
        }
    }
}
