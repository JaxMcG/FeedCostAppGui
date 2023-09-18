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

            //Display the summary for all cows added
            rtbSumStatsAllCow.Text = fm.DisplayTotalSummary();

            //Sets the background colour of the labels to transparent
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        //Button which takes the user back to the home screen
        private void btnTotalSumToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
