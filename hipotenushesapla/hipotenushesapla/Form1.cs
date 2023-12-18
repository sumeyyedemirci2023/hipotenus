using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hipotenushesapla
{
    public partial class lblXcvp : Form
    {
        public lblXcvp()
        {
            InitializeComponent();
        }
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);
            int hesap =(sayi1 *sayi1 + sayi2*sayi2);
            double sonuc = Math.Sqrt(hesap);
            lblXcevap.Text = sonuc.ToString();
        }
    }
}
