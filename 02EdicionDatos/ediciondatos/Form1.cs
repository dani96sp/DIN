using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ediciondatos {
    public partial class fmEdicion : Form {
        fmAcercade VentanaAcercade;
        fmIntroduccionDatos VentanaIntroduccionDatos;

        public fmEdicion() {
            InitializeComponent();
        }

        private void btAcercade_Click(object sender, EventArgs e) {

            VentanaAcercade = new fmAcercade();
            VentanaAcercade.ShowDialog();

            VentanaAcercade.Dispose();

        }

        private void btCambiar_Click(object sender, EventArgs e) {

            cambioMoneda(tbEuros);
        }

        private void tbEuros_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == (Char)13) {
                cambioMoneda(sender);
            }

            switch (e.KeyChar) {
                case (char)8:
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case (char)',':
                case (char)'.': break;
                default:
                    e.KeyChar = (char)0;
                    break;
            }
        }

        private void tbEuros_TextChanged(object sender, EventArgs e) {

            cambioMoneda(sender);
        }

        private void cambioMoneda(object sender) {
            double calculo;
            TextBox tb = (TextBox)sender;
            if (!tb.Text.Equals("")) {
                if (tb.Name == "tbPesetas") {
                    calculo = Double.Parse(tbPesetas.Text);
                    calculo *= 1.5;
                    tbEuros.Text = calculo.ToString("#,##");
                } else {
                    calculo = Double.Parse(tbEuros.Text);
                    calculo /= 1.5;
                    tbPesetas.Text = calculo.ToString("#,##");
                }
            }

        }

        private void laPesetas_Validated(object sender, EventArgs e) {
        }

        private void btDatos_Click(object sender, EventArgs e) {

            VentanaIntroduccionDatos = new fmIntroduccionDatos();
            VentanaIntroduccionDatos.ShowDialog();


            laNombre.Text = VentanaIntroduccionDatos.tbNombre.Text;
            laDireccion.Text = VentanaIntroduccionDatos.tbDireccion.Text;
            laLocalidad.Text = VentanaIntroduccionDatos.tbLocalidad.Text;
            laTelefono.Text = VentanaIntroduccionDatos.tbTelefono.Text;
            laEmail.Text = VentanaIntroduccionDatos.tbEmail.Text;
            laCodigoPostal.Text = VentanaIntroduccionDatos.tbCodigoPostal.Text;
            laDNICIF.Text = VentanaIntroduccionDatos.tbDni.Text;


            pnDatos.Visible = true;


            VentanaIntroduccionDatos.Dispose();

            

        }
    }
}
