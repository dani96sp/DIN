using System;
using System.Collections.Generic;
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

namespace ejer6 {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        
        public MainWindow() {
            InitializeComponent();
        }

        private void btSecundariaOcultar_Click(object sender, RoutedEventArgs e) {
            Secundaria miventana = new Secundaria(this);
            miventana.Show();
            this.Hide();
        }

        private void btSecundariaBloquear_Click(object sender, RoutedEventArgs e) {
            Secundaria miventana = new Secundaria(this);
            this.IsEnabled = false;
            miventana.Show();
        }

        private void btAcercade_Click(object sender, RoutedEventArgs e) {
             acercade ventanaacerca = new acercade();
             ventanaacerca.ShowDialog();
        }
    }
}
