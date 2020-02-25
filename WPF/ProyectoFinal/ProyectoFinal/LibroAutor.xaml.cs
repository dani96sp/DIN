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
    /// Lógica de interacción para LibroAutor.xaml
    /// </summary>
    public partial class LibroAutor : Window {
        public LibroAutor() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            string consulta = "SELECT * FROM autor";
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, MainWindow.miconexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            DataTable tabla = new DataTable();
            tabla = ds.Tables[0];
            dgAutores.ItemsSource = ds.Tables[0].DefaultView;

            /*
             Evento loaded ejecutar consulta para cargar el datagridview con las editoriales.
             Boton mostrar libros ejecutar consulta para cargar el datagrid con los libros
             de la editorial seleccionada. Comprobar que hay una editorial seleccionada.
             */


            // dgLibros.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void btMostrarLibros_Click(object sender, RoutedEventArgs e) {
            if(dgAutores.SelectedIndex > -1) {
                DataRowView row = dgAutores.SelectedItem as DataRowView;
                string codigoautor = row.Row.ItemArray[0].ToString();

                string consulta = "SELECT * FROM libros where codigoautor = " + codigoautor;
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, MainWindow.miconexion);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable tabla = new DataTable();
                tabla = ds.Tables[0];
                dgLibros.ItemsSource = ds.Tables[0].DefaultView;
            } else {
                MessageBox.Show("Seleccione un registro de la tabla de Autores.");
            }
        }

        private void btSalir_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
