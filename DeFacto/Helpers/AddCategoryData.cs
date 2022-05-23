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
    public class AddCategoryData
    {
        public List<Category> Categories { get; set; }

        FirebaseClient client;
        public AddCategoryData()
        {
            client = new FirebaseClient("https://defacto-b64f8-default-rtdb.firebaseio.com/");
            Categories = new List<Category>()
            {
                  new Category()
                {
                    CategoryId=1,
                    CategoryName = "Erkek",
                    CategoryPoster = "MainErkek",
                    ImageUrl = "Erkek.png"
                },

                  new Category()
                {
                    CategoryId=2,
                    CategoryName = "Kadin",
                    CategoryPoster = "MainKadin",
                    ImageUrl = "Kadin.png"
                },

                  new Category()
                {
                    CategoryId=3,
                    CategoryName = "Cocuk",
                    CategoryPoster = "MainCocuk",
                    ImageUrl = "Cocuk.png"
                },
                  new Category()
                {
                    CategoryId=4,
                    CategoryName = "Ayakkabi",
                    CategoryPoster = "MainAyakkabi",
                    ImageUrl = "Ayakkabi.png"
                },
                  new Category()
                {
                    CategoryId=5,
                    CategoryName = "Canta",
                    CategoryPoster = "MainCanta",
                    ImageUrl = "Canta.png"
                },
                  new Category()
                {
                    CategoryId=6,
                    CategoryName = "Bebek",
                    CategoryPoster = "MainBebek",
                    ImageUrl = "Bebek.png"
                }
              
            };            
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await client.Child("Categories").PostAsync(new Category()
                    { 
                        CategoryId = category.CategoryId,
                        CategoryName = category.CategoryName,
                        CategoryPoster = category.CategoryPoster,
                        ImageUrl = category.ImageUrl
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
