using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoFinal {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        public static OleDbConnection miconexion;

        public MainWindow() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            string conecta = (@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\datos\libros.mdb");
            miconexion = new OleDbConnection(conecta);
            miconexion.Open();

        }

        private void btLibros_Click(object sender, RoutedEventArgs e) {
            winLibros ventanaLibros = new winLibros(this);
            ventanaLibros.ShowDialog();
        }

        private void btEditoriales_Click(object sender, RoutedEventArgs e) {
            winEditorial ventanaEditorial = new winEditorial();
            ventanaEditorial.ShowDialog();
        }

        private void btAutores_Click(object sender, RoutedEventArgs e) {
            winAutores ventanaAutores = new winAutores();
            ventanaAutores.ShowDialog();

        }

        private void btLibrosEditorial_Click(object sender, RoutedEventArgs e) {
            winLibroEditorial ventanaLibroEditorial = new winLibroEditorial();
            ventanaLibroEditorial.ShowDialog();
        }

        private void btLibrosAutores_Click(object sender, RoutedEventArgs e) {
            LibroAutor ventanaLibroAutor = new LibroAutor();
            ventanaLibroAutor.ShowDialog();
        }

        private void btAcercaDe_Click(object sender, RoutedEventArgs e) {
            acercade ventanaacerca = new acercade();
            ventanaacerca.ShowDialog();
        }

        private void btSalir_Click(object sender, RoutedEventArgs e) {
            Close();
        }

    }
}
