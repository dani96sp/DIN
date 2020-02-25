using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05MiniEditor {
    public partial class fmMiniEditor : Form {

        fmAcercade VentanaAcercade;

        public fmMiniEditor() {
            InitializeComponent();
        }

        private void FmMiniEditor_Load(object sender, EventArgs e) {
            foreach(FontFamily misfuentes in FontFamily.Families) {
                cbFuente.Items.Add(misfuentes.Name);
            }
            //cbFuente.Text = "Microsoft Sans Serif";
            cbFuente.Text = rtbEditor.Font.Name;
            cbTamanyo.Text = "8";
            //cbTamanyo.Text = rtbEditor.Font.Size.ToString();
            lbColores.SelectedIndex = 6;
        }

        private void CbFuente_TextChanged(object sender, EventArgs e) {
            //recoger estilo y tamaño para completar selectionFont
            FontStyle estilo = new FontStyle();
            estilo = rtbEditor.SelectionFont.Style;
            float tamanyo = rtbEditor.SelectionFont.Size;

            string fuente = cbFuente.Text;
            rtbEditor.SelectionFont = new Font(fuente, tamanyo, estilo);
        }

        private void CbTamanyo_KeyPress(object sender, KeyPressEventArgs e) {
            //Con esto lo que hacemos es que sólo podamos introducir números y la tecla de borrar
            switch(e.KeyChar) {
                //case(char)8 tecla borrar en ASCII
                case (char)8:
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
                //case (char)',':
                default:
                    e.KeyChar = (char)0;//anular pulsación
                    break;
            }

        }

        private void CbTamanyo_TextChanged(object sender, EventArgs e) {
            FontStyle estilo = new FontStyle();
            estilo = rtbEditor.SelectionFont.Style;

            string fuente = rtbEditor.SelectionFont.Name;

            if(cbTamanyo.Text != "") {
                rtbEditor.SelectionFont = new Font(fuente, Convert.ToInt32(cbTamanyo.Text), estilo);
            }
        }

        private void LbColores_SelectedIndexChanged(object sender, EventArgs e) {

            int indice = 0;
            if(sender is ToolStripMenuItem) {
                ToolStripMenuItem elemento = sender as ToolStripMenuItem;
                if (elemento != null) {
                    indice = itColores.DropDownItems.IndexOf(elemento);
                    lbColores.SelectedIndex = indice;
                }
            } else {
                for( int i = 0; i < lbColores.Items.Count; i++) {
                    ((ToolStripMenuItem)itColores.DropDownItems[i]).Checked = false;
                }
                indice = lbColores.SelectedIndex;
            }

            Color micolor = Color.Black;
            switch(lbColores.SelectedIndex) {
                case 0:
                    micolor = Color.Red;
                    break;
                case 1:
                    micolor = Color.Green;
                    break;
                case 2:
                    micolor = Color.Blue;
                    break;
                case 3:
                    micolor = Color.Gray;
                    break;
                case 4:
                    micolor = Color.Orange;
                    break;
                case 5:
                    micolor = Color.Yellow;
                    break;
                case 6:
                    micolor = Color.Black;
                    break;
            }
            rtbEditor.SelectionColor = micolor;
            ((ToolStripMenuItem)itColores.DropDownItems[indice]).Checked = true;

        }

        private void CkNegrita_CheckedChanged(object sender, EventArgs e) {
            FontStyle negrita = new FontStyle();
            FontStyle subrayado = new FontStyle();
            FontStyle tachado = new FontStyle();
            FontStyle cursiva = new FontStyle();

            if(ckNegrita.Checked) {
                negrita = FontStyle.Bold;
            }
            if(ckSubrayado.Checked) {
                subrayado = FontStyle.Underline;
            }
            if(ckTachado.Checked) {
                tachado = FontStyle.Strikeout;
            }
            if(ckCursiva.Checked) {
                cursiva = FontStyle.Italic;
            }

            itNegrita.Checked = ckNegrita.Checked;
            itCursiva.Checked = ckCursiva.Checked;
            itSubrayado.Checked = ckSubrayado.Checked;
            itTachado.Checked = ckTachado.Checked;
            rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, negrita | subrayado | tachado | cursiva);
            rtbEditor.Focus();
        }

        private void RbIzquierda_CheckedChanged(object sender, EventArgs e) {
            if(rbIzquierda.Checked) {
                rtbEditor.SelectionAlignment = HorizontalAlignment.Left;
                itIzquierda.Checked = true;
            }
            if(rbCentrada.Checked) {
                rtbEditor.SelectionAlignment = HorizontalAlignment.Center;
                itCentrada.Checked = true;
            }
            if(rbDerecha.Checked) {
                rtbEditor.SelectionAlignment = HorizontalAlignment.Right;
                itDerecha.Checked = true;
            }

            itIzquierda.Checked = rbIzquierda.Checked;
            itCentrada.Checked = rbCentrada.Checked;
            itDerecha.Checked = rbDerecha.Checked;

            rtbEditor.Focus();
        }

        private void BtAbrir_Click(object sender, EventArgs e) {
            if(tbNombre.Text == "") {
                MessageBox.Show("Pon un nombre");
                tbNombre.Focus();
            } else {
                rtbEditor.Clear();
                try {
                    rtbEditor.LoadFile(@".\archivos\" + tbNombre.Text + ".rtf");
                } catch(Exception error) {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void BtGuardar_Click(object sender, EventArgs e) {
            if(tbNombre.Text == "") {
                MessageBox.Show("Pon un nombre");
                tbNombre.Focus();
            } else {
                try {
                    rtbEditor.SaveFile(@".\archivos\" + tbNombre.Text + ".rtf");
                } catch(Exception error) {
                    MessageBox.Show(error.Message);
                }
                rtbEditor.Clear();
            }

        }

        private void ItNuevo_Click(object sender, EventArgs e) {
            rtbEditor.Clear();
        }

        private void ItSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void ItCortar_Click(object sender, EventArgs e) {
            rtbEditor.Cut();
        }

        private void ItCopiar_Click(object sender, EventArgs e) {
            rtbEditor.Copy();
        }

        private void ItPegar_Click(object sender, EventArgs e) {
            rtbEditor.Paste();
        }

        private void ItVaciarPortapapeles_Click(object sender, EventArgs e) {
            Clipboard.Clear();
        }

        private void ItDeshacer_Click(object sender, EventArgs e) {
            if(rtbEditor.CanUndo) {
                rtbEditor.Undo();
            }
        }

        private void ItRehacer_Click(object sender, EventArgs e) {
            if(rtbEditor.CanRedo) {
                rtbEditor.Redo();
            }
        }

        private void ItIzquierda_Click(object sender, EventArgs e) {
            if(sender == itIzquierda) {
                rbIzquierda.Checked = true;
            } else if(sender == itDerecha) {
                rbDerecha.Checked = true;
            } else if(sender == itCentrada) {
                rbCentrada.Checked = true;
            }
        }

        private void ItNegrita_Click(object sender, EventArgs e) {
            if(sender == itNegrita) {
                ckNegrita.Checked = !ckNegrita.Checked;
            } else if(sender == itCursiva) {
                ckCursiva.Checked = !ckCursiva.Checked;
            } else if(sender == itTachado) {
                ckTachado.Checked = !ckTachado.Checked;
            } else if(sender == itSubrayado) {
                ckSubrayado.Checked = !ckSubrayado.Checked;
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {

            VentanaAcercade = new fmAcercade();
            VentanaAcercade.ShowDialog();

            VentanaAcercade.Dispose();
        }
    }
}
