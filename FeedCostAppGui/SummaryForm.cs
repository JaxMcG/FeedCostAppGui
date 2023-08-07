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
    public partial class SummaryForm : Form
    {
        FeedManager fm;
        int selectedCow;

        public SummaryForm(FeedManager fm, int cowIndex)
        {
            this.fm = fm;
            this.selectedCow = cowIndex;
            InitializeComponent();

            //Display the summary for that cow
            rtbSumStatsPerCow.Text = fm.GetSummary(selectedCow);
            rtbSumStatsPerCow.Text += fm.GetReconmendedFoodConsumed(selectedCow);
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btnToHomeScreen_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnToTotalSumFromSingleSum_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalSummaryForm myNewForm = new TotalSummaryForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
