using DeFacto.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Firebase.Database.Query;
using System.Collections.ObjectModel;

namespace DeFacto.Services
{
    public class FoodItemService 
    {
        FirebaseClient client;
        public FoodItemService()
        {
            client = new FirebaseClient("https://defacto-b64f8-default-rtdb.firebaseio.com/");
        }

        public async Task<List<FoodItem>> GetFoodItemsAsync()
        {
            var products = (await client.Child("FoodItems")
                .OnceAsync<FoodItem>())
                .Select(f => new FoodItem
                {
                   CategoryID = f.Object.CategoryID,
                   Description = f.Object.Description,
                   HomeSelected = f.Object.HomeSelected,
                   ImageUrl = f.Object.ImageUrl,
                   Name = f.Object.Name,
                   Price = f.Object.Price,
                   ProductID = f.Object.ProductID,
                   Rating = f.Object.Rating,
                   RatingDetail = f.Object.RatingDetail
                }).ToList();
            return products;
        }

        public async Task<ObservableCollection<FoodItem>> GetFoodItemsByCategoryAsync(int categoryId)
        {
            var foodItemsByCategory = new ObservableCollection<FoodItem>();
            var items = (await GetFoodItemsAsync()).Where(p => p.CategoryID == categoryId).ToList();
            foreach (var item in items)
            {
                foodItemsByCategory.Add(item);
            }
            return foodItemsByCategory;
        }
        public async Task<ObservableCollection<FoodItem>> GetLatestFoodItemsAsync()
        {
            var latestFoodItems= new ObservableCollection<FoodItem>();
            var items = (await GetFoodItemsAsync()).OrderByDescending(f => f.ProductID).Take(3);
            foreach (var item in items)
            {
                latestFoodItems.Add(item);
            }
            return latestFoodItems;
        }
    }
}
