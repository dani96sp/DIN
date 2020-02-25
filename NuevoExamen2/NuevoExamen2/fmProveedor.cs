using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NuevoExamen2 {
    public partial class fmProveedor : Form {
        public int codigoproveedor = 1;

        public fmProveedor() {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdexafinDataSet);

        }

        private void fmProveedor_Load(object sender, EventArgs e) {
            // TODO: esta línea de código carga datos en la tabla 'bdexafinDataSet.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.bdexafinDataSet.proveedores);
            // TODO: esta línea de código carga datos en la tabla 'bdexafinDataSet.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.bdexafinDataSet.proveedores);

        }

        private void btAceptar_Click(object sender, EventArgs e) {
            Close();
        }

        private void proveedoresBindingNavigatorSaveItem_Click_1(object sender, EventArgs e) {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bdexafinDataSet);

        }

        private void proveedoresBindingSource_BindingComplete(object sender, BindingCompleteEventArgs e) {
            /*for(int i = 0; i<codigoproveedor; i++) {
                bindingNavigatorMoveNextItem.PerformClick();
            }*/
        }
    }
}
