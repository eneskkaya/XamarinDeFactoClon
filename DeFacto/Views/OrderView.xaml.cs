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
    public partial class OrderView : ContentPage
    {
        public OrderView(string id)
        {
            InitializeComponent();
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}