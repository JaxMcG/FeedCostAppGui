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
        FeedManager fm;

        public HomeForm(FeedManager fm)
        {
            this.fm = fm;
            InitializeComponent();
        }

        private void btnAddCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCow myNewForm = new AddCow(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnToSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            SummaryForm myNewForm = new SummaryForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
