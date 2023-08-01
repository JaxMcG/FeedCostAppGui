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
    public partial class TotalSummaryForm : Form
    {
        FeedManager fm;

        public TotalSummaryForm(FeedManager fm)
        {
            this.fm = fm;
            InitializeComponent();

            rtbSumStatsAllCow.Text = fm.DisplayTotalSummary();
        }

        private void btnTotalSumToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
