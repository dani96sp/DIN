using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08EditorGrafico {
    public partial class fmDatos : Form {
        public fmDatos() {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
        }

        private void btAceptar_Click(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) {
                btAceptar.PerformClick();
            }
        }
    }
}
