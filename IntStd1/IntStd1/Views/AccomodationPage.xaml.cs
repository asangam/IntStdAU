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
	public partial class AccomodationPage : ContentPage
	{
		public AccomodationPage ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            Device.OpenUri(new Uri("https://au.easyroommate.com/")); //Open the site in browser

        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {

            Device.OpenUri(new Uri("https://www.flatmatefinders.com.au/")); //Open the site in browser

        }
        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {

            Device.OpenUri(new Uri("https://flatmates.com.au/")); //Open the site in browser

        }



        
        
    }
}