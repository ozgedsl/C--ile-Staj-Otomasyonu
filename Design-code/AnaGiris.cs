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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }
        private void ogrenciGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            OgrenciGirisSayfasi syf = new OgrenciGirisSayfasi();
            syf.Show();
        }

        private void akademisyenGirisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            AkademisyenGirisSayfasi syf2 = new AkademisyenGirisSayfasi();
            syf2.Show();
        }

        private void adminGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminGirisSayfasi syf3 = new AdminGirisSayfasi();
            syf3.Show();
        }

        private void btAnagirisKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
