using BusinessLogicLayer.Services;
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
    public partial class FrmKreirajIzvjestajRadnihNaloga : Form
    {
        RadniNalogService servis = new RadniNalogService();

        public FrmKreirajIzvjestajRadnihNaloga()
        {
            InitializeComponent();
        }

        private void FrmKreirajIzvjestajRadnihNaloga_Load(object sender, EventArgs e)
        {
            var listaRadnihNaloga = servis.DohvatiRadneNalogePoStatusima();
            radniNalogBindingSource.DataSource = listaRadnihNaloga;

            this.reportViewRadniNalozi.RefreshReport();
        }
    }
}
