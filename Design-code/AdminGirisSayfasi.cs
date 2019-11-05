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
    public partial class AdminGirisSayfasi : Form
    {
        public AdminGirisSayfasi()
        {
            InitializeComponent();
        }

        private void btAdminGiris_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminYeniAtama kayit = new AdminYeniAtama();
            kayit.Show();
        }

        private void btKapatAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaGiris a = new AnaGiris();
            a.Show();

        }
    }
}
