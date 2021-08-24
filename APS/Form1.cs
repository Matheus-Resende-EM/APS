using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APS
{
    public partial class Form1 : Form
    {
        static string nomeArquivo1, nomeArquivo2;
        Bitmap img1, img2;
        int contador1 = 0, contador2 = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            pgbarBarraDeProgresso.Visible = false;
            picImagem1.Visible = true;
            picImagem2.Visible = true;
        }

        private void linkPrimeiraImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd1.FileName = "";
            ofd1.Title = "Imagens";
            ofd1.Filter = "Todas Imagens|*.jpg; *.bmp; *.png";
            pgbarBarraDeProgresso.Value = 0;
            pgbarBarraDeProgresso.Visible = false;
            ofd1.ShowDialog();
            if (ofd1.FileName.ToString() != "")
            {
                nomeArquivo1 = ofd1.FileName.ToString();
                picImagem1.Image = new Bitmap(nomeArquivo1);
            }
        }

        private void linkSegundaImagem_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofd2.FileName = "";
            ofd2.Title = "Imagens";
            ofd2.Filter = "Todas Imagens|*.jpg; *.bmp; *.png";
            ofd2.ShowDialog();
            if (ofd2.FileName.ToString() != "")
            {
                nomeArquivo2 = ofd2.FileName.ToString();
                picImagem2.Image = new Bitmap(nomeArquivo2);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            picImagem1.Image = null;
            picImagem2.Image = null;
            pgbarBarraDeProgresso.Value = 0;
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        bool flag = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pgbarBarraDeProgresso.Visible = true;
            btnLimpar.Enabled = true;
            string img1_ref, img2_ref;
            img1 = new Bitmap(nomeArquivo1);
            img2 = new Bitmap(nomeArquivo2);

            pgbarBarraDeProgresso.Maximum = img1.Width;
            if (img1.Width == img2.Width && img1.Height == img2.Height)
            {
                for (int i = 0; i < img1.Width; i++)
                {
                    for (int j = 0; j < img1.Height; j++)
                    {
                        img1_ref = img1.GetPixel(i, j).ToString();
                        img2_ref = img2.GetPixel(i, j).ToString();
                        if (img1_ref != img2_ref)
                        {
                            contador2++;
                            flag = false;
                            break;
                        }
                        contador1++;
                    }
                    pgbarBarraDeProgresso.Value++;
                }

                if (flag == false)
                {
                    MessageBox.Show("As imagens não são as mesmas, " + contador2 + " pixels diferentes foram encontrados");
                }
                else
                {
                    MessageBox.Show("As imagens são as mesmas, " + contador1 + " pixels iguais foram encontrados, e  " + contador2 + " pixels incorretos foram encontrados");
                }
            }
            else
            {
                MessageBox.Show("As imagens não podem ser comparadas");
            }
        }
    }
}
