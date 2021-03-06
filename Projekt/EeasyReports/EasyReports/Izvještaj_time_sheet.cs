﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyReports
{
    public partial class Izvještaj_time_sheet : Form
    {
        public Izvještaj_time_sheet()
        {
            InitializeComponent();
        }

        private void Izvještaj_time_sheet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lokalnaKopijaPodataka.Osobe' table. You can move, or remove it, as needed.
            this.osobeTableAdapter1.Fill(this.lokalnaKopijaPodataka.Osobe);
            // TODO: This line of code loads data into the 'lokalnaKopijaPodataka.Projekti' table. You can move, or remove it, as needed.
            projektiTableAdapter.Fill(lokalnaKopijaPodataka.Projekti);
          

        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            if ((cmbProjekti.SelectedValue != null) && (cmbOsobe.SelectedValue != null))
            {
                
               timeSheetTableAdapter.FillByProjMatBr(lokalnaKopijaPodataka.TimeSheet, Convert.ToInt32(cmbProjekti.SelectedValue), 
                                                                                      Convert.ToInt32(cmbOsobe.SelectedValue));
            }
            
        }
    }
}
