using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedCostAppGui
{
        public class Cow
    {
        //Attributes or Fields
        private string breed;
        private string id;
        private DateTime dob;


        //Stores the Indexs of the Food that Has Been Selected
        private int foodChoice;
        //Stores the Amount of Food Eaten Daily
        private List<float> dailyFoodAmount = new List<float>();

        //Constructor
        public Cow(string breed, DateTime dob, int foodChoice)
        {

            this.breed = breed;
            this.dob = dob;
            this.foodChoice = foodChoice;
        }

        //Add The Food Eaten Per Day To An Overall List
        public void AddFoodAmount(List<float> dailyFoodAmount)
        {
            foreach (var dailyConsumption in dailyFoodAmount)
            {
                this.dailyFoodAmount.Add(dailyConsumption);
            }
            
        }

        //Returns the Value in the Private breed Variable
        public string GetBreed()
        {
            return breed;
        }

        //Create Id for Each Animal
        public void CreateId(int cowCount)
        {
            id = "C" + breed.Substring(0, 1).ToUpper() + breed.Substring(1, 2).ToLower() + cowCount + "-" + dob.Year;
        }

        public string GetId()
        {
            return id;
        }

        //Returns the Value in the Private foodType Variable
        public int GetFoodType()
        {
            return foodChoice;
        }

        //Get the Amount of Food Eaten Each Day
        public float GetDailyFoodConsumed()
        {
            float weeksConsumption = 0;

            for (int dailyFoodIndex = dailyFoodAmount.Count - 7; dailyFoodIndex < dailyFoodAmount.Count; dailyFoodIndex++)
            {
                weeksConsumption += dailyFoodAmount[dailyFoodIndex];
            }

            return weeksConsumption;
        }

        //Calculate the Cost for the Food Eaten that Week
        public float CalculateWeeklyCost(float fPrices)
        {
            //Loop Through for the Number of Food Types Calculating the Sum Cost
            return fPrices * GetDailyFoodConsumed();
        }

        public string ReconmendedFoodConsumed()
        {
            string checkFoodConsumed;

            if (GetDailyFoodConsumed() < 105)
            {
                checkFoodConsumed = $"{GetId()} is eating {Math.Round(105 - GetDailyFoodConsumed(), 2)}kg under the reconmended food amount of 105kg - 140kg";
            }
            else if (GetDailyFoodConsumed() > 140)
            {
                checkFoodConsumed = $"{GetId()} is eating {Math.Round(GetDailyFoodConsumed() - 140, 2)}kg over the reconmended food amount of 105kg - 140kg";
            }
            else
            {
                checkFoodConsumed = $"{GetId()} is eating withing the reconmended food amount of 105kg - 140kg";
            }

            return checkFoodConsumed;
        }

        //Display a Summary of the Food Eaten Plus the Cost
        public string DisplaySingleSummary(float fPrices, string foodType)
        {
            int dayCounter = 1;

            string summary = $"Breed: {breed}\nId: {id}\nType Of Food: {foodType}\n" +
                $"Food Eaten:\n";

            for (int dailyFoodIndex = dailyFoodAmount.Count - 7; dailyFoodIndex < dailyFoodAmount.Count; dailyFoodIndex++)
            {
                summary += $"Day {dayCounter}: {dailyFoodAmount[dailyFoodIndex]}kg\n";

                dayCounter++;
            }

            summary += $"\nTotal Food Consumed: {GetDailyFoodConsumed()}kg\n";

            summary += $"Total Cost: ${Math.Round(CalculateWeeklyCost(fPrices), 2)}\n";
                
            return summary;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
