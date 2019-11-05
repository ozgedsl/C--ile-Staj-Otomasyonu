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
    public partial class AdminYeniAtama : Form
    {
        public AdminYeniAtama()
        {
            InitializeComponent();
        }

        private void btYeniAtama_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Atandı.");
        }

        private void btKapatYeniAtama_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGeriYeniAtama_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminGirisSayfasi ad = new AdminGirisSayfasi();
            ad.Show();

        }
    }
}
