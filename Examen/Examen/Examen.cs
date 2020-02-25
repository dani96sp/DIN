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

namespace Examen {
    public partial class Examen : Form {
        fmAcercade VentanaAcerca;

        public Examen() {
            InitializeComponent();
        }

        private void btAcercaDe_Click(object sender, EventArgs e) {
            VentanaAcerca = new fmAcercade();
            VentanaAcerca.ShowDialog();
            VentanaAcerca.Dispose();
        }

        private void btSalir_Click(object sender, EventArgs e) {
            Close();
        }

        private void Examen_Load(object sender, EventArgs e) {
            // Cargamos los elementos de las listas a partir de los archivos
            cbAlmacenesPrincipales.SelectedIndex = 0;
            cbAlmacenesPrincipales_SelectedIndexChanged(sender, e);
            cbAlmacenesSecundarios.SelectedIndex = 0;
            cbAlmacenesSecundarios_SelectedIndexChanged(sender, e);


        }

        private void cbAlmacenesPrincipales_SelectedIndexChanged(object sender, EventArgs e) {
            lbAlmacenesPrincipales.Items.Clear();
            try {
                StreamReader miarchivo = new StreamReader(@".\AlmacenesPrincipales\" + cbAlmacenesPrincipales.Text + ".txt");
                while(miarchivo.Peek() >= 0) { // Comprueba la siguient elinea del archivo y devuelve -1 cuando sea el final
                    lbAlmacenesPrincipales.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                }
                miarchivo.Close();
            } catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void cbAlmacenesSecundarios_SelectedIndexChanged(object sender, EventArgs e) {
            lbAlmacenesSecundarios.Items.Clear();
            try {
                StreamReader miarchivo = new StreamReader(@".\AlmacenesSecundarios\" + cbAlmacenesSecundarios.Text + ".txt");
                while(miarchivo.Peek() >= 0) { // Comprueba la siguient elinea del archivo y devuelve -1 cuando sea el final
                    lbAlmacenesSecundarios.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                }
                miarchivo.Close();
            } catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void lbAlmacenesPrincipales_SelectedIndexChanged(object sender, EventArgs e) {
            if (lbAlmacenesPrincipales.SelectedIndices.Count > 0) {
                btEliminarPrincipal.Enabled = true;
            } else {
                btEliminarPrincipal.Enabled = false;
            }
        }

        private void lbAlmacenesSecundarios_SelectedIndexChanged(object sender, EventArgs e) {
            if(lbAlmacenesSecundarios.SelectedIndices.Count > 0) {
                btEliminarSecundarios.Enabled = true;
            } else {
                btEliminarSecundarios.Enabled = false;
            }
        }

        private void btAnyadirPrincipal_Click(object sender, EventArgs e) {
            if (lbAlmacenesPrincipales.Items.Contains(tbNuevoPrincipal.Text)) {
                MessageBox.Show("Ya existe el elemento en la lista");
            } else {
                lbAlmacenesPrincipales.Items.Add(tbNuevoPrincipal.Text);
            }

        }

        private void tbNuevoPrincipal_KeyPress(object sender, KeyPressEventArgs e) {
            btAnyadirPrincipal.Enabled = tbNuevoPrincipal.Text != "";

            if(e.KeyChar == (char)13) {
                if(tbNuevoPrincipal.Text == "") {
                    MessageBox.Show("Debe de escribir algo.");
                } else {
                   btAnyadirPrincipal.PerformClick();
                }
            }
        }

        private void btAnyadirSecundarios_Click(object sender, EventArgs e) {
            if(lbAlmacenesSecundarios.Items.Contains(tbNuevoPrincipal.Text)) {
                MessageBox.Show("Ya existe el elemento en la lista");
            } else {
                lbAlmacenesSecundarios.Items.Add(tbNuevoSecundario.Text);
            }
        }

        private void tbNuevoSecundario_KeyPress(object sender, KeyPressEventArgs e) {
            if(tbNuevoSecundario.Text != "") {
                btAnyadirSecundarios.Enabled = true;
            } else {
                btAnyadirSecundarios.Enabled = false;
            }
            if(e.KeyChar == (char)13) {
                if(tbNuevoSecundario.Text == "") {
                    MessageBox.Show("Debe de escribir algo.");
                } else {
                    btAnyadirSecundarios.PerformClick();
                }
            }
        }

        private void btEliminarPrincipal_Click(object sender, EventArgs e) {
            int i = 0;
            while(i < lbAlmacenesPrincipales.Items.Count) {
                if(lbAlmacenesPrincipales.GetSelected(i)) {
                    lbAlmacenesPrincipales.Items.RemoveAt(i);
                } else {
                    i++;
                }
            }
        }

        private void btDerechaSel_Click(object sender, EventArgs e) {
            int i;
            for(i = 0; i < lbAlmacenesPrincipales.Items.Count; i++) {
                if(lbAlmacenesPrincipales.GetSelected(i)) {
                    lbAlmacenesSecundarios.Items.Add(lbAlmacenesPrincipales.Items[i]);
                }
            }
            btEliminarPrincipal.PerformClick();
        }

        private void btEliminarSecundarios_Click(object sender, EventArgs e) {
            int i = 0;
            while(i < lbAlmacenesSecundarios.Items.Count) {
                if(lbAlmacenesSecundarios.GetSelected(i)) {
                    lbAlmacenesSecundarios.Items.RemoveAt(i);
                } else {
                    i++;
                }
            }
        }

        private void btIzquierdaSel_Click(object sender, EventArgs e) {
            int i;
            for(i = 0; i < lbAlmacenesSecundarios.Items.Count; i++) {
                if(lbAlmacenesSecundarios.GetSelected(i)) {
                    lbAlmacenesPrincipales.Items.Add(lbAlmacenesSecundarios.Items[i]);
                }
            }
            btEliminarSecundarios.PerformClick();
        }

        private void btDerechaTodos_Click(object sender, EventArgs e) {
            int i;
            for(i = 0; i < lbAlmacenesPrincipales.Items.Count; i++) {
                lbAlmacenesSecundarios.Items.Add(lbAlmacenesPrincipales.Items[i]);
            }
            lbAlmacenesPrincipales.Items.Clear();
        }

        private void btIzquierdaTodos_Click(object sender, EventArgs e) {
            int i;
            for(i = 0; i < lbAlmacenesSecundarios.Items.Count; i++) {
                lbAlmacenesPrincipales.Items.Add(lbAlmacenesSecundarios.Items[i]);
            }
            lbAlmacenesSecundarios.Items.Clear();
        }

        private void btGuardarPrincipal_Click(object sender, EventArgs e) {
            try {
                StreamWriter miarchivo = new StreamWriter(@".\AlmacenesPrincipales\" + cbAlmacenesPrincipales.Text + ".txt");
                foreach(object lista in lbAlmacenesPrincipales.Items) {
                    miarchivo.WriteLine(lista.ToString());
                }
                miarchivo.Close();

            } catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void btGuardarSecundarios_Click(object sender, EventArgs e) {
            try {
                StreamWriter miarchivo = new StreamWriter(@".\AlmacenesSecundarios\" + cbAlmacenesSecundarios.Text + ".txt");
                foreach(object lista in lbAlmacenesSecundarios.Items) {
                    miarchivo.WriteLine(lista.ToString());
                }
                miarchivo.Close();

            } catch(Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void lbAlmacenesPrincipales_DragDrop(object sender, DragEventArgs e) {
            ListBox milistbox = (ListBox)sender;
            if(e.Data.GetDataPresent(DataFormats.FileDrop)) { // Devuelve true si el objeto arrastrado es archivo
                string[] ficheros = (string[])e.Data.GetData(DataFormats.FileDrop, false); // Obtiene lista de fichero arrastrado
                foreach(var fichero in ficheros) {
                    StreamReader miarchivo = new StreamReader(fichero, Encoding.Default);
                    while(miarchivo.Peek() >= 0) { // Comprueba la siguiente linea del archivo, devuelve -1 si es el final
                        milistbox.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                    }
                    miarchivo.Close();
                }
            } else {
                if(e.Data.GetDataPresent(DataFormats.Text)) {
                    if(sender == lbAlmacenesPrincipales && lbAlmacenesSecundarios.SelectedIndex > -1) {
                        btDerechaSel.PerformClick();
                        btEliminarPrincipal.PerformClick();
                    }
                    if(sender == lbAlmacenesSecundarios && lbAlmacenesPrincipales.SelectedIndex > -1) {
                        btIzquierdaSel.PerformClick();
                        btEliminarSecundarios.PerformClick();
                    }
                }
            }
        }

        private void lbAlmacenesPrincipales_DragEnter(object sender, DragEventArgs e) {
            // Averiguamos si es un archivo arrastrado o un String
            if(e.Data.GetDataPresent(DataFormats.FileDrop) || (e.Data.GetDataPresent(DataFormats.Text))) {
                e.Effect = DragDropEffects.Copy;
            } else {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbAlmacenesPrincipales_MouseDown(object sender, MouseEventArgs e) {
            if(lbAlmacenesPrincipales.SelectedIndex >= 0) {
                lbAlmacenesSecundarios.DoDragDrop(lbAlmacenesPrincipales.SelectedItem, DragDropEffects.All);
            }
        }

        private void lbAlmacenesSecundarios_MouseDown(object sender, MouseEventArgs e) {
            if(lbAlmacenesSecundarios.SelectedIndex >= 0) {
                lbAlmacenesPrincipales.DoDragDrop(lbAlmacenesSecundarios.SelectedItem, DragDropEffects.All);
            }
        }

        private void chkOrdenaPrincipales_CheckedChanged(object sender, EventArgs e) {
            lbAlmacenesPrincipales.Sorted = chkOrdenaPrincipales.Checked;
        }

        private void chkOrdenaSecundarios_CheckedChanged(object sender, EventArgs e) {
            lbAlmacenesSecundarios.Sorted = chkOrdenaSecundarios.Checked;
        }
    }
}
