using IntStd1.Droid;
using IntStd1.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntStd1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            //MenuPages.Add((int)MenuItemType.IntStd, (NavigationPage)Detail);

        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    //case (int)MenuItemType.IntStd:
                    //    MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                    //    break;
                    case (int)MenuItemType.Dashboard:
                        MenuPages.Add(id, new NavigationPage(new Dashboard()));
                        break;

                    case (int)MenuItemType.Essentials:
                        MenuPages.Add(id, new NavigationPage(new EssentialsPage()));
                        break;

                    case (int)MenuItemType.Shop:
                        MenuPages.Add(id, new NavigationPage(new ShopPage()));
                        break;

                    case (int)MenuItemType.Transportation:
                        MenuPages.Add(id, new NavigationPage(new TransportationPage()));
                        break;

                    case (int)MenuItemType.Jobs:
                        MenuPages.Add(id, new NavigationPage(new JobsPage()));
                        break;

                    case (int)MenuItemType.Rooms:
                        MenuPages.Add(id, new NavigationPage(new AccomodationPage()));
                        break;

                    case (int)MenuItemType.Emergency:
                        MenuPages.Add(id, new NavigationPage(new EmergencyPage()));
                        break;

                    case (int)MenuItemType.AboutDev:
                         MenuPages.Add(id, new NavigationPage(new AboutDevPage()));
                        break;

                    case (int)MenuItemType.Help:
                        MenuPages.Add(id, new NavigationPage(new HelpPage()));
                        break;

                    case (int)MenuItemType.AboutUs:
                        MenuPages.Add(id, new NavigationPage(new AboutUsPage()));
                        break;
                }
            }
            
            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}