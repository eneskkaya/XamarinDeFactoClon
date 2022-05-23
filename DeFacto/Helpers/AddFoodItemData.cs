using DeFacto.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DeFacto.Helpers
{
    public class AddFoodItemData
    {
        FirebaseClient client;
        public List<FoodItem> FoodItems { get; set; }

        public AddFoodItemData()
        {
            client = new FirebaseClient("https://defacto-b64f8-default-rtdb.firebaseio.com/");
            FoodItems = new List<FoodItem>()
            {
                 new FoodItem
                {
                    ProductID = 1,
                    CategoryID = 1,
                    ImageUrl = "Erkek1.png",                    
                    Description = "Erkek:Pantolon,Tişört",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    
                    Price = 35
                },
                 new FoodItem
                {
                    ProductID = 2,
                    CategoryID = 1,
                    ImageUrl = "Erkek2.png",
                    Description = "Erkek:Pantolon,Tişört",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",                    
                    Price = 45
                },
                 new FoodItem
                {
                    ProductID = 3,
                    CategoryID = 1,
                    ImageUrl = "Erkek3.png",
                    Description = "Erkek:Pantolon,Tişört",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",                    
                    Price = 45
                },
                 new FoodItem
                {
                    ProductID = 4,
                    CategoryID = 2,
                    ImageUrl = "Kadin1.png",                    
                    Description = "Kadın Kıyafet",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                 new FoodItem
                {
                    ProductID = 5,
                    CategoryID = 2,
                    ImageUrl = "Kadin2.png",
                    Description = "Kadın Kıyafet",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                 new FoodItem
                {
                    ProductID = 6,
                    CategoryID = 2,
                    ImageUrl = "Kadin3.png",
                    Description = "Kadın Kıyafet",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                 new FoodItem
                {
                    ProductID = 7,
                    CategoryID = 3,
                    ImageUrl = "Cocuk1.png",                    
                    Description = "Çocuk Kıyafet",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                 new FoodItem
                {
                    ProductID = 8,
                    CategoryID = 3,
                    ImageUrl = "Cocuk2.png",                    
                    Description = "Çocuk Kıyafet",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                  new FoodItem
                {
                    ProductID = 9,
                    CategoryID = 4,
                    ImageUrl = "Ayakkabi1.png",
                    Description = "Ayakkabı Terlik",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                   new FoodItem
                {
                    ProductID = 10,
                    CategoryID = 4,
                    ImageUrl = "Ayakkabi2.png",
                    Description = "Ayakkabi Terlik",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                    new FoodItem
                {
                    ProductID = 11,
                    CategoryID = 5,
                    ImageUrl = "Canta1.png",
                    Description = "Çanta Cüzdan",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                     new FoodItem
                {
                    ProductID = 12,
                    CategoryID = 5,
                    ImageUrl = "Canta2.png",
                    Description = "Çanta Cüzdan",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                }, new FoodItem
                {
                    ProductID = 13,
                    CategoryID = 6,
                    ImageUrl = "Bebek1.png",
                    Description = "Bebek Kıyafet",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                },
                      new FoodItem
                {
                    ProductID = 14,
                    CategoryID = 6,
                    ImageUrl = "Bebek.png",
                    Description = "Bebek Kıyafet",
                    Rating = "4.8",
                    RatingDetail = " (121 raitings)",
                    HomeSelected = "CompleteHeart",
                    Price = 45
                }
            };
        }

        public async Task AddFoodItemAsync()
        {
            try
            {
                foreach (var item in FoodItems)
                {
                    await client.Child("FoodItems").PostAsync(new FoodItem()
                    {
                        CategoryID = item.CategoryID,
                        ProductID = item.ProductID,
                        Description = item.Description,
                        HomeSelected = item.HomeSelected,
                        ImageUrl = item.ImageUrl,
                        Name = item.Name,
                        Price = item.Price,
                        Rating = item.Rating,
                        RatingDetail = item.RatingDetail
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "OK");              
            }
            
        }
    }
}
