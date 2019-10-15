using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioForms
{
    public partial class fmElformulario : Form
    {

        fmAcercade VentanaAcercade;

        public fmElformulario()
        {
            InitializeComponent();

            //VentanaAcercade = new fmAcercade();
            // estático
        }

        private void laMover_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DefaultMargin.ToString());
            //MessageBox.Show(DefaultPadding.ToString());
        }


        private void btArriba_Click(object sender, EventArgs e)
        {
            if (laMover.Top <= 26) {
                laMover.Top = Height - 30;
            }
            laMover.Top -= 10;
            // MessageBox.Show(laMover.Top.ToString());
        }

        private void btDerecha_Click(object sender, EventArgs e)
        {
            if (laMover.Left >= (Width)) {
                laMover.Left = 0 - laMover.Width;
            }
            laMover.Left += 10;
        }

        private void btAbajo_Click(object sender, EventArgs e)
        {
            if (laMover.Top >= (Height - 30)) {
                laMover.Top = 10;
            }
            laMover.Top += 10;
        }

        private void btIzquierda_Click(object sender, EventArgs e)
        {

            if (laMover.Left <= 0 - laMover.Width) {
                laMover.Left = Width;
            }
            laMover.Left -= 10;

        }


        private void btAumenta_Click(object sender, EventArgs e)
        {
            float Aumenta = laPrincipal.Font.Size;
            Aumenta++;
            laPrincipalSize.Text = Convert.ToString(Aumenta);
            laPrincipal.Font = new Font("", Aumenta, FontStyle.Regular, GraphicsUnit.Point);


        }

        private void btDisminuye_Click(object sender, EventArgs e)
        {
            float disminuye = laPrincipal.Font.Size;
            disminuye--;
            laPrincipalSize.Text = Convert.ToString(disminuye);
            laPrincipal.Font = new Font("", disminuye, FontStyle.Regular, GraphicsUnit.Point);



        }



        private void btDelante_Click(object sender, EventArgs e)
        {
            laMover.BringToFront();
        }

        private void btDetras_Click(object sender, EventArgs e)
        {
            laMover.SendToBack();
        }

        private void btVisible_Click(object sender, EventArgs e)
        {
            
            pnBotones.Visible = !pnBotones.Visible;
        }

        private void btController_Click(object sender, EventArgs e)
        {
            int Cuenta = 0;
            foreach (Control miControl in Controls) {
                if (miControl is Button) {
                    MessageBox.Show(miControl.Text);
                    Cuenta++;
                }
            }
            MessageBox.Show("Total Botones en el Formulario: " + Cuenta);
        }

        private void btPanel_Click(object sender, EventArgs e)
        {
            int Cuenta = 0;
            foreach (Control miPanelControl in pnBotones.Controls) {
                    MessageBox.Show(miPanelControl.Text);
                    Cuenta++;
            }
            MessageBox.Show("Total Controles en el Panel: " + Cuenta);

        }

        private void btAcercade_Click(object sender, EventArgs e)
        {
            /**
             * Pasos crear proyecto multiformulario
             * - Incluir un nuevo form (menu proyecto/agregar windows form)
             * - Definir el nuevo objeto ventana a nivel global para poder ser usado en diferentes funciones
             * - Contruyo el objeto:  - Si es estático en el constructor
             *                        - Si es dinámico creo el objeto en el mismo evento que invoca al nuevo formulario
             * - Muestro el nuevo formulario con el metodo Showdialog para modal o Show para ventana normal
             * - Destruyo el objeto nueva ventana en el mismo evento donde se invoca si es dinámico
             * - Si es estático no se destruye hasta el fin de la aplicación
             **/

            // Dinámico
            VentanaAcercade = new fmAcercade();
            VentanaAcercade.ShowDialog();
            
            VentanaAcercade.Dispose();
            
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            Button miBoton = (Button)sender;
            MessageBox.Show(miBoton.Text);

        }

    }
}
