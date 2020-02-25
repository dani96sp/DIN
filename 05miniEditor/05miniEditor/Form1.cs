using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05miniEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (FontFamily misfuentes in FontFamily.Families)
            {
                cbFuentes.Items.Add(misfuentes.Name);
            }
            
            cbFuentes.Text = "Microsoft Sans Serif";
            cbTamanyo.Text = "8";
            lbColores.SelectedIndex = 6;
            
        }

        private void cbTamanyo_TextChanged(object sender, EventArgs e)
        {
            FontStyle estilo = new FontStyle();
            estilo = rtbEditor.SelectionFont.Style;
            float tamanyo = rtbEditor.SelectionFont.Size;

            string fuente = cbFuentes.Text;
            rtbEditor.SelectionFont = new Font(fuente, tamanyo, estilo);
            if (cbTamanyo.Text != "")
            {
                rtbEditor.SelectionFont = new Font(fuente, Convert.ToInt32(cbTamanyo.Text), estilo);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FontStyle negrita = new FontStyle();
            FontStyle subrayado = new FontStyle();
            FontStyle cursiva = new FontStyle();
            FontStyle tachado = new FontStyle();
            if (ckbNegrita.Checked)
                negrita = FontStyle.Bold;
            if (ckbSubrayado.Checked)
                subrayado = FontStyle.Underline;
            if (ckbCursiva.Checked)
                cursiva = FontStyle.Italic;
            if (ckbTachado.Checked)
                tachado = FontStyle.Strikeout;

            /*
             itNegrita.Checked = ckNegrita.Checked; 
             */

            rtbEditor.SelectionFont = new Font(rtbEditor.SelectionFont, negrita | subrayado | cursiva | tachado);
            rtbEditor.Focus();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbTamanyo_KeyPress(object sender, KeyPressEventArgs e)
        {
            // solo números
            switch (e.KeyChar)
            {
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
                case '0': break;
                default:
                    e.KeyChar = (char)0; // denegar
                    break;
            }
        }

        private void lbColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            int indice = 0;

            if (sender is ToolStripMenuItem)
            {
                ToolStripMenuItem elemento = sender as ToolStripMenuItem;
            }
            */

            Color micolor = Color.Black;
            switch(lbColores.SelectedIndex)
            {
                case 0:
                    micolor = Color.Red;
                    break;

                case 1:
                    micolor = Color.Green;
                    break;

                case 2:
                    micolor = Color.Blue;
                    break;

                case 3:
                    micolor = Color.Gray;
                    break;

                case 4:
                    micolor = Color.Orange;
                    break;

                case 5:
                    micolor = Color.Yellow;
                    break;

                case 6:
                    micolor = Color.Black;
                    break;
            }
            rtbEditor.SelectionColor = micolor;

        }
    }
}
