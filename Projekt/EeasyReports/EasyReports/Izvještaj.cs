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
    public partial class Izvještaj : Form
    {
        public Izvještaj()
        {
            InitializeComponent();
        }

        private void Izvještaj_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_1547_DBDataSet.Plan_izvrsenja_projekta' table. You can move, or remove it, as needed.
            this.plan_izvrsenja_projektaTableAdapter.Fill(this._1547_DBDataSet.Plan_izvrsenja_projekta);

        }
    }
}
