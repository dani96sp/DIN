using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06Editor {
    public partial class fmMargenes : Form {
        public fmMargenes() {
            InitializeComponent();
        }

        private void cbIzquierda_KeyPress(object sender, KeyPressEventArgs e) {
            // solo números
            switch(e.KeyChar) {
                case (char)8: // borrar
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
                    e.KeyChar = (char)0; // denegar
                    break;
            }
        }

        private void btAceptar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }
    }
}
