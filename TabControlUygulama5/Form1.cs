using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControlUygulama5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl1.SelectedIndex == 2)
            {
                txtBilgi.Text = "";
                txtBilgi.Text += txtAdSoyad.Text + "\r\n";
                txtBilgi.Text += txtTelefon.Text + "\r\n";
                txtBilgi.Text += txtAdres.Text + "\r\n";
                double hesap = 0;
                if (nCorba.Value > 0)
                {
                    hesap += Convert.ToDouble(nCorba.Value) * 25; 
                    txtBilgi.Text += string.Format("Çorba {0:C}",nCorba.Value * 25) + "\r\n";
                }
                if (nSalata.Value > 0)
                {
                    hesap += Convert.ToDouble(nSalata.Value) * 30;
                    txtBilgi.Text += string.Format("Salata {0:C}", nSalata.Value * 30) + "\r\n";
                }
                if (nAnaYemek.Value > 0)
                {
                    hesap += Convert.ToDouble(nAnaYemek.Value) * 95;
                    txtBilgi.Text += string.Format("Ana Yemek {0:C}", nAnaYemek.Value * 95) + "\r\n";
                }
                if (nTatlı.Value > 0)
                {
                    hesap += Convert.ToDouble(nTatlı.Value) * 40;
                    txtBilgi.Text += string.Format("Tatlı {0:C}", nTatlı.Value * 40) + "\r\n";
                }
                txtBilgi.Text += "-----------------";
                txtBilgi.Text += string.Format("Toplam{0:C}", hesap);
            }
        }

        private void Hesap_Click(object sender, EventArgs e)
        {

        }
    }
}
