using DeFacto.Models;
using DeFacto.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DeFacto.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsDetailsView : ContentPage
    {
        ProductsDetailsViewModel pvm;
        public ProductsDetailsView(FoodItem foodItem)
        {
            InitializeComponent();
            pvm = new ProductsDetailsViewModel(foodItem);
            this.BindingContext = pvm;
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}