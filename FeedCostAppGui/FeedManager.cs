using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeedCostAppGui
{
        public class FeedManager
    {
        private List<Cow> cows = new List<Cow>();
        private List<string> breedTypes = new List<string>() { "Friesian", "Jersey", "Ayrshire" };
        private List<string> foodType = new List<string>() { "Palm Kernal", "Maize", "Hay" };
        private List<float> foodPrice = new List<float>() { 1.69625f, 0.4556f, 0.113f };
        private List<float> newFoodPrice = new List<float>();
        private List<string> AddSum = new List<string>();

        //Constructor
        public FeedManager()
        {

        }

        //Gets The List Of Breeds
        public List<string> GetBreeds()
        {
            return breedTypes;
        }

        //Gets The List Of Foods
        public List<string> GetFoods() 
        {
            return foodType;
        }

        //Gets The Price Related To The Food
        public float GetPrice(int priceIndex)
        {
            return foodPrice[priceIndex];
        }

        //Gets the selected or current cow
        public Cow GetSelectedCow(int selectedCow)
        {
            return cows[selectedCow];
        }

        //Passes The Food From Cow Class Into FeedManager Class
        public string GetFood(int selectedCowIndex)
        {
            return foodType[cows[selectedCowIndex].GetFoodType()];
        }

        //Gets the most recent cow added to the list
        public int GetMostRecentCowIndex()
        {
            return cows.Count - 1;
        }

        //Passes The Price From Cow Class Into FeedManager Class
        public float GetSelectedPrice(int selectedCowIndex)
        {
            return foodPrice[cows[selectedCowIndex].GetFoodType()];
        }

        //Gets all the cows that have been added
        public List<Cow> GetCows(string breed)
        {
            List<Cow> foundCows = new List<Cow>();

            foreach (var cow in this.cows)
            {
                if (cow.GetBreed().Equals(breed))
                {
                    foundCows.Add(cow);
                }
            }

            return foundCows;
        }

        //Add a Cow to the List 
        public void AddCow(Cow newCow)
        {
            cows.Add(newCow);

            cows[cows.Count - 1].CreateId(cows.Count);
        }

        //Gets the method that adds the weekly food consumed to a list
        public void AddWeeklyConsumption(int selectedCowIndex, List<float> consumption, List<DateTime> dates)
        {         
             cows[selectedCowIndex].AddFoodAmount(consumption, dates);         
        }

        //Passes The Food Consumed From Cow Class Into FeedManager Class
        public float GetWeeksConsumption(int selectedCowIndex)
        {
            return cows[selectedCowIndex].GetDailyFoodConsumed();
        }

        //Passes The Cost From Cow Class Into FeedManager Class
        public float GetConsumptionCost(int selectedCowIndex)
        {
            return cows[selectedCowIndex].CalculateWeeklyCost(GetSelectedPrice(selectedCowIndex));
        }

        //Passes The Summary From Cow Class Into FeedManager Class
        public string GetSummary(int selectedCowIndex)
        {
            return cows[selectedCowIndex].DisplaySingleSummary(GetSelectedPrice(selectedCowIndex), GetFood(selectedCowIndex));
        }

        //Gets the method that calculates the recommended food eaten in the cow class
        public string GetReconmendedFoodConsumed(int selectedCowIndex)
        {
            return cows[selectedCowIndex].ReconmendedFoodConsumed();
        }

        //Return The Index of the selected cow in the list
        public int GetIdIndex(string selectedId)
        {
            int idIndex = 0;

            foreach (var cow in cows)
            {
                if (cow.GetId().Equals(selectedId))
                {
                    return idIndex;
                }

                idIndex++;
            }

            return -1;
        }

        //Gets the method that displys a cows summary from the cow class
        public string GetCowSummary(string id)
        {
            return cows[GetIdIndex(id)].DisplaySingleSummary(GetSelectedPrice(GetIdIndex(id)), GetFood(GetIdIndex(id)));
        }

        public float[,] CalculateSeasonConsumption()
        {
            float[,] seasonConsumption = new float[3,4];

            foreach (var cow in cows)
            {

                for (int i = 0; i < 4; i++)
                {
                    seasonConsumption[cow.GetFoodType(),i] += cow.StoreFoodConsumedWithDate()[i];
                }
            }

            return seasonConsumption;
        }

        //Calculate the Total Food Consumed By Every Cow for the Week
        public List<float> CalculateTotalFoodConsumed()
        {
            List<float> totalFoodConsumed = new List<float>() {0, 0, 0 };

            foreach (Cow cow in cows)
            {                               
                    totalFoodConsumed[cow.GetFoodType()] += cow.GetDailyFoodConsumed();               
            }

            return totalFoodConsumed;
        }

        //Calculate the Total Cost of Food for CalculateTotalFoodConsumed()
        public float CalculateTotalFoodCost()
        {
            float totalFoodCost = 0;

            for (int index = 0; index < 3; index++)
            {
                totalFoodCost += foodPrice[index] * CalculateTotalFoodConsumed()[index];
            }

            return (float)Math.Round(totalFoodCost, 2);
        }

        //Change the Prices of Each type of Food
        public void ChangeFoodPrices()
        {
            foodPrice = newFoodPrice;
        }

        //Display a Summary of the Total Food Eaten Plus the Cost, and Recommended Food Eaten (All Animals, Not Just One)
        public string DisplayTotalSummary()
        {
            string totalSummary = $"Total Summary\n" +
                $"Total Food Consumed: \n";

            for (int i = 0; i < foodType.Count; i++)
            {
                totalSummary += $"{foodType[i]}: {CalculateTotalFoodConsumed()[i]}kg\n";
            }

                totalSummary += $"Total Cost: ${CalculateTotalFoodCost()}\n\n";

            return totalSummary;
        }

        //Adds The Summary To A List With All Summaries
        public List<string> AddSummaryToList()
        {
            AddSum.Add(DisplayTotalSummary());

            return AddSum;
        }

        //Display the Previous Summary
        public string DisplayPreviouSummary()
        {
            string previousSummary = "";

            for (int sumIndex = 0; sumIndex < AddSum.Count - 1; sumIndex++)
            {
                previousSummary = AddSum[sumIndex];
            }

            return previousSummary;
        }
    }
}
