using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Editor {
    public partial class fmEditor : Form {
        fmDatos datos;
        fmAcercade VentanaAcercade;

        FontStyle miestilo = new FontStyle();
        string mifuente;
        float mitamanyo;
        Color micolor;

        public fmEditor() {
            datos = new fmDatos();
            InitializeComponent();

            Application.Idle += AplicacionDesocupada; // AplicacionOciosa
        }

        private void AplicacionDesocupada(object sender, EventArgs e) {
            // BARRA ESTADO
            // obtener linea en la que está el cursor del texto
            int linea = rtbEditor.GetLineFromCharIndex(rtbEditor.SelectionStart);

            int columna = rtbEditor.SelectionStart - rtbEditor.GetFirstCharIndexOfCurrentLine();

            stEstadoEditor.Items[1].Text = "Lin. " + Convert.ToString(linea) +
                "     Col. " + Convert.ToString(columna);

            stEstadoEditor.Items[2].Text = "Car. " + Convert.ToString(rtbEditor.SelectionStart);

            // BOTONES BARRA SUPERIOR
            Boolean HaySeleccion = rtbEditor.SelectionLength > 0;

            if (HaySeleccion) {
                stEstadoEditor.Items[0].Text = "Hay Texto seleccionado";
            } else {
                stEstadoEditor.Items[0].Text = "";
            }

            tsbCopiar.Enabled = HaySeleccion;
            tsbCortar.Enabled = HaySeleccion;
            tsbDeshacer.Enabled = rtbEditor.CanUndo;
            tsbRehacer.Enabled = rtbEditor.CanRedo;
            tsbPegar.Enabled = Clipboard.ContainsText(); // si el portapapeles contiene texto
            // ITEMS MENU
            itPegar.Enabled = tsbPegar.Enabled;
            itCopiar.Enabled = tsbCopiar.Enabled;
            itCortar.Enabled = tsbCortar.Enabled;
            itDeshacer.Enabled = tsbDeshacer.Enabled;
            itRehacer.Enabled = tsbRehacer.Enabled;
            itBorrar.Enabled = HaySeleccion;

            // ITEMS MENU
            cmnPegar.Enabled = tsbPegar.Enabled;
            cmnCopiar.Enabled = tsbCopiar.Enabled;
            cmnCortar.Enabled = tsbCortar.Enabled;
            cmnDeshacer.Enabled = tsbDeshacer.Enabled;
            cmnRehacer.Enabled = tsbRehacer.Enabled;
            cmnBorrar.Enabled = HaySeleccion;

        }

        private void TimerEditor_Tick(object sender, EventArgs e) {
            DateTime fecha = DateTime.Now;
            stEstadoEditor.Items[3].Text = fecha.Day + "/" + fecha.Month + "/" + fecha.Year;
            stEstadoEditor.Items[4].Text = fecha.Hour + ":" + fecha.Minute + ":" + fecha.Second;
        }

        // Para que la barra de estado siempre tenga el mismo tamanyo
        void tamanyoBarraEstado() {
            // poner autosize de cada item a false
            // invocamos a este metodo en los eventos Load y Resize
            stEstadoEditor.Items[0].Width = Width - 350;
            stEstadoEditor.Items[1].Width = 100;
            stEstadoEditor.Items[2].Width = 60;
            stEstadoEditor.Items[3].Width = 70;
            stEstadoEditor.Items[4].Width = 90;
        }

        private void FmEditor_Load(object sender, EventArgs e) {
            tamanyoBarraEstado();

            foreach (FontFamily misFuentes in FontFamily.Families) {
                cbxFuente.Items.Add(misFuentes.Name);
            }
            cbxFuente.Text = "Microsoft Sans Serif";

            cbxTamanyo.Items.Add(8);
            cbxTamanyo.Items.Add(12);
            cbxTamanyo.Items.Add(14);
            cbxTamanyo.Items.Add(18);
            cbxTamanyo.Items.Add(22);
            cbxTamanyo.Items.Add(26);
            cbxTamanyo.Text = "8";

            Text = "Documento1";
            rtbEditor.Modified = false;
            rtbEditor.ClearUndo();
            rtbEditor.Focus();

            itQuitarFormatos.PerformClick();
        }

        private void FmEditor_Resize(object sender, EventArgs e) {
            tamanyoBarraEstado();
        }

        private void ponerEstilo() {
            FontStyle negrita = new FontStyle();
            FontStyle subrayado = new FontStyle();
            FontStyle cursiva = new FontStyle();
            FontStyle tachado = new FontStyle();

            if (tsbNegrita.Checked) {
                negrita = FontStyle.Bold;
            }
            if (tsbSubrayado.Checked) {
                subrayado = FontStyle.Underline;
            }
            if (tsbCursiva.Checked) {
                cursiva = FontStyle.Italic;
            }
            if (tsbTachado.Checked) {
                tachado = FontStyle.Strikeout;
            }

            rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, negrita | subrayado | tachado | cursiva);
            rtbEditor.Focus();
        }

        // tsbNegrita, cursiva, tachado y subrayado
        private void TsbNegrita_Click(object sender, EventArgs e) {
            // Con la propiedad CheckOnClick no hace falta la siguiente linea,
            // ya que funciona como un CheckBox
            // tsbNegrita.Checked = !tsbNegrita.Checked
            ponerEstilo();
        }

        private void desmarcarAlineacion() {
            tsbIzq.Checked = false;
            tsbCentrado.Checked = false;
            tsbDer.Checked = false;
            itIzq.Checked = false;
            itCentrado.Checked = false;
            itDer.Checked = false;
        }

        private void TsbIzq_Click(object sender, EventArgs e) {
            desmarcarAlineacion();
            tsbIzq.Checked = true;
            itIzq.Checked = true;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void TsbCentrado_Click(object sender, EventArgs e) {
            desmarcarAlineacion();
            tsbCentrado.Checked = true;
            itCentrado.Checked = true;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void TsbDer_Click(object sender, EventArgs e) {
            desmarcarAlineacion();
            tsbDer.Checked = true;
            itDer.Checked = true;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void CbxFuente_SelectedIndexChanged(object sender, EventArgs e) {
            // recoger estilo y tamaño para completar selectionFont
            try {
                FontStyle estilo = new FontStyle();
                estilo = rtbEditor.SelectionFont.Style;
                string fuente = cbxFuente.Text;
                float tamanyo = rtbEditor.SelectionFont.Size;
                rtbEditor.SelectionFont = new Font(fuente, tamanyo, estilo);
            } catch {
                return;
            }
        }

        private void CbxTamanyo_TextChanged(object sender, EventArgs e) {
            // recoger estilo y tamaño para completar selectionFont
            try {
                FontStyle estilo = new FontStyle();
                estilo = rtbEditor.SelectionFont.Style;
                string fuente = rtbEditor.SelectionFont.Name;

                if (cbxTamanyo.Text != "") {
                    rtbEditor.SelectionFont = new Font(fuente, Convert.ToInt32(Math.Truncate(Convert.ToDecimal(cbxTamanyo.Text))), estilo);
                }
            } catch {
                return;
            }
        }

        private void CbxTamanyo_KeyPress(object sender, KeyPressEventArgs e) {
            // solo números
            switch (e.KeyChar) {
                case (char)8: // borrar
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case (char)',':
                case (char)'.': break;
                default:
                    e.KeyChar = (char)0; // denegar
                    break;
            }
        }

        private void ItAbrir_Click(object sender, EventArgs e) {
            stEstadoEditor.Items[0].Text = "Abriendo Archivo...";
            // si el editor ha sido modificado lanzamos un dialogo
            if (rtbEditor.Modified) {
                DialogResult resultado =
                    MessageBox.Show("¿Guardar cambios?", "Hay cambios pendientes de Guardar", MessageBoxButtons.YesNoCancel);

                switch (resultado) {
                    case DialogResult.Yes:
                        itGuardar.PerformClick();
                        break;

                    case DialogResult.Cancel:
                        rtbEditor.Focus();
                        return;
                }
            }
            // ejecutar dialogoAbrir
            if (dlgAbrir.ShowDialog() == DialogResult.OK && dlgAbrir.FileName.Length > 0) {
                if (dlgAbrir.FilterIndex == 1) {
                    rtbEditor.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.PlainText);
                } else {
                    rtbEditor.LoadFile(dlgAbrir.FileName, RichTextBoxStreamType.RichText);
                }

                Text = dlgAbrir.FileName;
                rtbEditor.Modified = false;
            }

            stEstadoEditor.Items[0].Text = "";
            rtbEditor.Focus();
        }

        private void ItGuardar_Click(object sender, EventArgs e) {
            if (Text == "Documento1") {
                itGuardarComo.PerformClick();
            } else {
                rtbEditor.SaveFile(Text);
                rtbEditor.Modified = false;
                rtbEditor.Focus();
            }
        }

        private void ItGuardarComo_Click(object sender, EventArgs e) {
            // No hace falta añadir la extensión al nombre si se utiliza el filename al grabar y se pone valor al defaultText
            dlgGuardar.FileName = Text;
            if (dlgGuardar.ShowDialog() == DialogResult.OK && dlgGuardar.FileName.Length > 0) {
                if (dlgGuardar.FilterIndex == 1) {
                    rtbEditor.SaveFile(dlgGuardar.FileName, RichTextBoxStreamType.PlainText);
                } else {
                    rtbEditor.SaveFile(dlgGuardar.FileName, RichTextBoxStreamType.RichText);
                }
                Text = dlgGuardar.FileName;
                rtbEditor.Modified = false;
            }
        }

        private void ItNuevo_Click(object sender, EventArgs e) {
            stEstadoEditor.Items[0].Text = "Generando Nuevo Archivo...";
            // si el editor ha sido modificado lanzamos un dialogo
            if (rtbEditor.Modified) {
                DialogResult resultado =
                    MessageBox.Show("¿Guardar cambios?", "Hay cambios pendientes de Guardar", MessageBoxButtons.YesNoCancel);

                switch (resultado) {
                    case DialogResult.Yes:
                        itGuardar.PerformClick();
                        break;

                    case DialogResult.Cancel:
                        rtbEditor.Focus();
                        return;
                }
            }
            rtbEditor.Clear();
            Text = "Documento1";
            //itQuitarFormatos.PerfomClick();
            rtbEditor.Modified = false;
            stEstadoEditor.Items[0].Text = "";
            rtbEditor.Focus();
        }

        private void itImprimir_Click(object sender, EventArgs e) {
            PrintDocument midocumento = new PrintDocument();
            dlgImprimir.Document = midocumento;
            if(dlgImprimir.ShowDialog() == DialogResult.OK) {
                midocumento.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                midocumento.Print();
            }
        }

        private void DocumentToPrint_PrintPage(object sender, PrintPageEventArgs e) {
            StringReader lector = new StringReader(rtbEditor.Text);
            float LineasPorPagina = 0;
            float posicion = 0;
            int Cuenta = 0;
            float MargenIzq = e.MarginBounds.Left;
            float MargenSup = e.MarginBounds.Top;
            string Linea = null;
            Font ImprimeFuente = this.rtbEditor.Font;
            SolidBrush ImprimeBrocha = new SolidBrush(Color.Black);
            LineasPorPagina = e.MarginBounds.Height / ImprimeFuente.GetHeight(e.Graphics);
            while(Cuenta < LineasPorPagina && ((Linea = lector.ReadLine()) != null)) {
                posicion = MargenSup + (Cuenta * ImprimeFuente.GetHeight(e.Graphics));
                e.Graphics.DrawString(Linea, ImprimeFuente, ImprimeBrocha, MargenIzq, posicion, new StringFormat());
                Cuenta++;
            }
            if(Linea != null) {
                e.HasMorePages = true;
            } else {
                e.HasMorePages = false;
            }
            ImprimeBrocha.Dispose();
        }


        private void itQuitarFormatos_Click(object sender, EventArgs e) {
            itIzq.Checked = true;
            tsbIzq.Checked = true;
            tsbNegrita.Checked = false;
            tsbCursiva.Checked = false;
            tsbSubrayado.Checked = false;
            tsbTachado.Checked = false;

            tsbCopiarFormato.Checked = false;
            FontStyle estilo = new FontStyle();
            rtbEditor.SelectionFont = new Font("Arial", 10, estilo);
            rtbEditor.SelectionColor = Color.Black;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;

            cbxFuente.SelectedIndex = cbxFuente.Items.IndexOf("Arial");
            cbxTamanyo.Text = "10";
            rtbEditor.BackColor = Color.White;

            rtbEditor.SelectionRightIndent = 0;
            rtbEditor.SelectionIndent = 0;
            rtbEditor.SelectionBullet = false;
            itVinyetas.Checked = false;
        }

        private void tsbColores_Click(object sender, EventArgs e) {
            dlgColores.Color = rtbEditor.SelectionColor;
            if (dlgColores.ShowDialog() == DialogResult.OK) {
                rtbEditor.SelectionColor = dlgColores.Color;
            }
            rtbEditor.Modified = true;
        }

        private void tsbCortar_Click(object sender, EventArgs e) {
            // Hecho en el anterior
        }

        private void tsbCopiar_Click(object sender, EventArgs e) {
            // Hecho en el anterior
        }

        private void tsbPegar_Click(object sender, EventArgs e) {
            // Hecho en el anterior
        }

        private void tsbDeshacer_Click(object sender, EventArgs e) {
            // Hecho en el anterior
        }

        private void tsbRehacer_Click(object sender, EventArgs e) {
            // Hecho en el anterior
        }

        private void itBorrar_Click(object sender, EventArgs e) {
            if (rtbEditor.SelectionLength > 0) {
                rtbEditor.SelectedText = "";
            }
        }

        private void itSeleccionarTodo_Click(object sender, EventArgs e) {
            rtbEditor.SelectAll();
        }

        private void itIrA_Click(object sender, EventArgs e) {
            datos.laTitulo.Text = "Ir a";
            datos.laDato.Text = "Ir a";
            if (datos.ShowDialog() == DialogResult.OK) {
                int lineasTotal = rtbEditor.Lines.Count<string>();
                int caracteresTotal = 0;
                
                for (int i = 0; i<lineasTotal;i++) {
                    caracteresTotal += (rtbEditor.Lines[i].Length + 1);
                }

                int lineaSelect = Convert.ToInt32(datos.tbDato.Text);
                if (lineaSelect > caracteresTotal) {
                    lineaSelect = caracteresTotal;
                }

                rtbEditor.SelectionStart = lineaSelect;
            }
        }

        private void itFuentes_Click(object sender, EventArgs e) {
            dlgFuentes.Font = rtbEditor.SelectionFont;
            dlgFuentes.Color = rtbEditor.SelectionColor;

            if (dlgFuentes.ShowDialog() == DialogResult.OK) {
                rtbEditor.SelectionColor = dlgFuentes.Color;
                rtbEditor.SelectionFont = dlgFuentes.Font;
                cbxFuente.SelectedIndex = cbxFuente.Items.IndexOf(rtbEditor.SelectionFont.Name);
            }
        }

        private void itColorFondo_Click(object sender, EventArgs e) {
            dlgColores.Color = rtbEditor.BackColor;
            if (dlgColores.ShowDialog() == DialogResult.OK) {
                rtbEditor.BackColor = dlgColores.Color;
                rtbEditor.Modified = true;
            }
        }

        private void itMargenes_Click(object sender, EventArgs e) {
            fmMargenes margenes = new fmMargenes();

            margenes.cbIzquierda.Text = Convert.ToString(rtbEditor.SelectionIndent);
            margenes.cbDerecha.Text = Convert.ToString(rtbEditor.SelectionRightIndent);
            if (margenes.ShowDialog() == DialogResult.OK) {
                rtbEditor.SelectionIndent = Convert.ToInt32(margenes.cbIzquierda.Text);
                rtbEditor.SelectionRightIndent = Convert.ToInt32(margenes.cbDerecha.Text);
            }
        }

        private void itFormatoPagina_Click(object sender, EventArgs e) {
            dlgFuentes.Font = rtbEditor.Font;
            dlgFuentes.Color = rtbEditor.ForeColor;
            if(dlgFuentes.ShowDialog() == DialogResult.OK) {
                rtbEditor.ForeColor = dlgFuentes.Color;
                rtbEditor.Font = dlgFuentes.Font;
                cbxFuente.SelectedIndex = cbxFuente.Items.IndexOf(rtbEditor.Font.Name);
            }
        }

        private void itBarraHerEstandar_Click(object sender, EventArgs e) {
            tsBarraEstandar.Visible = !tsBarraEstandar.Visible;
            itcBarraEstandar.Checked = !itcBarraEstandar.Checked;
            itBarraHerEstandar.Checked = itcBarraEstandar.Checked;
        }

        private void itBarraHerFormato_Click(object sender, EventArgs e) {

            tsBarraFormato.Visible = !tsBarraFormato.Visible;
            itcBarraFormato.Checked = !itcBarraFormato.Checked;
            itBarraHerFormato.Checked = itcBarraFormato.Checked;
        }

        private void itBarraEstado_Click(object sender, EventArgs e) {
            stEstadoEditor.Visible = !stEstadoEditor.Visible;
            itcBarraEstado.Checked = !itcBarraEstado.Checked;
            itBarraEstado.Checked = itcBarraEstado.Checked;
        }

        private void rtbEditor_SelectionChanged(object sender, EventArgs e) {
            //Si se borra el texto modificado los valores de los controles no cambian.
            //Hay que ponerlos con los valores del parrafo actual
            try {
                cbxTamanyo.Text = Convert.ToString(Math.Truncate(rtbEditor.SelectionFont.Size));
                itVinyetas.Checked = rtbEditor.SelectionBullet;
                tsbNegrita.Checked = rtbEditor.SelectionFont.Bold;
                tsbSubrayado.Checked = rtbEditor.SelectionFont.Underline;
                tsbTachado.Checked = rtbEditor.SelectionFont.Strikeout;
                tsbCursiva.Checked = rtbEditor.SelectionFont.Italic;
                cbxFuente.SelectedIndex = cbxFuente.Items.IndexOf(rtbEditor.SelectionFont.Name);
            } catch {
                return;

            }

            tsbIzq.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Left;
            tsbDer.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Right;
            tsbCentrado.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Center;
            itIzq.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Left;
            itDer.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Right;
            itCentrado.Checked = rtbEditor.SelectionAlignment == HorizontalAlignment.Center;
        }

        private void fmEditor_FormClosing(object sender, FormClosingEventArgs e) {
            if(rtbEditor.Modified && rtbEditor.Lines.Length > 0) {
                DialogResult resultado =
                    MessageBox.Show("¿Guardar cambios?", "Hay cambios pendientes de Guardar", MessageBoxButtons.YesNoCancel);

                switch(resultado) {
                    case DialogResult.Yes:
                        itGuardar.PerformClick();
                        break;

                    case DialogResult.Cancel:
                        e.Cancel = true;
                        rtbEditor.Focus();
                        
                        return;
                }
            }
        }

        private void tsbCopiarFormato_Click(object sender, EventArgs e) {
            stEstadoEditor.Items[0].Text = "Comprobar";

            miestilo = rtbEditor.SelectionFont.Style;
            mifuente = rtbEditor.SelectionFont.Name;
            micolor = rtbEditor.SelectionColor;
            mitamanyo = rtbEditor.SelectionFont.Size;



        }

        private void tsbQuitarFormato_Click(object sender, EventArgs e) {
            itIzq.Checked = true;
            tsbIzq.Checked = true;
            tsbNegrita.Checked = false;
            tsbCursiva.Checked = false;
            tsbSubrayado.Checked = false;
            tsbTachado.Checked = false;

            tsbCopiarFormato.Checked = false;
            FontStyle estilo = new FontStyle();
            rtbEditor.SelectionFont = new Font("Arial", 10, estilo);
            rtbEditor.SelectionColor = Color.Black;
            rtbEditor.SelectionAlignment = HorizontalAlignment.Left;

            cbxFuente.SelectedIndex = cbxFuente.Items.IndexOf("Arial");
            cbxTamanyo.Text = "10";
            rtbEditor.BackColor = Color.White;

            rtbEditor.SelectionRightIndent = 0;
            rtbEditor.SelectionIndent = 0;
            rtbEditor.SelectionBullet = false;
            itVinyetas.Checked = false;
        }

        private void rtbEditor_MouseDown(object sender, MouseEventArgs e) {
            stEstadoEditor.Items[0].Text = "Comprobar si el botón de copiar formatos";

            if(tsbCopiarFormato.Checked) {
                rtbEditor.SelectionFont = new Font(mifuente, mitamanyo, miestilo);
                rtbEditor.SelectionColor = micolor;
            }
        }

        private void itAcercaDe_Click(object sender, EventArgs e) {

            VentanaAcercade = new fmAcercade();
            VentanaAcercade.ShowDialog();

            VentanaAcercade.Dispose();
        }

        private void itAyudaGeneral_Click(object sender, EventArgs e) {
            Help.ShowHelp(this, @"Ayuda.chm");
        }

        private void itIndiceAyuda_Click(object sender, EventArgs e) {
            Help.ShowHelpIndex(this, @"Ayuda.chm");
        }
    }
}