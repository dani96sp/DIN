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
    public partial class fmIntroduccionDatos : Form {
        public fmIntroduccionDatos() {
            InitializeComponent();
        }

        
        public bool validacif(string cif) {
            int Suma = 0;
            int Control;
            byte n;
            bool Resulta = false;

            if (cif.Length == 9) {  //sumar las cifras pares
                Suma = Convert.ToInt32(Convert.ToString(cif[2])) +
                Convert.ToInt32(Convert.ToString(cif[4])) + Convert.ToInt32(Convert.ToString(cif[6]));

                for (n = 0; n <= 3; n++) {//suma los impares
                    string impares = Convert.ToString(Convert.ToInt32(Convert.ToString(cif[n * 2 + 1])) * 2);
                    Suma = Suma + Convert.ToInt32(Convert.ToString(impares[0]));
                    if (impares.Length > 1)
                        Suma = Suma + Convert.ToInt32(Convert.ToString(impares[1]));
                }
                Control = 10 - (Suma % 10);/////////////////////////////////////
                string primercar = Convert.ToString(cif[0]);
                if ((primercar.IndexOf("X") >= 0) || (primercar.IndexOf("P") >= 0)) {   //Control tipo letra
                    Resulta = (cif[8] == (char)(64 + Control));
                } else {   //Control tipo número
                    if (Control == 10) Control = 0;
                    Resulta = (Convert.ToString(cif[8])) == Convert.ToString(Control);
                }
            }//DEL IF
            return Resulta;
        } //fin de la funcion


        public bool calculaletranif(int dni, char letra) {
            char letracorrecta;
            int resto; // resto de la funcion para saber la letra en la cadena
            string letras = "TRWAGMYFPDXBNJZSQUHLCKE";
            resto = dni % 23;
            letracorrecta = letras[resto]; // esto es lo que devuelve la funcion
            if (letracorrecta == letra)
                return true;
            else
                return false;
        }



        private void btAceptar_Click(object sender, EventArgs e) {
            // Validamos los campos




            DialogResult = DialogResult.OK;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e) {
        }

        private void tbEmail_Leave(object sender, EventArgs e) {
            if (tbEmail.Text.Length > 0) {
                if (!tbEmail.Text.Contains("@") || !tbEmail.Text.Contains(".")) {
                    MessageBox.Show("El correo electronico esta mal");
                    tbEmail.Focus();
                } else if (!tbEmail.Text.Split('@')[1].Contains(".")) {
                    MessageBox.Show("El correo electronico esta mal");
                    tbEmail.Focus();
                }
            }
        }

        private void fmIntroduccionDatos_KeyPress(object sender, KeyPressEventArgs e) {
            // Hay que poner el KeyPreview del formulario en true para que funcione
            if (e.KeyChar == (char)13) {
                if (ActiveControl is TextBox) {

                    //e.KeyChar = (char)0;
                    SendKeys.Send("{TAB}");
                }
            }
        }

        private void tbDni_Leave(object sender, EventArgs e) {
            if (tbDni.Text.Length > 0) {
                if (tbDni.Text.Length == 9) {
                    if (Char.IsNumber(tbDni.Text[0])) {
                        char letra = tbDni.Text.ToCharArray()[8];
                        int numeros = Convert.ToInt32(tbDni.Text.Substring(0, 7));
                        if (!calculaletranif(numeros, letra)) {
                            MessageBox.Show("El DNI no es valido");
                            tbDni.Focus();
                        }
                    } else {
                        string cif = tbDni.Text;
                        if (!validacif(cif)) {
                            MessageBox.Show("El CIF no es valido");
                            tbDni.Focus();
                        }
                    }
                } else {
                    MessageBox.Show("El DNI/CIF no es válido");
                    tbDni.Focus();
                }
            }
        }
    }
}
