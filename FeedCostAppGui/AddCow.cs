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
    public partial class AddCow : Form
    {
        FeedManager fm;

        public AddCow(FeedManager fm)
        {
            this.fm = fm;
            InitializeComponent();

            //Populate the Combo Box with Breeds
            foreach (var breed in fm.GetBreeds())
            {
                cbxBreedChoice.Items.Add(breed);
            }

            cbxBreedChoice.SelectedIndex = 0;

            //Populate the Combo Box with foods
            foreach (var food in fm.GetFoods())
            {
                cbxFoodChoice.Items.Add(food);
            }

            cbxFoodChoice.SelectedIndex = 0;
        }

        private void lblAddCowTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnToAddFood_Click(object sender, EventArgs e)
        {
            
            fm.AddCow(new Cow(cbxBreedChoice.Text, dtpDateOfBirth.Value, cbxFoodChoice.SelectedIndex));

            this.Hide();
            AddFoodConsumptionForm myNewForm = new AddFoodConsumptionForm(fm, fm.GetMostRecentCowIndex());
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void btnBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm myNewForm = new HomeForm(fm);
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        private void cbxFoodChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Display the price corresponding to the food chosen
            rtbShowPrice.Text = $"{fm.GetPrice(cbxFoodChoice.SelectedIndex)}";
        }

    }
}