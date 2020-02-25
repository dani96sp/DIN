using System;
using System.Collections.Generic;
using System.IO;
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

namespace ejer3 {
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        DirectoryInfo di;
        string[] imgList;
        int indice = 0;

        public MainWindow() {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            di = new DirectoryInfo(@".\fotos");
            
            lbNombre.Content = " Total Fotografías " + di.GetFiles().Length;
            imgList = new string[di.GetFiles().Length];

            indice = 0;
            foreach(var fi in di.GetFiles()) {
                imgList[indice] = fi.Name;
                indice++;
            }
            indice = -1;

        }

        private void mostrar() {
            lbNombre.Content = indice + 1 + "  " + imgList[indice];
            imgMostrar.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory 
                + "fotos\\" + imgList[indice], UriKind.Absolute));
        }

        private void btAnterior_Click(object sender, RoutedEventArgs e) {
            if (indice > 0) {
                indice--;
                mostrar();
            }
        }


        private void btSiguiente_Click(object sender, RoutedEventArgs e) {
            if (indice < di.GetFiles().Length) {
                if (indice < di.GetFiles().Length -1) {
                    indice++;
                    mostrar();
                }
            }
        }
    }
}
