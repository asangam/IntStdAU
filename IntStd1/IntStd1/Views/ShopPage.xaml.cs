using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntStd1.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ShopPage : ContentPage
	{
		public ShopPage ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.aldi.com.au/")); //Open the site in browser


        }
        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.woolworths.com.au/")); //Open the site in browser


        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.coles.com.au/")); //Open the site in browser


        }
    }
}