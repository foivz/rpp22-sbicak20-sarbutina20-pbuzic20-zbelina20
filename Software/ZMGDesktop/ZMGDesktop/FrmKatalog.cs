using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZMGDesktop
{
    public partial class FrmKatalog : Form
    {
        public FrmKatalog()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            FrmDodaj dodaj = new FrmDodaj();
            dodaj.Show();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {

        }

        private void btnZaprimi_Click(object sender, EventArgs e)
        {

        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Close();
        }
    }
}
