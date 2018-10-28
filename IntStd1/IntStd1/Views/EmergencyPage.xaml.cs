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
	public partial class EmergencyPage : ContentPage
	{
		public EmergencyPage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:000")); //Open the site in browser

        }
    }
}