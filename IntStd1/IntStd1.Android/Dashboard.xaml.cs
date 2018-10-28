using IntStd1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntStd1.Droid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dashboard : ContentPage
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //Device.OpenUri(new Uri("https://asangam.com.np/tia")); Open this site in browser
            await Navigation.PushAsync(new EssentialsPage()); //Open this page when button clicked


        }
    }
}