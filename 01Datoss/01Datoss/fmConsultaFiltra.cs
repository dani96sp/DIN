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
    public partial class fmConsultaFiltra : Form {
            string filtro = "";
        public fmConsultaFiltra() {
            InitializeComponent();
            cbLetras.SelectedIndex = 0;
            cbProvincias.SelectedIndex = 0;
        }

        private void teléfonosBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.teléfonosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd_telefonosDataSet);

        }

        private void fmConsultaFiltra_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'bd_telefonosDataSet.teléfonos' Puede moverla o quitarla según sea necesario.
            this.teléfonosTableAdapter.Fill(this.bd_telefonosDataSet.teléfonos);

        }

        private void ckAscendente_CheckedChanged(object sender, EventArgs e) {
            string filtro = "";
            if (rbNombre.Checked) {
                filtro = filtro + "Nombre ";
            }
            if (rbCodigo.Checked) {
                filtro = filtro + "Id ";
            }
            if (ckAscendente.Checked) {
                teléfonosBindingSource.Sort = filtro + " ASC";
            } else {
                teléfonosBindingSource.Sort = filtro + " DESC";
            }

        }

        private void btBuscarNombre_Click(object sender, EventArgs e) {
            if (tbBuscar.Text != "") {
                teléfonosBindingSource.Position = teléfonosBindingSource.Find("Nombre", tbBuscar.Text);
            }
        }

        private void ckFiltrarProvincia_CheckedChanged(object sender, EventArgs e) {
            //TODO
            if (ckFiltrarProvincia.Checked) {
                filtro = "Provincia = '" + cbProvincias.Text + "'";
                if (ckFiltrarLetra.Checked) {
                    filtro = filtro + " AND Nombre like '" + cbLetras.Text + "%'";
                }
                teléfonosBindingSource.Filter = filtro;

            } else {
                teléfonosBindingSource.Filter = filtro;
            }
        }

        private void ckFiltrarLetra_CheckedChanged(object sender, EventArgs e) {
            string orden = "";
            orden = "Nombre like '" + cbLetras.Text + "%'";
            //TODO
            if(ckFiltrarLetra.Checked) {
                filtro = orden;
                if(ckFiltrarProvincia.Checked) {
                    filtro = filtro + " AND Nombre like '" + cbLetras.Text + "%'";
                }
                teléfonosBindingSource.Filter = filtro;
            } else {
                teléfonosBindingSource.Filter = filtro;
            }
        }

    }
}
