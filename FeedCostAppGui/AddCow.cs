using System;
using System.IO;
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
            
            pcbCowFeedImage.Image = pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianH.jpeg");
            this.Controls.Add(pcbCowFeedImage);

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
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

            if (cbxFoodChoice.SelectedIndex.Equals(0) && cbxBreedChoice.SelectedIndex.Equals(0))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianH.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(0) && cbxBreedChoice.SelectedIndex.Equals(1))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/JerseyPk.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(0) && cbxBreedChoice.SelectedIndex.Equals(2))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/AyrshirePk.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(1) && cbxBreedChoice.SelectedIndex.Equals(0))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianM.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(1) && cbxBreedChoice.SelectedIndex.Equals(1))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/JerseyM.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(1) && cbxBreedChoice.SelectedIndex.Equals(2))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/AyrshireM.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(2) && cbxBreedChoice.SelectedIndex.Equals(0))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianPk.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(2) && cbxBreedChoice.SelectedIndex.Equals(1))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/JerseyH.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/AyrshireH.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
        }

        private void cbxBreedChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxFoodChoice.SelectedIndex.Equals(0) && cbxBreedChoice.SelectedIndex.Equals(0))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianH.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(1) && cbxBreedChoice.SelectedIndex.Equals(0))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianM.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(2) && cbxBreedChoice.SelectedIndex.Equals(0))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianPk.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(0) && cbxBreedChoice.SelectedIndex.Equals(1))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/JerseyPk.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(1) && cbxBreedChoice.SelectedIndex.Equals(1))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/JerseyM.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(2) && cbxBreedChoice.SelectedIndex.Equals(1))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/JerseyH.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(0) && cbxBreedChoice.SelectedIndex.Equals(2))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/AyrshirePk.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else if (cbxFoodChoice.SelectedIndex.Equals(1) && cbxBreedChoice.SelectedIndex.Equals(2))
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/AyrshireM.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
            else
            {
                pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/AyrshireH.jpeg");
                this.Controls.Add(pcbCowFeedImage);
            }
        }
    }
}