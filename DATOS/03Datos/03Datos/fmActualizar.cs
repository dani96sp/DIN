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
    public partial class fmActualizar : Form {
        public fmActualizar() {
            InitializeComponent();
        }


        public void Ponercontinentes() {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT DISTINCT continente FROM paises", fmPrincipal.conexion);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];

            cbContinentes.Items.Clear();

            for(int i = 0; i < tabla.Rows.Count; i++) {
                DataRow filas = tabla.Rows[i];
                
                cbContinentes.Items.Add(filas["continente"].ToString());
            }
            cbContinentes.SelectedIndex = 0;
        }

        private void btAceptar_Click(object sender, EventArgs e) {
            if (tbNombrePais.Text.Equals("")) {
                MessageBox.Show("Inserte al menos un nombre de pais");
                return;
            }
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e) {

            DialogResult = DialogResult.Cancel;
        }

        private void tbPoblacion_KeyPress(object sender, KeyPressEventArgs e) {
            if(e.KeyChar == (Char)13) {
                btAceptar.PerformClick();
            }

            switch(e.KeyChar) {
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
                case '0': break;
                default:
                    e.KeyChar = (char)0;
                    break;
            }
        }
    }
       
}
