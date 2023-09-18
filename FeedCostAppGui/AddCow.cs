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

            //Sets the default value of the cbx to index 0 (Friesian)
            cbxBreedChoice.SelectedIndex = 0;

            //Populate the Combo Box with foods
            foreach (var food in fm.GetFoods())
            {
                cbxFoodChoice.Items.Add(food);
            }

            //Sets the default value of the cbx to index 0 (Palm Kernel)
            cbxFoodChoice.SelectedIndex = 0;
            
            //Sets the default image to Friesian and palm kernel
            pcbCowFeedImage.Image = pcbCowFeedImage.Image = Image.FromFile("C:/Users/jacmcgr/OneDrive - Central Hawkes Bay College/CSD 2023/FriesianH.jpeg");
            this.Controls.Add(pcbCowFeedImage);

            //Sets the background colour of the labels to transparent
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        //Button which takes the user to the next form to add the consumption as well as add the cows properties
        private void btnToAddFood_Click(object sender, EventArgs e)
        {           
            fm.AddCow(new Cow(cbxBreedChoice.Text, dtpDateOfBirth.Value, cbxFoodChoice.SelectedIndex));

            this.Hide();
            AddFoodConsumptionForm myNewForm = new AddFoodConsumptionForm(fm, fm.GetMostRecentCowIndex());
            myNewForm.Closed += (s, args) => this.Close();
            myNewForm.Show();
        }

        //Button which takes the user back to the home screen and cancels the process
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

            //Checks to see the selected index of the breed cbx when changed and setting the image to the corresponding image
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
            //Checks to see the selected index of the foodtype cbx when changed and setting the image to the corresponding image
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