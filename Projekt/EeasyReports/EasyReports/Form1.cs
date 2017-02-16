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
    public partial class EasyReports_ulaznaForma : Form
    {
        public EasyReports_ulaznaForma()
        {
            InitializeComponent();
        }

        private void EasyReports_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Izvještaj_time_sheet f = new Izvještaj_time_sheet();
            f.Show();
        }
    }
}
