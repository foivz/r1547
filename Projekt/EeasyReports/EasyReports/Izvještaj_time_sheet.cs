using System;
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
            // TODO: This line of code loads data into the 'lokalnaKopijaPodataka.Projekti' table. You can move, or remove it, as needed.
            this.projektiTableAdapter.Fill(this.lokalnaKopijaPodataka.Projekti);


        }

        private void btnOsvjezi_Click(object sender, EventArgs e)
        {
            if (cmbProjekti.ValueMember != null)
            {
                this.timeSheetTableAdapter.FillByProjMatBr(this.lokalnaKopijaPodataka.TimeSheet, Convert.ToInt32(cmbProjekti.ValueMember), 1);
            }
        }
    }
}
