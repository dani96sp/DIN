using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevoExamen2 {
    public partial class fmExamen : Form {

        fmAcercade VentanaAcercade;
        fmProveedor VentanaProveedor;

        public fmExamen() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'bdexafinDataSet.secciones' Puede moverla o quitarla según sea necesario.
            this.seccionesTableAdapter.Fill(this.bdexafinDataSet.secciones);
            // TODO: esta línea de código carga datos en la tabla 'bdexafinDataSet.articulos' Puede moverla o quitarla según sea necesario.
            this.articulosTableAdapter.Fill(this.bdexafinDataSet.articulos);
        }

        private void articulosDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
            // Recogemos el numero de articulos totales
            int numeroArticulos = articulosDataGridView.Rows.Count;
            // Seteamos el numero de articulos totales al label
            laNumeroArticulosSeccion.Text = "" + numeroArticulos;
            // Corregimos errores para que no se divida por 0 cuando no hay articulos
            if(numeroArticulos == 0) numeroArticulos = 1;
            // Calculamos precio
            int precio = 0;
            foreach(DataGridViewRow item in articulosDataGridView.Rows) {
                precio = precio + Convert.ToInt32(item.Cells[3].Value);
            }
            // Calculamos media de precios
            int mediaprecios = precio / numeroArticulos;
            // Lo ponemos en su label
            laMediaPrecios.Text = "" + mediaprecios;

            laTotalUnidades.Text = "" + totalUnidades();
            laTotalVentas.Text = "" + totalVentas();

        }

        private int calculaPrecio() {
            int precio = 0;
            foreach(DataGridViewRow item in articulosDataGridView.Rows) {
                precio = precio + Convert.ToInt32(item.Cells[3].Value);
            }
            return precio;
        }

        private int totalUnidades() {
            int totalUnidades = 0;
            foreach(DataGridViewRow item in articulosDataGridView.Rows) {
                totalUnidades = totalUnidades + Convert.ToInt32(item.Cells[4].Value);
            }
            return totalUnidades;
        }

        private int totalVentas() {
            int totalVentas = 0;
            foreach(DataGridViewRow item in articulosDataGridView.Rows) {
                totalVentas = totalVentas + Convert.ToInt32(item.Cells[5].Value);
            }
            return totalVentas;
        }

        private void tsAcercaDe_Click(object sender, EventArgs e) {

            VentanaAcercade = new fmAcercade();
            VentanaAcercade.ShowDialog();

            VentanaAcercade.Dispose();
        }

        private void articulosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if(e.ColumnIndex == 6) {

                VentanaProveedor = new fmProveedor();
                VentanaProveedor.codigoproveedor = Convert.ToInt32(articulosDataGridView.Rows[e.RowIndex].Cells[1].Value);
                VentanaProveedor.ShowDialog();
                VentanaProveedor.Dispose();

                    

            }
        }
    }
}
