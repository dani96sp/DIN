using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08EditorGrafico
{
    public partial class fmEdiGrafico : Form
    {
        bool pulsado, rellenando;
        int actualX, actualY, OrigenX, OrigenY;
        Pen lapiz, goma;
        Point[] puntos;
        SolidBrush relleno, colorTexto;
        HatchBrush estilorelleno;
        Bitmap mibmp;
        string accion;
        Font mifuente;
        string mitexto;
        Bitmap CuadradoBoton;
        fmTexto VentanaTexto;

        fmAcercade VentanaAcercade;

        public fmEdiGrafico()
        {
            InitializeComponent();
        }

        private void Inicializar()
        {
            accion = "Lapiz";
            puntos = new Point[0];
            lapiz = new Pen(Color.Black, 1);
            colorTexto = new SolidBrush(Color.FromArgb(0, 0, 0));
            goma = new Pen(Color.White, 10);  //Color.White
            relleno = new SolidBrush(Color.FromArgb(255, 255, 255));//
            mibmp = new Bitmap(pbEdiGrafi.Width, pbEdiGrafi.Height);
            pbEdiGrafi.Image = mibmp;
            pbEdiGrafi.BackColor = Color.White;
            tbLapiz.Checked = true;  //para que funcione esto hay que desmarcar todo antes
            itLapiz.Checked = true;
            itL5.Checked = true;
            itSinRelleno.Checked = true;
            rellenando = false;
            
            tbColorLapiz.Image = Properties.Resources.colorlapiz;
            tbColorFondo.Image = Properties.Resources.colorfondo;
            tbColorRelleno.Image = Properties.Resources.brocha;

            //CrearCursorLapiz();
            tsl2.Text = "Grosor Linea: " + lapiz.Width.ToString(); //label status strip
            tsl3.Text = "Grosor Goma: " + goma.Width.ToString();

            VentanaTexto = new fmTexto();
        }


        private void Dibujar()
        {
            Graphics g1 = pbEdiGrafi.CreateGraphics();
            Graphics g2 = Graphics.FromImage(mibmp);
            Image mimage = null;
            if (accion != "Borrador")
                mimage = pbEdiGrafi.Image;
            
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
           
            switch (accion)
            {
                case "Recta":
                    g1.DrawLine(lapiz, OrigenX, OrigenY, actualX, actualY);
                    break;
                case "Rectangulo":
                    if (rellenando)
                        if (itSolido.Checked)
                            g1.FillRectangle(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g1.FillRectangle(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g1.DrawRectangle(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Lapiz":
                    if (puntos.Length > 1)
                    {
                        g1.DrawLines(lapiz, puntos);
                        g2.DrawLines(lapiz, puntos);
                    }
                    break;
                case "Goma":
                    if (puntos.Length > 1)
                    {
                        g1.DrawLines(goma, puntos);
                        g2.DrawLines(goma, puntos);
                    }
                    break;
                case "Circulo":
                    int radio = Convert.ToInt32(Math.Truncate(Math.Sqrt(Math.Pow((OrigenX - actualX), 2) + Math.Pow((OrigenY - actualY), 2))));
                    if (rellenando)
                        if (itSolido.Checked)
                            g1.FillEllipse(relleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                        else
                            g1.FillEllipse(estilorelleno, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    g1.DrawEllipse(lapiz, OrigenX - radio, OrigenY - radio, radio * 2, radio * 2);
                    break;
                case "Elipse":
                    if (rellenando)
                        if (itSolido.Checked)
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
            if (accion != "Borrador")
                pbEdiGrafi.Image = mimage;
        }

        private void FmEdiGrafico_Load(object sender, EventArgs e)
        {
            Inicializar();
        }

        private void ItSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Dibujar2()
        {
            Graphics g2 = Graphics.FromImage(mibmp);
            switch (accion)
            {
                case "Recta":
                    g2.DrawLine(lapiz, OrigenX, OrigenY, actualX, actualY);
                    break;
                case "Rectangulo":
                    if (rellenando)
                        if (itSolido.Checked)
                        {
                            g2.FillRectangle(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        }
                        else
                        {
                            g2.FillRectangle(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        }
                    g2.DrawRectangle(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Elipse":
                    if (rellenando)
                        if (itSolido.Checked)
                            g2.FillEllipse(relleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                        else
                            g2.FillEllipse(estilorelleno, new Rectangle(Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY)));
                    g2.DrawEllipse(lapiz, Math.Min(OrigenX, actualX), Math.Min(OrigenY, actualY), Math.Abs(actualX - OrigenX), Math.Abs(actualY - OrigenY));
                    break;
                case "Circulo":
                    int radio = Convert.ToInt32(Math.Truncate(Math.Sqrt(Math.Pow((OrigenX - actualX), 2) + Math.Pow((OrigenY - actualY), 2))));
                    if (rellenando)
                        if (itSolido.Checked)
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

        private void PbEdiGrafi_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pulsado = true;
                OrigenX = e.X;
                OrigenY = e.Y;
                actualX = e.X;
                actualY = e.Y;
            }
        }

        private void TbLapiz_Click(object sender, EventArgs e)
        {
            accion = "Lapiz";
            CrearCursorLapiz();
            desmarca();
            tbLapiz.Checked = true;
            itLapiz.Checked = true;
        }

        private void TbGoma_Click(object sender, EventArgs e)
        {
            accion = "Goma";
            CrearCursoGoma();
            desmarca();
            tbGoma.Checked = true;
            itBorrador.Checked = true;
        }

        private void TbLinea_Click(object sender, EventArgs e)
        {
            accion = "Recta";
            CrearCursorLapiz();//pone la imagen del lapiz como puntero del raton
            desmarca();
            tbLinea.Checked = true;
            itLinea.Checked = true;
        }

        private void TbRectangulo_Click(object sender, EventArgs e)
        {
            accion = "Rectangulo";
            desmarca();
            CrearCursorLapiz();
            tbRectangulo.Checked = true;
            itRectangulo.Checked = true;
        }

        private void TbCirculo_Click(object sender, EventArgs e)
        {
            accion = "Circulo";
            desmarca();
            CrearCursorLapiz();
            tbCirculo.Checked = true;
            itCirculo.Checked = true;
        }

        private void TbElipse_Click(object sender, EventArgs e)
        {
            accion = "Elipse";
            desmarca();
            CrearCursorLapiz();
            tbElipse.Checked = true;
            itCirculo.Checked = true;
        }

        private void TbBorrador_Click(object sender, EventArgs e)
        {
            accion = "Borrador";
            desmarca();
            CrearCursoGoma();
            tbBorrador.Checked = true;
            itBorrarSeleccion.Checked = true;
        }

        private void itAbrir_Click(object sender, EventArgs e)
        {

            dlgAbrirDibujo.FileName = Text;
            if(dlgAbrirDibujo.ShowDialog()==DialogResult.OK && dlgAbrirDibujo.FileName.Length > 0)
            {
                Inicializar();
                Graphics g2 = Graphics.FromImage(mibmp);
                pbEdiGrafi.Image = Image.FromFile(dlgAbrirDibujo.FileName); //Posible segundo parametro

                g2.DrawImage(pbEdiGrafi.Image, new Point(0, 0));
                Text = dlgAbrirDibujo.FileName;
                g2.Dispose();
            }
        }

        private void itNuevo_Click(object sender, EventArgs e)
        {

        }

        private void unir(Bitmap fondo)
        {
            //une un fondo con lo que se ha dibujado, ya que lo que dibujamos se dibuja
            //sobre un fondo transparente y si no lo unimos puede traer problemas al salvar
            //la imagen o al cambiarle el tamaño al area de dibujo
            Graphics g = Graphics.FromImage(fondo);
            g.DrawImage(mibmp, 0, 0);
            mibmp = new Bitmap(fondo);
            g.Dispose();
            fondo.Dispose();
        }

        private void tbGuardar_Click(object sender, EventArgs e)
        {
            dlgGuardarDibujo.FileName = Text;
            if(dlgGuardarDibujo.ShowDialog()==DialogResult.OK && dlgGuardarDibujo.FileName.Length > 0)
            {
                Bitmap fondo = new Bitmap(mibmp.Width, mibmp.Height);
                Graphics g = Graphics.FromImage(fondo);
                g.FillRectangle(new SolidBrush(pbEdiGrafi.BackColor), 0, 0, mibmp.Width, mibmp.Height);
                g.Dispose();
                unir(fondo);
                fondo.Dispose();
                mibmp.Save(dlgGuardarDibujo.FileName, ImageFormat.Bmp);
                Text = dlgGuardarDibujo.FileName;
            }
        }

        private void itTamanyoDibujo_Click(object sender, EventArgs e)
        {
            fmTamanyo ventanaTamanyo = new fmTamanyo();
            ventanaTamanyo.Text = "Tamaño de Dibujo en Pixeles";
            ventanaTamanyo.laIzda.Text = "Ancho";
            ventanaTamanyo.laDcha.Text = "Alto";
            ventanaTamanyo.tbIzda.Text = Convert.ToString(pbEdiGrafi.Width);
            ventanaTamanyo.tbDcha.Text = Convert.ToString(pbEdiGrafi.Height);
            if (ventanaTamanyo.ShowDialog() == DialogResult.OK)
            {
                pbEdiGrafi.Width = int.Parse(ventanaTamanyo.tbIzda.Text);
                pbEdiGrafi.Height = int.Parse(ventanaTamanyo.tbDcha.Text);
                Bitmap fondo = new Bitmap(pbEdiGrafi.Width, pbEdiGrafi.Height);
                unir(fondo);
            }
            tsl1.Text = "Tamaño del Dibujo: " + Convert.ToString(pbEdiGrafi.Width) +
                " X " + Convert.ToString(pbEdiGrafi.Height);
            ventanaTamanyo.Dispose();
        }

        private void itBarraEstandar_Click(object sender, EventArgs e)
        {
            if (sender == itcBarraEstandar || sender == itBarraEstandar)
            {
                itBarraEstandar.Checked = !itBarraEstandar.Checked;
                itcBarraEstandar.Checked = !itcBarraEstandar.Checked;
                tsEstandar.Visible = itBarraEstandar.Checked;
            }
            if (sender == itcBarraLateral|| sender == itBarraLateral)
            {
                itBarraLateral.Checked = !itBarraLateral.Checked;
                itcBarraLateral.Checked = !itcBarraLateral.Checked;
                tsLateral.Visible = itBarraLateral.Checked;
            }
            if (sender == itcBarraEstado || sender == itBarraEstado)
            {
                itBarraEstado.Checked = !itBarraEstado.Checked;
                itcBarraEstado.Checked = !itcBarraEstado.Checked;
                stEstado.Visible = itBarraEstado.Checked;
            }
        }

        private void creaCuadradoBoton()
        {
            Bitmap btemp = new Bitmap(15, 15);
            Graphics gtemp = Graphics.FromImage(btemp);
            gtemp.FillRectangle(new SolidBrush(dlgColores.Color), 0, 0, 16, 16);
            //tbColorFondo.Image = new Bitmap(btemp);
            CuadradoBoton = new Bitmap(btemp);
            gtemp.Dispose();
            btemp.Dispose();
        }

        private void tbColorFondo_Click(object sender, EventArgs e)
        {
            dlgColores.Color = pbEdiGrafi.BackColor;
            if (dlgColores.ShowDialog() == DialogResult.OK){
                creaCuadradoBoton();
                tbColorFondo.Image = CuadradoBoton;
                pbEdiGrafi.BackColor = dlgColores.Color;
                goma = new Pen(pbEdiGrafi.BackColor, 10);
            }
        }

        private void tbColorLapiz_Click(object sender, EventArgs e)
        {
            dlgColores.Color = lapiz.Color;
            if (dlgColores.ShowDialog() == DialogResult.OK)
            {
                creaCuadradoBoton();
                tbColorLapiz.Image = CuadradoBoton;
                lapiz.Color = dlgColores.Color;
            }
        }

        private void tbColorRelleno_Click(object sender, EventArgs e) {
            if(!rellenando) {
                MessageBox.Show("Elige tipo relleno en Estilo");
            } else {
                dlgColores.Color = relleno.Color;
                if(dlgColores.ShowDialog() == DialogResult.OK) {
                    creaCuadradoBoton();
                    tbColorRelleno.Image = CuadradoBoton;
                    relleno.Color = dlgColores.Color;
                    if(rellenando && !itSolido.Checked) {
                        itLineasVerticales.PerformClick();
                    }
                }
            }
        }

        private void itmG1_Click(object sender, EventArgs e)
        {
            if(lapiz.Width > 0 && lapiz.Width < 7 && sender is ToolStripMenuItem)
            {
                ToolStripMenuItem elemento = sender as ToolStripMenuItem;
                //elemento.Checked = true;
                lapiz.Width = Convert.ToSingle(elemento.Tag);
                tsl2.Text = "Grosor línea: " + lapiz.Width.ToString();
            }
        }

        private void tbTexto_Click(object sender, EventArgs e) {
            accion = "Texto";
            desmarca();
            tbTexto.Checked = true;
            itTexto.Checked = true;
            VentanaTexto.Location = new Point(Left + 30, Top + 170);
            if(VentanaTexto.ShowDialog() == DialogResult.OK) {
                mifuente = VentanaTexto.mifuente;
                colorTexto.Color = VentanaTexto.colortexto.Color;
                mitexto = VentanaTexto.mitexto;
            }



        }

        private void fmEdiGrafico_KeyDown(object sender, KeyEventArgs e) {
            if(e.KeyCode == Keys.Add) {
                if(accion == "Goma") {
                    if(goma.Width < 100) {
                        goma.Width++;
                        CrearCursoGoma();
                    }
                } else {
                    if(lapiz.Width < 100) {
                        lapiz.Width++;
                    }
                }
            }
            if(e.KeyCode == Keys.Subtract) {
                if(accion == "Goma") {
                    if(goma.Width > 10) {
                        goma.Width--;
                        CrearCursoGoma();
                    }
                } else {
                    if(lapiz.Width > 10) {
                        lapiz.Width--;
                    }
                }
            }
            tsl2.Text = "Grosor Linea: " + lapiz.Width.ToString();
            tsl3.Text = "Grosor Goma: " + goma.Width.ToString();
        }

        private void itGrosorLinea_Click(object sender, EventArgs e) {
            fmTamanyo ventanaTamanyo = new fmTamanyo();
            ventanaTamanyo.Text = "Grosor de Línea y Goma en Puntos";
            ventanaTamanyo.laIzda.Text = "Grosor Línea";
            ventanaTamanyo.laDcha.Text = "Grosor Goma";
            ventanaTamanyo.tbIzda.Text = Convert.ToString(lapiz.Width);
            ventanaTamanyo.tbDcha.Text = Convert.ToString(goma.Width);
            Single copia = goma.Width;
            if(ventanaTamanyo.ShowDialog() == DialogResult.OK) {
                lapiz.Width = int.Parse(ventanaTamanyo.tbIzda.Text);
                goma.Width = int.Parse(ventanaTamanyo.tbDcha.Text);
                if (!tbGoma.Checked && copia != goma.Width) {
                    MessageBox.Show("Los cambios de grosor no se aplicarán hasta que selecciones goma.");
                }
            }
            ventanaTamanyo.Dispose();

            tsl2.Text = "Grosor Linea: " + lapiz.Width.ToString();
            tsl3.Text = "Grosor Goma: " + goma.Width.ToString();
        }

        private void itL1_Click(object sender, EventArgs e) {
            foreach(ToolStripMenuItem milinea in itTipoLinea.DropDownItems) {
                milinea.Checked = false;
            }
            ToolStripMenuItem elemento = sender as ToolStripMenuItem;
            int mitag = Convert.ToInt32(elemento.Tag);
            elemento.Checked = true;
            switch(mitag) {
                case 1:
                    lapiz.DashStyle = DashStyle.Dash;
                    break;
                case 2:
                    lapiz.DashStyle = DashStyle.DashDot;
                    break;
                case 3:
                    lapiz.DashStyle = DashStyle.Dot;
                    break;
                case 4:
                    lapiz.DashStyle = DashStyle.DashDotDot;
                    break;
                case 5:
                    lapiz.DashStyle = DashStyle.Solid;
                    break;
            }
        }

        private void itLineasVerticales_Click(object sender, EventArgs e) {
            rellenando = true;
            desmarcamenu(itTipoRelleno.DropDownItems);
            ToolStripMenuItem elemento = sender as ToolStripMenuItem;
            int mitag = Convert.ToInt32(elemento.Tag);
            elemento.Checked = true;
            switch(mitag) {
                case 1:
                    estilorelleno = new HatchBrush(HatchStyle.Vertical, lapiz.Color, relleno.Color);
                    break;
                case 2:
                    estilorelleno = new HatchBrush(HatchStyle.Cross, lapiz.Color, relleno.Color); 
                    break;
                case 3:
                    estilorelleno = new HatchBrush(HatchStyle.Horizontal, lapiz.Color, relleno.Color);
                    break;
                case 4:
                    estilorelleno = new HatchBrush(HatchStyle.ForwardDiagonal, lapiz.Color, relleno.Color);
                    break;
                case 5:
                    estilorelleno = new HatchBrush(HatchStyle.ZigZag, lapiz.Color, relleno.Color);
                    break;
                case 6:
                    estilorelleno = new HatchBrush(HatchStyle.Plaid, lapiz.Color, relleno.Color);
                    break;
                case 7:
                    estilorelleno = new HatchBrush(HatchStyle.Percent20, lapiz.Color, relleno.Color);
                    break;
                case 8:
                    rellenando = false;
                    relleno = new SolidBrush(Color.FromArgb(255, 255, 255));
                    tbColorRelleno.Image = Properties.Resources.brocha;
                    break;
            }
        }

        private void desmarcamenu(ToolStripItemCollection menuitems) {
            foreach(ToolStripMenuItem milinea in menuitems) {
                milinea.Checked = false;
            }
        }

        private void itAcercaDe_Click(object sender, EventArgs e) {

            VentanaAcercade = new fmAcercade();
            VentanaAcercade.ShowDialog();

            VentanaAcercade.Dispose();
        }

        private void PbEdiGrafi_MouseMove(object sender, MouseEventArgs e)
        {
            tsl4.Text = "X: " + e.X.ToString() + " Y: " + e.Y.ToString();
            if (pulsado)
            {
                if (accion == "Lapiz" || accion == "Goma")
                {
                    agregarPunto(new Point(e.X, e.Y));
                    Dibujar();
                }
                else
                {
                    Dibujar();
                    Color copiacolor = lapiz.Color;
                    if (pulsado && (lapiz.Color != pbEdiGrafi.BackColor))
                    {
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

        private void PbEdiGrafi_MouseUp(object sender, MouseEventArgs e)
        {
            if (pulsado)
                Dibujar2();

            pulsado = false;

            //Aqui reinicializamos a puntos para que no se unan las lineas al volver a dibujar 
            puntos = new Point[0];
            //Marcamos como transparente  para que al cambiar de fondo no se vea lo que borramos 
            mibmp.MakeTransparent(pbEdiGrafi.BackColor);
            //ponemos la imagen dibujada como fondo  para que el trabajo de dibujar sea mas rapido. 
            pbEdiGrafi.Image = mibmp;
        }

        private void agregarPunto(Point punto)
        {
            //agrega los puntos obtenidos 
            Point[] temp = new Point[puntos.Length + 1];
            puntos.CopyTo(temp, 0);
            puntos = temp;
            puntos[puntos.Length - 1] = punto;
        }

        private void desmarca()
        {
            for(int i = 0; i < 6; i++)//desmarca item de menu figuras
            {
                ((ToolStripMenuItem)itFiguras.DropDownItems[i]).Checked = false;
            }

            foreach(ToolStripButton boton in tsLateral.Items)//desmarca botones laterales
            {
                boton.Checked = false;
            }
            tbLapiz.Checked = false;
            tbGoma.Checked = false;
            itLapiz.Checked = false;
            itBorrador.Checked = false;
        }
        private void CrearCursorLapiz()
        {
            IntPtr intPrCursor = Properties.Resources.lapizcortoNuevo1.GetHicon();
            //Properties.Resources.lapizcorto.MakeTransarent(Color.Magenta);
            pbEdiGrafi.Cursor = new Cursor(intPrCursor);
            //pbEdiGrafi.Cursor = Cursor; //cursor normal
        }

        private void CrearCursoGoma()
        {
            int diametroG = Convert.ToInt32(goma.Width);
            Bitmap Goma = new Bitmap(diametroG, diametroG);

            Graphics gGoma = Graphics.FromImage(Goma);
            gGoma.FillRectangle(Brushes.Magenta, 0, 0, diametroG, diametroG);
            SolidBrush rellenoBorra = new SolidBrush(pbEdiGrafi.BackColor);
            gGoma.FillEllipse(rellenoBorra, 0, 0, diametroG - 1, diametroG - 1);
            gGoma.DrawEllipse(new Pen(Color.Black, 1), 0, 0, diametroG - 1, diametroG - 1);
            Goma.MakeTransparent(Color.Magenta);
            gGoma.Dispose();
            IntPtr intPrCursorGoma = Goma.GetHicon();
            pbEdiGrafi.Cursor = new Cursor(intPrCursorGoma);
        }
    }


}
