using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KimlikEntegrasyonu.ServiceKimlik;

namespace KimlikEntegrasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnonay_Click(object sender, EventArgs e)
        {

            KPSPublicSoapClient servis = new KPSPublicSoapClient();
            bool deger = servis.TCKimlikNoDogrula(Convert.ToInt64(txtboxtckimlik.Text), txtboxad.Text.ToUpper(), txtboxsoyad.Text.ToUpper(), Convert.ToInt32(txtboxdogumyılı.Text));
            if (deger==true)
            {
                MessageBox.Show("Kimlik Doğru");
            }
            else
            {
                MessageBox.Show("Kimlik Yanlış");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
