using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoFinal {
    /// <summary>
    /// Lógica de interacción para winLibros.xaml
    /// </summary>
    public partial class winLibros : Window {
        
        private MainWindow padre;
        DataTable tabla;
        DataRow filas;

        public winLibros(MainWindow padre) {
            InitializeComponent();
            this.padre = padre;
        }

        private void cambiaventana(bool modo) {
            lbLibros.IsEnabled = modo;
            uGridNuevoModificarEliminar.IsEnabled = modo;
            btGuardar.IsEnabled = !modo;
            btActualizar.IsEnabled = !modo;
            btCancelar.IsEnabled = !modo;
            texboxsololectura(modo);

        }

        private void texboxsololectura(bool modo) {
            tbTitulo.IsReadOnly = modo;
            tbISBN.IsReadOnly = modo;
            cbMateria.IsReadOnly = modo;
            //tbFechaImpresion.IsReadOnly = modo;
            tbObservacion.IsReadOnly = modo;
        }

        private void limpiartextbox() {
            tbCodigo.Clear();
            tbTitulo.Clear();
            tbISBN.Clear();
            cbMateria.Text = "";
            //tbFechaImpresion.Clear();
            tbFechaImpresion.Text = ""; // calendar
            tbObservacion.Clear();
            tbEditorial.Clear();
            cbEditorial.Text = "";
            tbAutor.Clear();
            cbAutor.Text = "";

        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            llenaComboEditorial();
            llenaComboAutor();
            cargardatosListBox();
        }

        private void cargardatosListBox() {
            OleDbDataAdapter adaptador = new OleDbDataAdapter("SELECT * FROM libros", MainWindow.miconexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            tabla = new DataTable();
            tabla = ds.Tables[0];
            lbLibros.Items.Clear();
            for(int i = 0; i< tabla.Rows.Count; i++) {
                filas = tabla.Rows[i];
                lbLibros.Items.Add(filas["titulo"].ToString());
            }
        }

        private void llenaComboEditorial() {
            string consulta = "SELECT codigoeditorial, nombre FROM EDITORIAL";
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, MainWindow.miconexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            tabla = new DataTable();
            tabla = ds.Tables[0];
            cbEditorial.Items.Clear();
            for(int i = 0; i < tabla.Rows.Count; i++) {
                filas = tabla.Rows[i];
                cbEditorial.Items.Add(filas["nombre"]);
            }
        }

        private void llenaComboAutor() {
            string consulta = "SELECT codigoautor, nombre FROM AUTOR";
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, MainWindow.miconexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            tabla = new DataTable();
            tabla = ds.Tables[0];
            cbAutor.Items.Clear();
            for(int i = 0; i < tabla.Rows.Count; i++) {
                filas = tabla.Rows[i];
                cbAutor.Items.Add(filas["nombre"]);
            }
        }

        private void lbLibros_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            string valor = (string)lbLibros.SelectedValue;
            tbTitulo.Text = valor;

            if (lbLibros.SelectedIndex > -1) {
                filas = tabla.Rows[lbLibros.SelectedIndex];
                tbCodigo.Text = filas["codigolibro"].ToString();
                tbTitulo.Text = filas["titulo"].ToString();
                tbFechaImpresion.Text = filas["fechaimpresion"].ToString();
                tbObservacion.Text = filas["observacion"].ToString();
                tbISBN.Text = filas["isbn"].ToString();
                tbAutor.Text = filas["codigoautor"].ToString();
                tbEditorial.Text = filas["codigoeditorial"].ToString();
                cbMateria.Text = filas["materia"].ToString();
                string sentenciasql = "SELECT nombre FROM editorial WHERE codigoeditorial=@micod";
                OleDbCommand comando = new OleDbCommand(sentenciasql, MainWindow.miconexion);
                int mid = Convert.ToInt32(tbEditorial.Text);
                comando.Parameters.AddWithValue("@micod", mid);
                OleDbDataReader lector = comando.ExecuteReader();
                if (lector.Read()) {
                    cbEditorial.Text = lector["nombre"].ToString();
                }
                string sentenciasql2 = "SELECT nombre FROM autor WHERE codigoautor=@micod";
                OleDbCommand comando2 = new OleDbCommand(sentenciasql2, MainWindow.miconexion);
                int mid2 = Convert.ToInt32(tbAutor.Text);
                comando2.Parameters.AddWithValue("@micod", mid2);
                OleDbDataReader lector2 = comando2.ExecuteReader();
                if(lector2.Read()) {
                    cbAutor.Text = lector2["nombre"].ToString();
                }


            }


        }

        private void btNuevo_Click(object sender, RoutedEventArgs e) {
            limpiartextbox();
            lbLibros.SelectedItem = null;
            cambiaventana(false);
            btActualizar.IsEnabled = false;
            string numFilas = "SELECT TOP 1 codigolibro FROM libros ORDER BY codigolibro DESC ";
            OleDbCommand comando1 = new OleDbCommand(numFilas, MainWindow.miconexion);
            int numfil = Convert.ToInt16(comando1.ExecuteScalar());
            tbCodigo.Text = Convert.ToString(numfil + 1);
            tbTitulo.Focus();
        }

        private void btModificar_Click(object sender, RoutedEventArgs e) {
            if (lbLibros.Items.Count > 0) {
                if (lbLibros.SelectedItem != null) {
                    cambiaventana(false); // Este codigo cambia venta a modo edición
                    btGuardar.IsEnabled = false;
                    tbTitulo.Focus();
                } else {
                    MessageBox.Show("Tienes que seleccionar un libro de la lista para poder modificarlo.", 
                        "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            } else {
                MessageBox.Show("Actualmente no hay ningún libro en la base de datos.", "Información",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btEliminar_Click(object sender, RoutedEventArgs e) {
            if (lbLibros.Items.Count > 0) {
                if (lbLibros.SelectedItem != null) {
                    if(MessageBox.Show("¿Realmente desea eliminar el libro " + tbTitulo.Text + " de la base de datos?",
                        "Confrimar Eliminación de Registro", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes) {
                        string borra = "DELETE FROM libros WHERE codigolibro = @idborra";
                        OleDbCommand comandoborra = new OleDbCommand(borra, MainWindow.miconexion);
                        comandoborra.Parameters.AddWithValue("@idborra", tbCodigo.Text);
                        try {
                            comandoborra.ExecuteNonQuery();
                        } catch(Exception ex) {
                            MessageBox.Show(ex.Message);
                        }
                        MessageBox.Show("Datos borrados correctamente.");
                        lbLibros.Items.RemoveAt(lbLibros.SelectedIndex);
                        lbLibros.SelectedIndex = lbLibros.Items.Count - 1;
                        limpiartextbox();
                        tbCodigo.Clear();
                        cargardatosListBox();
                    }
                } else {
                    MessageBox.Show("Selecciona un libro a borrar.");
                    lbLibros.Focus();
                }
            }
        }

        private void btGuardar_Click(object sender, RoutedEventArgs e) {
            if (tbTitulo.Text == "" || tbEditorial.Text == "" || tbAutor.Text == "" || tbFechaImpresion.Text == "") {
                if(tbTitulo.Text == "") {
                    MessageBox.Show("Tienes que poner un título.");
                    tbTitulo.Focus();
                } else if(tbEditorial.Text == "") {
                    MessageBox.Show("Tienes que poner una editorial.");
                    tbEditorial.Focus();
                } else if(tbAutor.Text == "") {
                    MessageBox.Show("Tienes que poner un autor.");
                    tbAutor.Focus();
                } else if(tbFechaImpresion.Text == "") {
                    MessageBox.Show("Tienes que poner una fecha.");
                    tbFechaImpresion.Focus();
                }
            } else {
                string insertar = "INSERT INTO libros(codigolibro, titulo, observacion, isbn, codigoeditorial, fechaimpresion, materia, codigoautor) ";
                insertar += "VALUES('" + tbCodigo.Text + "', '" + tbTitulo.Text + "', '" + tbObservacion.Text + "', '"
                    + tbISBN.Text + "', '" + tbEditorial.Text + "', '" + tbFechaImpresion.Text + "', '" + cbMateria.Text + "', '"
                    + tbAutor.Text + "')";
                OleDbCommand comando = new OleDbCommand(insertar, MainWindow.miconexion);
                try {
                    comando.ExecuteNonQuery();
                } catch(Exception ex) {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Datos guardados correctamente.", "Información", MessageBoxButton.OK, MessageBoxImage.Information);
                cargardatosListBox();
                lbLibros.SelectedItem = lbLibros.Items.Count - 1;
                lbLibros.Focus();
                cambiaventana(true);
            }
        }

        private void btActualizar_Click(object sender, RoutedEventArgs e) {
            Int32 codigolibro = Convert.ToInt32(tbCodigo.Text);
            string modificar = "UPDATE libros SET titulo =@titulo, isbn = @isbn, materia=@materia," +
                " fechaimpresion=@fechaimpresion, observacion=@observacion WHERE codigolibro = @codigolibro;";
            OleDbCommand comando = new OleDbCommand(modificar, MainWindow.miconexion);
            comando.Parameters.AddWithValue("@titulo", tbTitulo.Text);
            comando.Parameters.AddWithValue("@isbn", tbISBN.Text);
            comando.Parameters.AddWithValue("@materia", cbMateria.Text);
            comando.Parameters.AddWithValue("@fechaimpresion", tbFechaImpresion.Text);
            comando.Parameters.AddWithValue("@observacion", tbObservacion.Text);
            comando.Parameters.AddWithValue("@codigolibro", codigolibro);
            //MessageBox.Show(modificar);

            try {
                comando.ExecuteNonQuery();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Datos modificados correctamente.");
            cargardatosListBox();
            lbLibros.Focus();
            cambiaventana(true);
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e) {

        }

        private void btSalir_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void cbEditorial_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (cbEditorial.SelectedIndex > -1) {
                string sentenciasql = "SELECT codigoeditorial FROM editorial WHERE nombre=@micod";
                OleDbCommand comando = new OleDbCommand(sentenciasql, MainWindow.miconexion);
                string mid = cbEditorial.Items[cbEditorial.SelectedIndex].ToString();
                comando.Parameters.AddWithValue("@micod", mid);
                OleDbDataReader lector = comando.ExecuteReader();
                if(lector.Read()) {
                    tbEditorial.Text = lector["codigoeditorial"].ToString();
                }
            }
        }

        private void cbAutor_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if(cbAutor.SelectedIndex > -1) {
                string sentenciasql = "SELECT codigoautor FROM autor WHERE nombre=@micod";
                OleDbCommand comando = new OleDbCommand(sentenciasql, MainWindow.miconexion);
                string mid = cbAutor.Items[cbAutor.SelectedIndex].ToString();
                comando.Parameters.AddWithValue("@micod", mid);
                OleDbDataReader lector = comando.ExecuteReader();
                if(lector.Read()) {
                    tbAutor.Text = lector["codigoautor"].ToString();
                }
            }
        }
    }
}
