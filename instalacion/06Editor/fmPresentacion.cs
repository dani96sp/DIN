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
    public partial class fmPresentacion : Form {
        public fmPresentacion() {
            InitializeComponent();
        }

        private void FmPresentacion_Load(object sender, EventArgs e) {
            Timer miTimer = new Timer();
            miTimer.Tick += Mitimer_Tick;
            miTimer.Interval = 1000;
            miTimer.Enabled = true;
            miTimer.Start();
        }

        private void Mitimer_Tick(object sender, EventArgs e) {
            Close();
        }
    }
}
