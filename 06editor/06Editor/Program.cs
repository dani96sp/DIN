﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Editor {
    static class Program {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // CARGAR VENTANA PRESENTACIÓN ANTES DEL FORMULARIO PRINCIPAL
            fmPresentacion ventanaPresentacion = new fmPresentacion();
            ventanaPresentacion.ShowDialog();

            Application.Run(new fmEditor());
        }
    }
}
