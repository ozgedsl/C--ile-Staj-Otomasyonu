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
    public partial class OgrenciKontrolEkrani : Form
    {
        public OgrenciKontrolEkrani()
        {
            InitializeComponent();
        }

        private void aramaButon_Click(object sender, EventArgs e)
        {

        }

        private void btKapatOgrArama_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriOgrArama_Click(object sender, EventArgs e)
        {
            this.Close();
            AkademisyenAnasayfasi ana = new AkademisyenAnasayfasi();
            ana.Show();
        }

        private void btDuzenle_Click(object sender, EventArgs e)
        {

        }
    }
}
