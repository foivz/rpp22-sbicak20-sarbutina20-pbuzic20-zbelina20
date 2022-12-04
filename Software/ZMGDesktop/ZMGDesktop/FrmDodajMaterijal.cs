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
    public partial class FrmDodajMaterijal : Form
    {
        public FrmDodajMaterijal()
        {
            InitializeComponent();
        }

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            btnDodajMaterijal.Enabled = true;
            btnSpremi.Enabled=true;
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
