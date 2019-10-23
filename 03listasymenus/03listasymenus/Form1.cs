using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace _03listasymenus {
    public partial class Form1 : Form {
        fmAcercade VentanaAcerca;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            cbCursos.SelectedIndex = 0;
            btAbrir.PerformClick();
            lbAlumnos.SelectedIndex = 0;
        }

        private void lbAlumnos_SelectedIndexChanged(object sender, EventArgs e) {
            
        }

        private void btMostrarMas_Click(object sender, EventArgs e) {
            if (lbAlumnos.SelectedIndex != -1) {
                MessageBox.Show("El seleccionado es: " + lbAlumnos.Items[lbAlumnos.SelectedIndex].ToString()
                    + " y ocupa la posición " + (lbAlumnos.SelectedIndex + 1));
            }

        }

        private void btMostrarTodos_Click(object sender, EventArgs e) {
            string todos = "";
            foreach (ListBox lb in lbAlumnos.Items) {
                //todos = todos + lb.ToString() + "\n";
            }
        }

        private void btNuevo_Click(object sender, EventArgs e) {
            lbAlumnos.Items.Clear();
            
        }

        private void btGuardar_Click(object sender, EventArgs e) {
            try {
                StreamWriter miarchivo = new StreamWriter(@".\cursos\" + cbCursos.Text + ".txt");
                foreach(object lista in lbAlumnos.Items) {
                    miarchivo.WriteLine(lista.ToString());
                }
                miarchivo.Close();
                
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }
        }

        private void btAbrir_Click(object sender, EventArgs e) {
            lbAlumnos.Items.Clear();
            try {
                StreamReader miarchivo = new StreamReader(@".\cursos\" + cbCursos.Text + ".txt");
                while (miarchivo.Peek() >= 0) { // Comprueba la siguient elinea del archivo y devuelve -1 cuando sea el final
                    lbAlumnos.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                }
                miarchivo.Close();
            } catch (Exception error) {
                MessageBox.Show(error.Message);
            }

        }

        private void btSalir_Click(object sender, EventArgs e) {
            // Cerramos la ventana
            Close();
        }

        private void btUp_Click(object sender, EventArgs e) {
            object abajo = lbAlumnos.SelectedItem;
            int indice = lbAlumnos.SelectedIndex;
            if (indice > 0) {
                object arriba = lbAlumnos.Items[indice - 1];
                lbAlumnos.Items[indice] = arriba;
                lbAlumnos.Items[indice - 1] = abajo;
                lbAlumnos.SelectedIndex = indice - 1;
            }
        }

        private void btDown_Click(object sender, EventArgs e) {
            object arriba = lbAlumnos.SelectedItem;
            int indice = lbAlumnos.SelectedIndex;
            if (lbAlumnos.Items.Count != indice+1) {
                object abajo = lbAlumnos.Items[indice + 1];
                lbAlumnos.Items[indice] = abajo;
                lbAlumnos.Items[indice+1] = arriba;
                lbAlumnos.SelectedIndex = indice + 1;
            }
        }

        private void btActualizar_Click(object sender, EventArgs e) {
            tbAlumno.Enabled = !tbAlumno.Enabled;
            laNuevo.Enabled = !laNuevo.Enabled;

            pnActualiza.Visible = !pnActualiza.Visible;


        }

        private void btOrdenar_Click(object sender, EventArgs e) {
            lbAlumnos.Sorted = true;
            lbAlumnos.Sorted = false;
        }

        private void btAnyadir_Click(object sender, EventArgs e) {
            string nuevo = tbAlumno.Text;
            if (nuevo.Equals("")) {
                MessageBox.Show("Introduzca un nombre primero.");
                
            } else {
                if (lbAlumnos.Items.IndexOf(nuevo) != -1) {
                    MessageBox.Show("El nombre ya existe");
                    
                } else {
                    lbAlumnos.Items.Add(nuevo);
                    
                }
            }
            tbAlumno.SelectAll();
            tbAlumno.Focus();

        }

        private void btInsertar_Click(object sender, EventArgs e) {
            if (tbAlumno.Text == "") {
                MessageBox.Show("Introduzca un nombre del nuevo Alumno");
            } else {
                if (lbAlumnos.SelectedIndex == -1) {
                    MessageBox.Show("Seleccione la posición donde insertar al alumno");
                } else {
                    if (lbAlumnos.Items.IndexOf(tbAlumno.Text) == -1) {
                        lbAlumnos.Items.Insert(lbAlumnos.SelectedIndex, tbAlumno.Text);
                    } else {
                        MessageBox.Show("El alumno ya existe");
                    }
                }
            }
            tbAlumno.SelectAll();
            tbAlumno.Focus();
        }

        private void btBorrar_Click(object sender, EventArgs e) {
            if (lbAlumnos.SelectedIndex == -1) {
                MessageBox.Show("Seleccione a un alumno");
            } else {
                lbAlumnos.Items.Remove(lbAlumnos.SelectedItem);
            }
        }

        private void btBuscar_Click(object sender, EventArgs e) {
            int indice = lbAlumnos.Items.IndexOf(tbAlumno.Text);
            if (tbAlumno.Text == "") {
                MessageBox.Show("Introduzca un nombre del Alumno a buscar");
            } else {
                if (indice == -1) {
                    MessageBox.Show("No se ha encontrado el alumno");
                } else {
                    lbAlumnos.SelectedItem = lbAlumnos.Items[indice];
                }
            }
            tbAlumno.Focus();
        }

        private void cms1_Opening(object sender, CancelEventArgs e) {
            if (lbAlumnos.SelectedIndex == -1) {
                tsmiEliminar.Enabled = false;
            } else {
                tsmiEliminar.Enabled = true;
            }
        }

        private void tbAlumno_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (char) 13) {
                btAnyadir.PerformClick();
            }
        }

        private void cbCursos_TextChanged(object sender, EventArgs e) {
            btAbrir.PerformClick();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e) {
            VentanaAcerca = new fmAcercade();
            VentanaAcerca.ShowDialog();
            VentanaAcerca.Dispose();

        }
    }
}
