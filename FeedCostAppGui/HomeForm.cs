using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FeedCostAppGui
{
    public partial class HomeForm : Form
    {
        FeedManager cw;

        public HomeForm(FeedManager cw)
        {
            this.cw = cw;
            InitializeComponent();
        }

        private void btnAddCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCow myNewForm = new AddCow(cw);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnToSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            SummaryForm myNewForm = new SummaryForm(cw);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
