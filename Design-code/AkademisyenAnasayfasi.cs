using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Staj_Takip_Sistemi
{
    public partial class AkademisyenAnasayfasi : Form
    {
        public AkademisyenAnasayfasi()
        {
            InitializeComponent();
        }
       

        private void btYeniKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            YeniOgrenciKayit ogr = new YeniOgrenciKayit();
            ogr.Show();
        }

        private void btOgrKontrol_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciKontrolEkrani ekran = new OgrenciKontrolEkrani();
            ekran.Show();
        }

        private void btKapatAkadAnasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriAkadAnasayfa_Click(object sender, EventArgs e)
        {
            this.Close();
            AkademisyenGirisSayfasi ak = new AkademisyenGirisSayfasi();
            ak.Show();
        }
    }
}
