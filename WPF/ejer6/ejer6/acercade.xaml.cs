﻿using System;
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
using System.Windows.Shapes;

namespace ejer6 {
    /// <summary>
    /// Lógica de interacción para acercade.xaml
    /// </summary>
    public partial class acercade : Window {

        DirectoryInfo di;

        public acercade() {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            di = new DirectoryInfo(@".\fotos");

            imgAcercade.Source = new BitmapImage(new Uri(AppDomain.CurrentDomain.BaseDirectory
                + "fotos\\" + "acercade.png", UriKind.Absolute));

        }
    }
}
