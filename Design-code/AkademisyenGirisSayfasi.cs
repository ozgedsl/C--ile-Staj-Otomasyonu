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
    public partial class AkademisyenGirisSayfasi : Form
    {
        public AkademisyenGirisSayfasi()
        {
            InitializeComponent();
        }

        private void akadGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AkademisyenAnasayfasi anasyf = new AkademisyenAnasayfasi();
            anasyf.Show();
        }

        private void btKapatAkad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriakad_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaGiris a = new AnaGiris();
            a.Show();

        }
    }
}
