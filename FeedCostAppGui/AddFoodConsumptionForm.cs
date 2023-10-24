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

            //Sets the background colour of the labels to transparent
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        //Button which takes the user to the summary form and calculates the food consumed and cost
        private void btnToSummary_Click(object sender, EventArgs e)
        {
            if (CheckDate())
            {
                //Convert every numeric up and down counter value to a float
                List<float> weeklyConsumption = new List<float>();
                float foodEaten1 = (float)Convert.ToDouble(nudFoodConsumed1.Value);
                float foodEaten2 = (float)Convert.ToDouble(nudFoodConsumed2.Value);
                float foodEaten3 = (float)Convert.ToDouble(nudFoodConsumed3.Value);
                float foodEaten4 = (float)Convert.ToDouble(nudFoodConsumed4.Value);
                float foodEaten5 = (float)Convert.ToDouble(nudFoodConsumed5.Value);
                float foodEaten6 = (float)Convert.ToDouble(nudFoodConsumed6.Value);
                float foodEaten7 = (float)Convert.ToDouble(nudFoodConsumed7.Value);

                List<DateTime> dateWhenFoodConsumed = new List<DateTime>();

                //Adds the food consumed with the date
                for (int i = -6; i < 1; i++)
                {
                    dateWhenFoodConsumed.Add(dtpFoodConsumptionDay7.Value.AddDays(i));
                }

                //Adds the weeks consumption to a list
                weeklyConsumption.Add(foodEaten1);
                weeklyConsumption.Add(foodEaten2);
                weeklyConsumption.Add(foodEaten3);
                weeklyConsumption.Add(foodEaten4);
                weeklyConsumption.Add(foodEaten5);
                weeklyConsumption.Add(foodEaten6);
                weeklyConsumption.Add(foodEaten7);

                
                fm.AddWeeklyConsumption(selectedCow, weeklyConsumption, dateWhenFoodConsumed);

                //Gets the weeks consumption
                fm.GetWeeksConsumption(selectedCow);

                //Gets the cost of the weeks consumption
                fm.GetConsumptionCost(selectedCow);


                //When clicked go to the summary form
                this.Hide();
                SummaryForm myNewForm = new SummaryForm(fm, selectedCow);
                myNewForm.Closed += (s, args) => this.Close();
                myNewForm.Show();
            }            
        }

        //Button which takes the user back to the home form and cancels the process
        private void btnCancelProcess_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //Checks the date when it is changed
        private void dtpFoodConsumptionDay7_ValueChanged(object sender, EventArgs e)
        {
            CheckDate();
        }

        //Checks to see if the new date is a sunday otherwise display an error message
        private bool CheckDate()
        {
            if (dtpFoodConsumptionDay7.Value.DayOfWeek != 0)
            {
                MessageBox.Show("Error: Please select a Sunday");
                return false;
            }

            return true;
        }
    }
}
