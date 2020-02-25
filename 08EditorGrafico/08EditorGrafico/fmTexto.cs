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
    public partial class fmTexto : Form {

        public Font mifuente;
        public string mitexto;
        public SolidBrush colortexto;


        public fmTexto() {
            InitializeComponent();
        }

        private void btFuente_Click(object sender, EventArgs e) {
            colortexto = new SolidBrush(Color.Black);
            mifuente = new Font("Arial", 15);
            dlgFuente.Font = mifuente;
            if(dlgFuente.ShowDialog() == DialogResult.OK) {
                mifuente = dlgFuente.Font;
                colortexto.Color = dlgFuente.Color;
            }
        }

        private void btAplicar_Click(object sender, EventArgs e) {
            mitexto = tbTexto.Text;
            DialogResult = DialogResult.OK;
        }

        private void fmTexto_Load(object sender, EventArgs e) {

        }
    }
}
