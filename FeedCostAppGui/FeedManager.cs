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
        private List<string> breedTypes = new List<string>() { "Friesian", "Jersey", "Ayrshire " };
        private List<string> foodType = new List<string>() { "Palm Kernal", "Maize", "Hay" };
        private List<float> foodPrice = new List<float>() { 1.69625f, 0.4556f, 0.113f };
        private List<float> newFoodPrice = new List<float>();
        private List<string> AddSum = new List<string>();

        //Constructor
        public FeedManager()
        {

        }

        public List<string> GetBreeds()
        {
            return breedTypes;
        }

        public List<string> GetFoods() 
        {
            return foodType;
        }

        public float GetPrice(int priceIndex)
        {
            return foodPrice[priceIndex];
        }

        public Cow GetSelectedCow(int selectedCow)
        {
            return cows[selectedCow];
        }

        public string GetFood(int selectedCowIndex)
        {
            return foodType[cows[selectedCowIndex].GetFoodType()];
        }

        public int GetMostRecentCowIndex()
        {
            return cows.Count - 1;
        }

        public float GetSelectedPrice(int selectedCowIndex)
        {
            return foodPrice[cows[selectedCowIndex].GetFoodType()];
        }

        //Add a Cow to the List 
        public void AddCow(Cow newCow)
        {
            cows.Add(newCow);

            cows[cows.Count - 1].CreateId(cows.Count);
        }

        public void AddWeeklyConsumption(int selectedCowIndex, List<float> consumption)
        {
            
             cows[selectedCowIndex].AddFoodAmount(consumption);
            
        }

        public float GetWeeksConsumption(int selectedCowIndex)
        {
            return cows[selectedCowIndex].GetDailyFoodConsumed();
        }

        public float GetConsumptionCost(int selectedCowIndex)
        {
            return cows[selectedCowIndex].CalculateWeeklyCost(GetSelectedPrice(selectedCowIndex));
        }

        //Calculate the Total Food Consumed By Every Cow for the Week
        public List<float> CalculateTotalFoodConsumed()
        {
            List<float> totalFoodConsumed = new List<float>() { 0, 0, 0 };

            foreach (Cow cow in cows)
            {
                for (int index = 0; index < 3; index++)
                {
                    totalFoodConsumed[index] += cow.GetDailyFoodConsumed();
                }
            }

            return totalFoodConsumed;
        }

        //Calculate the Total Cost of Food for CalculateTotalFoodConsumed()
        public List<float> CalculateTotalFoodCost(float foodPrices = 0)
        {
            List<float> totalFoodCost = new List<float>() { 0, 0, 0 };

            for (int index = 0; index < 3; index++)
            {
                totalFoodCost[index] = foodPrices * CalculateTotalFoodConsumed()[index];
            }

            return totalFoodCost;
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
                $"Total Food Consumed: {CalculateTotalFoodConsumed()}\n" +
                $"Total Cost: ${CalculateTotalFoodCost()}\n\n";
            return totalSummary;
        }

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
