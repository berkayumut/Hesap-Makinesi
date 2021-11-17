using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinemiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        float sayi1;
        float sayi2;
        string islem;

        private void Form1_Load(object sender, EventArgs e)
        {
            txtSonuc.Text = "0";

        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn1.Text;
                     
            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn1.Text;
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn2.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn2.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn3.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn3.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn4.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn4.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn5.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn5.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn6.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn6.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn7.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn7.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn9.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn9.Text;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn9.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn9.Text;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "0")
            {
                txtSonuc.Text = btn0.Text;

            }
            else
            {
                txtSonuc.Text = txtSonuc.Text + btn0.Text;
            }
        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            islem = "/";
            sayi1 = float.Parse(txtSonuc.Text);
            txtgecmis.Text = sayi1 + " /";
            txtSonuc.Text = "0";
        }

        private void btncarpi_Click(object sender, EventArgs e)
        {
            islem = "x";
            sayi1 = float.Parse(txtSonuc.Text);
            txtgecmis.Text = sayi1 + " X";
            txtSonuc.Text = "0";
        }

        private void btnarti_Click(object sender, EventArgs e)
        {
            islem = "+";
            sayi1 = float.Parse(txtSonuc.Text);
            txtgecmis.Text = sayi1 + " +";
            txtSonuc.Text = "0";
        }

        private void btneksi_Click(object sender, EventArgs e)
        {
            islem = "-";
            sayi1 = float.Parse(txtSonuc.Text);
            txtgecmis.Text = sayi1 + " -";
            txtSonuc.Text = "0";
        }

        private void btnesittir_Click(object sender, EventArgs e)
        {
            sayi2 = float.Parse(txtSonuc.Text);
            txtgecmis.Text = txtgecmis.Text + sayi2;
            switch (islem)
            {
                case "+":
                    txtSonuc.Text = (sayi1 + sayi2).ToString();
                    break;
                case "-":
                    txtSonuc.Text = (sayi1 - sayi2).ToString();
                    break;
                case "x":
                    txtSonuc.Text = (sayi1 * sayi2).ToString();
                    break;
                case "/":
                    txtSonuc.Text = (sayi1 / sayi2).ToString();
                    break;
            }
        }

        private void btnvirgul_Click(object sender, EventArgs e)
        {
            txtSonuc.Text = txtSonuc.Text + ",";
        }

        private void btngerial_Click(object sender, EventArgs e)
        {
            string degisen = txtSonuc.Text.Substring(0, txtSonuc.Text.Length-1);
            txtSonuc.Text = degisen;
            
        }

        private void txtSonuc_TextChanged(object sender, EventArgs e)
        {
            if (txtSonuc.Text == "")
            {
                txtSonuc.Text = "0";
            }
        }

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnArkaMavi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnArkaYesil_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnYaziKirmizi_Click(object sender, EventArgs e)
        {
            this.ForeColor = Color.Red;
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBilgi frm = new FrmBilgi();
            frm.Show();
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtgecmis.Text = "";
            txtSonuc.Text = "0";
        }
    }
}
