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
    public partial class FrmPocetna : Form
    {
        public FrmPocetna()
        {
            InitializeComponent();
        }

        private void btnKlijenti_Click(object sender, EventArgs e)
        {
            FrmPregledKlijenata forma = new FrmPregledKlijenata();
            forma.ShowDialog();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            FrmPopisIzvjestaja form = new FrmPopisIzvjestaja();
            form.ShowDialog();
        }
    }
}
