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

            //Sets the background colour of the labels to transparent
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        //Button which takes the user to the next form to add a cow
        private void btnAddCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCow myNewForm = new AddCow(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //Button which takes the user to the form displaying the total summary
        private void btnToTotalSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            TotalSummaryForm myNewForm = new TotalSummaryForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //Button which takes the user to the form which allows them to search for a cow
        private void btnSearchCow_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchForCowForm myNewForm = new SearchForCowForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //Button which takes the user to the form which displays the consumptio for each season
        private void btnToSeasonSum_Click(object sender, EventArgs e)
        {
            this.Hide();
            SeasonSummaryForm myNewForm = new SeasonSummaryForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }
    }
}
