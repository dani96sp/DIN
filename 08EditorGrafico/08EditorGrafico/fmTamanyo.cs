using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08EditorGrafico
{
    public partial class fmTamanyo : Form
    {
        public fmTamanyo()
        {
            InitializeComponent();
        }

        private void tbAlto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Con esto lo que hacemos es que sólo podamos introducir números y la tecla de borrar
            switch (e.KeyChar)
            {
                //case(char)8 tecla borrar en ASCII
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
                //case (char)',':
                default:
                    e.KeyChar = (char)0;//anular pulsación
                    break;
            }
        }
    }
}
