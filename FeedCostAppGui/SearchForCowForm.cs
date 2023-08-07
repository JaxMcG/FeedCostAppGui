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
    public partial class SearchForCowForm : Form
    {
        FeedManager fm;

        public SearchForCowForm(FeedManager fm)
        {
            this.fm = fm;
            InitializeComponent();
        }

        private void FilterSearch(string breed)
        {
            foreach (var cow in fm.GetCows(breed))
            {
                cbxSearchBar.Items.Add(cow.GetId());
            }

            
        }

        //Displaying all Friesian's only in the combo box/search bar
        private void rdbFilterFriesian_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFilterFriesian.Checked)
            {
                cbxSearchBar.Items.Clear();
                FilterSearch(rdbFilterFriesian.Text);
            }    
        }

        //Displaying all Jersey's only in the combo box/search bar
        private void rdbFilterJersey_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFilterJersey.Checked)
            {
                cbxSearchBar.Items.Clear();
                FilterSearch(rdbFilterJersey.Text);
            }
        }

        //Displaying all Ayrshire's only in the combo box/search bar
        private void rdbFilterAyrshire_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbFilterAyrshire.Checked)
            {
                cbxSearchBar.Items.Clear();
                FilterSearch(rdbFilterAyrshire.Text);
            }
        }

        private void btnToHomeFromSearch_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //Display the summary that corresponds to the cow selected in the search bar
        private void cbxSearchBar_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbDisplaySearchedCowSum.Text = fm.GetCowSummary(cbxSearchBar.Text);
        }
    }
}
