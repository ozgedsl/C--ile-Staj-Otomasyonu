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
    public partial class YeniOgrenciKayit : Form
    {
        public YeniOgrenciKayit()
        {
            InitializeComponent();
        }
      
        private void btOgrKaydet_Click(object sender, EventArgs e)
        {
          MessageBox.Show("Kayıt Alındı.");
        }

        private void btKapatOgrKayit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriOgrKayit_Click(object sender, EventArgs e)
        {
            this.Close();
            AkademisyenAnasayfasi ana = new AkademisyenAnasayfasi();
            ana.Show();
        }
    }
}
