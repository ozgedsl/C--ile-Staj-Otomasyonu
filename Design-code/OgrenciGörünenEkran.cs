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
    public partial class OgrenciGörünenEkran : Form
    {
        public OgrenciGörünenEkran()
        {
            InitializeComponent();
        }

        private void btKapatOgrEkran_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriOgrEkran_Click(object sender, EventArgs e)
        {
            this.Close();
            OgrenciGirisSayfasi ogr = new OgrenciGirisSayfasi();
            ogr.Show();
        }
    }
}
