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
            // TODO: This line of code loads data into the '_1547_DBDataSet2.TimeSheet' table. You can move, or remove it, as needed.
            this.timeSheetTableAdapter1.Fill(this._1547_DBDataSet2.TimeSheet);
            // TODO: This line of code loads data into the '_1547_DBDataSet11.TimeSheet' table. You can move, or remove it, as needed.
            this.timeSheetTableAdapter.Fill(this._1547_DBDataSet11.TimeSheet);

        }
    }
}
