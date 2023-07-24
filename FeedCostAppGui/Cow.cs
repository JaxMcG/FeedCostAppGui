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
            id = "C" + breed.Substring(0, 1).ToUpper() + breed.Substring(1, 3).ToLower() + cowCount + dob.Year;
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
            return  fPrices * GetDailyFoodConsumed(); ;
        }

        //I no longer need this code as I've changed GetDailyFoodConsumed to a float, not a list
        public float GetFoodConsumed()
        {
            float weekConsumption = 0f;

            for (int dailyFoodIndex = dailyFoodAmount.Count - 7; dailyFoodIndex < dailyFoodAmount.Count; dailyFoodIndex++)
            {
                weekConsumption += dailyFoodAmount[dailyFoodIndex];
            }

            return weekConsumption;
        }

        //Calculate the Recommended Food that Should Be Consumed
        public string CalculateRecommendedFoodConsumption()
        {
            string recommendation = "";

            if (GetFoodConsumed() < 126)
            {
                recommendation = $"Cow {id} is eating {126 - GetFoodConsumed()}kg under the recommended amount of 126kg";
            }
            else if (GetFoodConsumed() > 200)
            {
                recommendation = $"Cow {id} is eating {GetFoodConsumed() - 200}kg over the recommended amount of 200kg";
            }
            else
            {
                recommendation = $"Cow {id} is eating {GetFoodConsumed()}kg which is within the recommended amount of 126kg - 200kg";
            }

            return recommendation;
        }

        //Display a Summary of the Food Eaten Plus the Cost
        public string DisplaySingleSummary(float fPrices, string foodType)
        {
            int dayCounter = 1;

            string summary = $"Breed: {breed}\nId: {id}\nType Of Food: {foodType}\n\n" +
                $"Food Eaten:\n";

            for (int dailyFoodIndex = dailyFoodAmount.Count - 7; dailyFoodIndex < dailyFoodAmount.Count; dailyFoodIndex++)
            {
                summary += $"Day {dayCounter}: {dailyFoodAmount[dailyFoodIndex]}kg\n\n";

                dayCounter++;
            }

            summary += $"Total Food Consumed: {GetDailyFoodConsumed()}kg\n";

            summary += $"Total Cost: ${CalculateWeeklyCost(fPrices)}\n";
                
            return summary;
        }

        public override string ToString()
        {
            return "";
        }
    }
}
