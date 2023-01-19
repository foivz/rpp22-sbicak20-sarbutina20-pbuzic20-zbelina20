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
    public partial class FrmPopisIzvjestaja : Form
    {
        public FrmPopisIzvjestaja()
        {
            InitializeComponent();
        }

        private void btnIzvjestajKlijenata_Click(object sender, EventArgs e)
        {
            FrmIzvjestajKlijenata form = new FrmIzvjestajKlijenata();
            form.ShowDialog();
        }
    }
}
