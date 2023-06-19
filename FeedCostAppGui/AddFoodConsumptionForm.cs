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
    public partial class AddFoodConsumptionForm : Form
    {
        FeedManager cw;

        public AddFoodConsumptionForm(FeedManager cw)
        {
            this.cw = cw;
            InitializeComponent();
        }

        private void btnToSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            SummaryForm myNewForm = new SummaryForm(cw);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnCancelProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(cw);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
