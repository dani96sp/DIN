using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Datoss {
    public partial class fmAutomatico : Form {
        bool edicion = false;

        public fmAutomatico() {
            InitializeComponent();
        }

        private void teléfonosBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            try {
                this.Validate();
                this.teléfonosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);
                bindingNavigatorAddNewItem.Enabled = true;
            } catch(ConstraintException ex) {
                MessageBox.Show(ex.Message);
            }
            edicion = false;
        }

        private void fmAutomatico_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'bd_telefonosDataSet.teléfonos' Puede moverla o quitarla según sea necesario.
              this.teléfonosTableAdapter.Fill(this.bd_telefonosDataSet.teléfonos);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {
            if (bd_telefonosDataSet.HasChanges()) {
                teléfonosTableAdapter.Update(bd_telefonosDataSet.teléfonos);
            }
            DataTable mitabla = bd_telefonosDataSet.teléfonos;
            DataRowCollection cfilas = mitabla.Rows;
            DataRow Fila;
            Fila = mitabla.Rows[mitabla.Rows.Count - 1];
            int nuevoid = Convert.ToInt32(Fila[0]);
            nuevoid++;
            try {
                idTextBox.Text = Convert.ToString(nuevoid);
            } catch(ConstraintException ex) {
                MessageBox.Show(ex.Message);
            }
            bindingNavigatorAddNewItem.Enabled = false;
            nombreTextBox.Focus();
            edicion = true;
        }

        /*
        private void btPrimero_Click(object sender, EventArgs e) {
            teléfonosBindingSource.MoveFirst();
        }

        private void btAnterior_Click(object sender, EventArgs e) {
            teléfonosBindingSource.MovePrevious();
        }

        private void btSiguiente_Click(object sender, EventArgs e) {
            teléfonosBindingSource.MoveNext();
        }

        private void btUltimo_Click(object sender, EventArgs e) {
            teléfonosBindingSource.MoveLast();
        }

        private void btGuardar_Click(object sender, EventArgs e) {
            try {
                teléfonosTableAdapter.Update(bd_telefonosDataSet.teléfonos);
                MessageBox.Show("Origen de datos actualizado");
            } catch(Exception errorEncontrado) {
                MessageBox.Show("Ha habido un error:", errorEncontrado.Message);
            }
        }

        private void btNuevo_Click_1(object sender, EventArgs e) {
            DataTable miTabla = bd_telefonosDataSet.teléfonos;
            cfilas = miTabla.Rows;
            DataRow Fila;
            Fila = miTabla.Rows[miTabla.Rows.Count - 1];
            int nuevoid = Convert.ToInt32(Fila[0]);
            nuevoid++;
            try {
                Fila = miTabla.NewRow(); //nueva fila
                Fila[0] = nuevoid;//columna 0
                cfilas.Add(Fila);
                btUltimo.PerformClick();//hacer click en ultimo
            } catch(ConstraintException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btBorrar_Click(object sender, EventArgs e) {
            DataRowView visitaFilaActual;
            if(MessageBox.Show("¿Desea borrar este registro?", "Buscar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                visitaFilaActual = ((DataRowView)teléfonosBindingSource.Current);
                visitaFilaActual.Row.Delete();
            }
        }

        */

        private void fmAutomatico_FormClosing(object sender, FormClosingEventArgs e) {
            //Si estas escribiendo datos y das a cerrar te salta un mensaje de error preguntandote si guardar
            if(edicion) {
                if(MessageBox.Show("¿Desea guardar los cambios?", "Buscar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                    try {
                        teléfonosBindingNavigatorSaveItem_Click(sender, e);
                    } catch(Exception errorEncontrado) {
                        MessageBox.Show("Ha habido un error:", errorEncontrado.Message);
                    }
                }
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {
            bindingNavigatorAddNewItem.Enabled = true;
            edicion = false;
        }

        private void observacionesTextBox_Click(object sender, EventArgs e) {
            edicion = true;

        }
    }
}
