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
using System.Windows.Shapes;

namespace ejer6 {
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Secundaria : Window {

        MainWindow wpadre;

        public Secundaria(MainWindow ppadre) {
            wpadre = ppadre;
            InitializeComponent();
        }

        private void btPrimariaAntigua_Click(object sender, RoutedEventArgs e) {
            wpadre.IsEnabled = true;
            wpadre.Show();
            this.Close();
        }

        private void btPrimariaNueva_Click(object sender, RoutedEventArgs e) {
            wpadre.IsEnabled = true;
            MainWindow nuevaventana = new MainWindow();
            nuevaventana.Show();
            this.Close();
        }
    }
}
