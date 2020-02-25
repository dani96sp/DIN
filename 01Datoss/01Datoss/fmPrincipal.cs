using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01Datoss {
    public partial class fmPrincipal : Form {

        public fmPrincipal() {
            InitializeComponent();
        }

        private void btComandos_Click(object sender, EventArgs e) {
            fmComandos ventanaComandos = new fmComandos();
            ventanaComandos.Show();
        }

        private void btAcercade_Click(object sender, EventArgs e) {
            fmAcercade ventanaAcercade = new fmAcercade();
            ventanaAcercade.Show();
        }

        private void btAutomatico_Click_1(object sender, EventArgs e) {
            fmAutomatico ventanaAutomatico = new fmAutomatico();
            ventanaAutomatico.Show();
        }

        private void btConsultasFiltros_Click(object sender, EventArgs e) {
            fmConsultaFiltra ventanaConsultaFiltra = new fmConsultaFiltra();
            ventanaConsultaFiltra.Show();
        }
    }
}
