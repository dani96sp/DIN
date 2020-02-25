using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02Datos {
    public partial class fmMaestroDetalle : Form {

        // Completar el autonumerico en ambas tablas
        // Deshabilitar boton añadir cuando se añada hasta que guardes en ambas tablas
        // Cuando la tabla autor esté en edición, se deshabilita el navigator de libros
        // Al cerrar comprobar que no haya cambios pendientes de ser guardados
        // Para comprobar edicion usar hasChanges() o si no funciona usar una booleana global

        public fmMaestroDetalle() {
            InitializeComponent();
        }


        private void fmMaestroDetalle_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Editorial' Puede moverla o quitarla según sea necesario.
            this.editorialTableAdapter.Fill(this.librosDataSet.Editorial);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.librosDataSet.Libros);
            // TODO: esta línea de código carga datos en la tabla 'librosDataSet.Autor' Puede moverla o quitarla según sea necesario.
            this.autorTableAdapter.Fill(this.librosDataSet.Autor);

        }

        private void bindingNavigatorDeleteItem_MouseDown(object sender, MouseEventArgs e) {
            if (librosDataGridView.Rows.Count>1) {
                MessageBox.Show("Este autor tiene " + librosDataGridView.Rows.Count + " Libros");
                return;
            }
            DialogResult resultado = MessageBox.Show("Seguro que deseas borrar el autor? " + nombreTextBox.Text, "Borrar Datos", MessageBoxButtons.YesNo);
            if (resultado == DialogResult.No) {
                return;
            } else {
                bnvBorrarAutor.PerformClick();
            }
        }

        private void librosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            laTotal.Text = "Total de Libros del Autor: " + nombreTextBox.Text + " " + librosDataGridView.Rows.Count;
        }

        private void fechaImpresionDateTimePicker_ValueChanged(object sender, EventArgs e) {

        }


        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);

            bindingNavigatorAddNewItem1.Enabled = true;
        }

        private void autorBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.autorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.librosDataSet);
        }

        private void librosDataGridView_DoubleClick(object sender, EventArgs e) {
           
        }

        private void librosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            // Fecha impresion
            if (e.ColumnIndex == 6) {
                // Abrimos el calendar

                
            }
        }

        private void bindingNavigatorAddNewItem1_Click(object sender, EventArgs e) {
            DataTable miTabla = librosDataSet.Libros;
            DataRowCollection cfilas = miTabla.Rows;
            DataRow Fila = miTabla.Rows[miTabla.Rows.Count -1];
            int codigomayor = Convert.ToInt32(Fila[0]);
            foreach(DataRow unafila in miTabla.Rows) {
                if (Convert.ToInt32(unafila[0]) > codigomayor) {
                    codigomayor = Convert.ToInt32(unafila[0]);
                }
            }

            codigomayor++;
            try {
                Fila = miTabla.NewRow(); // Nueva fila
                librosDataGridView.CurrentRow.Cells[0].Value = codigomayor;
            } catch(ConstraintException ex) {
                MessageBox.Show(ex.Message);
            }
            bindingNavigatorAddNewItem1.Enabled = false;
        }
    }
}
