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
	public partial class TransportationPage : ContentPage
	{
		public TransportationPage ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://transportnsw.info")); //Open the site in browser

        }

        private void TapGestureRecognizer_Tapped1(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("http://www.metrotrains.com.au/")); //Open the site in browser

        }

        private void TapGestureRecognizer_Tapped2(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.uber.com/en/au/")); //Open the site in browser

        }

        private void TapGestureRecognizer_Tapped3(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.13cabs.com.au/")); //Open the site in browser

        }

    }
}