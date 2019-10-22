using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04ArrastarSoltar {
    public partial class Form1 : Form {
        fmAcercade VentanaAcerca;


        public Form1() {
            InitializeComponent();
        }

        private void btAcercade_Click(object sender, EventArgs e) {
            VentanaAcerca = new fmAcercade();
            VentanaAcerca.ShowDialog();
            VentanaAcerca.Dispose();
        }

        private void btSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void lb1_DragDrop(object sender, DragEventArgs e) {
            ListBox milistbox = (ListBox)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) { // Devuelve true si el objeto arrastrado es archivo
                string[] ficheros = (string[])e.Data.GetData(DataFormats.FileDrop, false); // Obtiene lista de fichero arrastrado
                foreach (var fichero in ficheros) {
                    StreamReader miarchivo = new StreamReader(fichero, Encoding.Default);
                    while(miarchivo.Peek() >= 0) { // Comprueba la siguiente linea del archivo, devuelve -1 si es el final
                        milistbox.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                    }
                    miarchivo.Close();
                }
            } else {
                if (e.Data.GetDataPresent(DataFormats.Text)) {
                    if (sender == lb1 && lb2.SelectedIndex > -1) {
                        anyadeListBox(lb1, lb2);
                        borralistbox(lb2);
                    }
                    if (sender == lb2 && lb1.SelectedIndex > -1) {
                        anyadeListBox(lb2, lb1);
                        borralistbox(lb1);
                    }
                }

            }
        }

        private void lb2_DragEnter(object sender, DragEventArgs e) {
            // Averiguamos si es un archivo arrastrado o un String
            if (e.Data.GetDataPresent(DataFormats.FileDrop) || (e.Data.GetDataPresent(DataFormats.Text))) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lb1_MouseDown(object sender, MouseEventArgs e) {

        }

        private void lb2_MouseDown(object sender, MouseEventArgs e) {

        }

        private void ckOrdena1_CheckedChanged(object sender, EventArgs e) {
            lb1.Sorted = ckOrdena1.Checked;
        }

        private void ckOrdena2_CheckedChanged(object sender, EventArgs e) {
            lb2.Sorted = ckOrdena2.Checked;
        }

        private void btBorrar1_Click(object sender, EventArgs e) {
            lb1.Items.Clear();
        }

        private void btBorrar2_Click(object sender, EventArgs e) {
            lb2.Items.Clear();
        }

        private void borralistbox(ListBox lbBorra) {
            /*
            ListBox.SelectedObjectCollection seleccionados = lb.SelectedItems;
            lb.Items.Remove(seleccionados);
            */
            int i = 0;
            while (i < lbBorra.Items.Count) {
                if (lbBorra.GetSelected(i)) {
                    lbBorra.Items.RemoveAt(i);
                } else {
                    i++;
                }
            }
        }

        private void anyadeListBox(ListBox lbAcopla, ListBox lbArrastra) {
            /*
            ListBox.SelectedObjectCollection seleccionados = lb2.SelectedItems;
            lb1.Items.Add(seleccionados);
            */
            int i;
            for (i = 0; i < lbArrastra.Items.Count; i++) {
                if (lbArrastra.GetSelected(i)) {
                    lbAcopla.Items.Add(lbArrastra.Items[i]);
                }
            }
        }

        private void lb2_MouseDown_1(object sender, MouseEventArgs e) {
            
        }

        private void lb2_MouseUp(object sender, MouseEventArgs e) {
            

        }

        private void lb1_MouseClick(object sender, MouseEventArgs e) {
            
        }

        private void lb1_MouseMove(object sender, MouseEventArgs e) {
            
        }

        private void lb1_SelectedValueChanged(object sender, EventArgs e) {
            
        }
    }
}
