using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace IntStd1.ViewModels
{
    public class HelpViewModel : BaseViewModel
    {
        public HelpViewModel()
        {
            Title = "Help";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://asangam.com.np/ip")));
        }

        public ICommand OpenWebCommand { get; }
    }
}