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
        Cow cw;

        public AddFoodConsumptionForm(FeedManager fm, Cow cw)
        {
            this.fm = fm;
            this.cw = cw;
            InitializeComponent();            
        }

        private void btnToSummary_Click(object sender, EventArgs e)
        {
            List<float> weeklyConsumption = new List<float>() {
                (float)Convert.ToDouble(tbxFoodAmount1.Text), 
                (float)Convert.ToDouble(tbxFoodAmount2.Text), 
                (float)Convert.ToDouble(tbxFoodAmount3.Text), 
                (float)Convert.ToDouble(tbxFoodAmount4.Text), 
                (float)Convert.ToDouble(tbxFoodAmount5.Text), 
                (float)Convert.ToDouble(tbxFoodAmount6.Text), 
                (float)Convert.ToDouble(tbxFoodAmount7.Text)};

            fm.AddWeeklyConsumption(weeklyConsumption);

            cw.GetDailyFoodConsumed();

            fm.CalculateTotalFoodConsumed();

            fm.CalculateTotalFoodCost();

            

            this.Hide();
            SummaryForm myNewForm = new SummaryForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
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
