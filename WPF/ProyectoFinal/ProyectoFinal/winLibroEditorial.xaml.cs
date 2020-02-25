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
    /// Lógica de interacción para winLibroEditorial.xaml
    /// </summary>
    public partial class winLibroEditorial : Window {
        public winLibroEditorial() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {

            string consulta = "SELECT * FROM editorial";
            OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, MainWindow.miconexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            DataTable tabla = new DataTable();
            tabla = ds.Tables[0];
            dgEditoriales.ItemsSource = ds.Tables[0].DefaultView;

            /*
             Evento loaded ejecutar consulta para cargar el datagridview con las editoriales.
             Boton mostrar libros ejecutar consulta para cargar el datagrid con los libros
             de la editorial seleccionada. Comprobar que hay una editorial seleccionada.
             */


            // dgLibros.ItemsSource = ds.Tables[0].DefaultView;
        }

        private void btMostrarLibros_Click(object sender, RoutedEventArgs e) {
            if(dgEditoriales.SelectedIndex > -1) { 
                DataRowView row = dgEditoriales.SelectedItem as DataRowView;
                string codigoeditorial = row.Row.ItemArray[0].ToString();

                string consulta = "SELECT * FROM libros where codigoeditorial = " + codigoeditorial;
                OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, MainWindow.miconexion);
                DataSet ds = new DataSet();
                adaptador.Fill(ds);
                DataTable tabla = new DataTable();
                tabla = ds.Tables[0];
                dgLibros.ItemsSource = ds.Tables[0].DefaultView;
            } else {
                MessageBox.Show("Seleccione un registro de la tabla de Editoriales.");
            }
        }

        private void btSalir_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
