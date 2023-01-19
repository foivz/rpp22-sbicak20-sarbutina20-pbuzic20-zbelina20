﻿using BusinessLogicLayer.Services;
using EntitiesLayer.Entities;
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
    public partial class FrmPopisRadnihNaloga : Form
    {
        Radnik Radnik = new Radnik();
        public FrmPopisRadnihNaloga(Radnik radnik)
        {
            InitializeComponent();
            Radnik = radnik;
        }

        RadniNalogService servis = new RadniNalogService();

        private void btnNoviRadniNalog_Click(object sender, EventArgs e)
        {
            FrmNoviRadniNalog frmNoviRadniNalog = new FrmNoviRadniNalog(Radnik);
            frmNoviRadniNalog.ShowDialog();
            UcitajRadneNaloge();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPopisRadnihNaloga_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmPopisRadnihNaloga_Load(object sender, EventArgs e)
        {
            UcitajRadneNaloge();
        }

        private void UcitajRadneNaloge()
        {
            var popisRadnihNaloga = servis.DohvatiRadneNaloge();
            dgvPopisRadnihNaloga.DataSource = popisRadnihNaloga;
            dgvPopisRadnihNaloga.Columns[10].Visible = false;
        }
    }
}
