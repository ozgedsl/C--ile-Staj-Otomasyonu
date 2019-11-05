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
    public partial class OgrenciGirisSayfasi : Form
    {
        public OgrenciGirisSayfasi()
        {
            InitializeComponent();
        }

        private void ogrGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciGörünenEkran kln = new OgrenciGörünenEkran();
            kln.Show();
        }

        private void btKapatOgr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriogr_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaGiris anagrs = new AnaGiris();
            anagrs.Show();
            
        }
    }
}
