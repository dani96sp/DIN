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
    public partial class fmPrincipal : Form {

        public static OleDbConnection conexion;
        fmActualizar VentanaActualizar;
        //fmDato VentanaDato;
        fmAcercade VentanaAcerca;
        fmConsultar VentanaConsulta;
        fmPaisesPorRenta VentanaPaisesRenta;

        public fmPrincipal() {
            InitializeComponent();
        }
        

        private void fmPrincipal_Load(object sender, EventArgs e) {
            string conecta = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\datos\bd_paises.mdb;");
            conexion = new OleDbConnection(conecta);

            try {
                conexion.Open();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
            // VentanaActualizar = new fmActualizar(conexion);
            VentanaActualizar = new fmActualizar();
            // VentanaDato = new fmDato();
            


        }

        private void btMostrar_Click(object sender, EventArgs e) {
            string sentenciasql = "SELECT * FROM paises ORDER by Id";
            mostrarLista(sentenciasql);
        }


        private void btAnyadir_Click(object sender, EventArgs e) {
            string numFilas = "SELECT TOP 1 ID FROM paises ORDER BY ID DESC";
            OleDbCommand comando1 = new OleDbCommand(numFilas, conexion);
            int numfil = (int)comando1.ExecuteScalar();

            VentanaActualizar.tbId.Text = Convert.ToString(numfil + 1);
            VentanaActualizar.tbCapital.Text = "";
            VentanaActualizar.cbContinentes.Text = "";
            VentanaActualizar.tbPIB.Text = "0";
            VentanaActualizar.tbPoblacion.Text = "0";
            VentanaActualizar.tbNombrePais.Text = "";
            VentanaActualizar.Ponercontinentes();

            if(VentanaActualizar.ShowDialog() == DialogResult.OK) {
                string insertar = "INSERT INTO paises(id, nombre, capital, continente, poblacion, pib) ";
                insertar = insertar + "VALUES('" + VentanaActualizar.tbId.Text + "','"
                + VentanaActualizar.tbNombrePais.Text + "','"
                + VentanaActualizar.tbCapital.Text + "','"
                + VentanaActualizar.cbContinentes.Text + "','"
                + VentanaActualizar.tbPoblacion.Text + "','"
                + VentanaActualizar.tbPIB.Text + "')";

                OleDbCommand comando2 = new OleDbCommand(insertar, conexion);

                try {
                    comando2.ExecuteNonQuery();
                } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }
                MessageBox.Show("Datos Guardados correctamente");
                btMostrar.PerformClick();
            }
        }

        private void btModificar_Click(object sender, EventArgs e) {
            if (lvDatos.SelectedItems.Count > 0) {
                ListView.SelectedListViewItemCollection seleccionado = lvDatos.SelectedItems;
                foreach(ListViewItem elemento in seleccionado) {
                    int mid = Convert.ToInt32(elemento.SubItems[0].Text);
                    string consulta = "select * from paises where Id = @mid;";
                    OleDbCommand comando = new OleDbCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@mid", mid);
                    OleDbDataReader lector = comando.ExecuteReader();
                    while(lector.Read()) {
                        VentanaActualizar.Ponercontinentes();
                        VentanaActualizar.tbId.Text = Convert.ToString(lector.GetInt32(0));
                        VentanaActualizar.tbNombrePais.Text = Convert.ToString(lector.GetString(1));
                        VentanaActualizar.tbCapital.Text = Convert.ToString(lector.GetString(2));
                        VentanaActualizar.cbContinentes.Text = Convert.ToString(lector.GetString(3));
                        VentanaActualizar.tbPoblacion.Text = Convert.ToString(lector.GetInt32(4));
                        VentanaActualizar.tbPIB.Text = Convert.ToString(lector.GetInt32(5));

                        if(VentanaActualizar.ShowDialog() == DialogResult.OK) {

                            string modificar = "UPDATE paises SET id = '" + VentanaActualizar.tbId.Text +
                                "', nombre = '" + VentanaActualizar.tbNombrePais.Text +
                                "', capital = '" + VentanaActualizar.tbCapital.Text +
                                "', continente = '" + VentanaActualizar.cbContinentes.Text +
                                "', poblacion = '" + VentanaActualizar.tbPoblacion.Text +
                                "', pib = '" + VentanaActualizar.tbPIB.Text +
                                "' WHERE Id = " + VentanaActualizar.tbId.Text + ";";

                            OleDbCommand comando2 = new OleDbCommand(modificar, conexion);

                            try {
                                comando2.ExecuteNonQuery();
                            } catch(Exception ex) {
                                MessageBox.Show(ex.Message);
                                MessageBox.Show(modificar);
                                return;
                            }
                            MessageBox.Show("Datos Guardados correctamente");
                        }
                    }
                    btMostrar.PerformClick();
                 }
            } else {
                MessageBox.Show("Seleccione un elemento de la lista");
            }
        }

        private void btConsulta_Click(object sender, EventArgs e) {
            VentanaConsulta = new fmConsultar();
            VentanaConsulta.ShowDialog();
        }


        private void btBorrar_Click(object sender, EventArgs e) {
            if(lvDatos.SelectedItems.Count > 0) {
                ListView.SelectedListViewItemCollection seleccionado = lvDatos.SelectedItems;
                foreach(ListViewItem elemento in seleccionado) {
                    int mid = Convert.ToInt32(elemento.SubItems[0].Text);
                    string consulta = "select * from paises where Id = @mid;";
                    OleDbCommand comando = new OleDbCommand(consulta, conexion);
                    comando.Parameters.AddWithValue("@mid", mid);
                    OleDbDataReader lector = comando.ExecuteReader();
                    while(lector.Read()) {
                        DialogResult resulta = MessageBox.Show("Seguro que desea eliminar el pais "
                            + lector.GetString(1) + " con ID: " + Convert.ToString(lector.GetInt32(0)),
                            "Atención, Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (resulta == DialogResult.No) {
                            break;
                        }
                        string idborra = Convert.ToString(lector.GetInt32(0));
                        string borra = "delete from paises where Id = @idborra";

                        OleDbCommand comandoborra = new OleDbCommand(borra, conexion);
                        comandoborra.Parameters.AddWithValue("@idborra", idborra);
                        try {
                            comandoborra.ExecuteNonQuery();
                        } catch(Exception ex) {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show(borra);
                            return;
                        }
                        MessageBox.Show("Pais eliminado correctamente.");
                    }
                    btMostrar.PerformClick();
                }
            } else {
                MessageBox.Show("Seleccione un elemento de la lista");
            }
        }

        private void btCalcula_Click(object sender, EventArgs e) {
            if(lvDatos.Items.Count > 1) {
                ListView.ListViewItemCollection filas = lvDatos.Items;

                foreach(ListViewItem elemento in filas) {
                    int mid = Convert.ToInt32(elemento.SubItems[0].Text);

                    string multiplica = "select pib * 1000000 / poblacion from paises where Id = @mid;";

                    OleDbCommand comando = new OleDbCommand(multiplica, conexion);
                    comando.Parameters.AddWithValue("@mid", mid);
                    double rentacap = (double)comando.ExecuteScalar();
                    elemento.SubItems[6].Text = rentacap.ToString("######");
                }
            } else {
                MessageBox.Show("No hay filas");
            }
        }

        private void btAcercade_Click(object sender, EventArgs e) {
            VentanaAcerca = new fmAcercade();
            VentanaAcerca.ShowDialog();
        }

        private void rbContinente_Click(object sender, EventArgs e) {
            string sentenciasql = "SELECT * FROM paises ";
            if(rbPais.Checked)
                sentenciasql = sentenciasql + "ORDER BY nombre ";
            if(rbContinente.Checked)
                sentenciasql = sentenciasql + "ORDER BY continente ";
            if(rbPoblacion.Checked)
                sentenciasql = sentenciasql + "ORDER BY poblacion ";
            if(rbPIB.Checked)
                sentenciasql = sentenciasql + "ORDER BY pib ";
            if(rbIdentificador.Checked)
                sentenciasql = sentenciasql + "ORDER BY id ";
            if(rbCapital.Checked)
                sentenciasql = sentenciasql + "ORDER BY capital ";
            if(ckDescendente.Checked)
                sentenciasql = sentenciasql + "DESC";

            mostrarLista(sentenciasql);
        }

        private void mostrarLista(string sentenciasql) {
            MessageBox.Show(sentenciasql);
            OleDbDataAdapter adaptador = new OleDbDataAdapter(sentenciasql, conexion);
            DataSet ds = new DataSet();
            DataTable tabla = new DataTable();
            adaptador.Fill(ds);
            tabla = ds.Tables[0];
            lvDatos.Items.Clear();
            for(int i = 0; i < tabla.Rows.Count; i++) {
                DataRow filas = tabla.Rows[i];
                ListViewItem elementos = new ListViewItem(filas["id"].ToString());
                elementos.SubItems.Add(filas["nombre"].ToString());
                elementos.SubItems.Add(filas["capital"].ToString());
                elementos.SubItems.Add(filas["continente"].ToString());
                elementos.SubItems.Add(filas["poblacion"].ToString());
                elementos.SubItems.Add(filas["pib"].ToString());
                elementos.SubItems.Add("0");
                lvDatos.Items.Add(elementos);
            }
        }

        private void btPaisesRenta_Click(object sender, EventArgs e) {
            VentanaPaisesRenta = new fmPaisesPorRenta();
            VentanaPaisesRenta.ShowDialog();
                                 
        }
    }
}
