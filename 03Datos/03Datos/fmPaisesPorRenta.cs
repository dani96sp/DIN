using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03Datos {

    public partial class fmPaisesPorRenta : Form {
        public fmPaisesPorRenta() {
            InitializeComponent();
        }


        private void mostrarLista(string sentenciasql) {
            OleDbDataAdapter adaptador = new OleDbDataAdapter(sentenciasql, fmPrincipal.conexion);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];

            lvDatos.Items.Clear();
            for(int i = 0; i < tabla.Rows.Count; i++) {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem((i+1).ToString());
                elementos.SubItems.Add(filas["nombre"].ToString());
                string pib = filas["pib"].ToString();
                string poblacion = filas["poblacion"].ToString();
                double pib2 = Convert.ToInt32(pib);
                double poblacion2 = Convert.ToInt32(poblacion);

                double rentacap = Math.Round(pib2 * 1000000 / poblacion2);
                elementos.SubItems.Add(rentacap.ToString());
                lvDatos.Items.Add(elementos);
            }


        }

        private void button1_Click(object sender, EventArgs e) {
            string sentenciasql = "Select * from paises order by (pib * 1000000 / poblacion) DESC";
            mostrarLista(sentenciasql);
        }

        private void btMostrar2_Click(object sender, EventArgs e) {
            string sentenciasql = "Select nombre, round(pib * 1000000 / poblacion) " +
                "as rentacapita, pib, poblacion from paises where pib > 0 order by 2 DESC";
            mostrarLista(sentenciasql);
        }
    }
}
