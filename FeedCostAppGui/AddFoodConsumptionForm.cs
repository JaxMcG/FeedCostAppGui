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
        FeedManager fm;
        int selectedCow;

        public AddFoodConsumptionForm(FeedManager fm, int cowIndex)
        {
            this.fm = fm;
            this.selectedCow = cowIndex;
            InitializeComponent();            
        }

        private void btnToSummary_Click(object sender, EventArgs e)
        {

            //Add all the daily consumptions into one list
            List<float> weeklyConsumption = new List<float>();
            weeklyConsumption.Add((float)Convert.ToDouble(nudFoodConsumed1));
            weeklyConsumption.Add((float)Convert.ToDouble(nudFoodConsumed2));
            weeklyConsumption.Add((float)Convert.ToDouble(nudFoodConsumed3));
            weeklyConsumption.Add((float)Convert.ToDouble(nudFoodConsumed4));
            weeklyConsumption.Add((float)Convert.ToDouble(nudFoodConsumed5));
            weeklyConsumption.Add((float)Convert.ToDouble(nudFoodConsumed6));
            weeklyConsumption.Add((float)Convert.ToDouble(nudFoodConsumed7));

            fm.AddWeeklyConsumption(selectedCow, weeklyConsumption);

            fm.GetWeeksConsumption(selectedCow);

            fm.GetConsumptionCost(selectedCow);
        }

        private void btnCancelProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }      
    }
}
