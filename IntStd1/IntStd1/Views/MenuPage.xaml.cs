using IntStd1.Models;
using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntStd1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
               // new HomeMenuItem {Id = MenuItemType.IntStd, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.Dashboard, Title="Home" },
                new HomeMenuItem {Id = MenuItemType.Essentials, Title="Essentials" },
                new HomeMenuItem {Id = MenuItemType.Shop, Title="Places To Shop" },
                //new HomeMenuItem {Id = MenuItemType.Eat, Title="Places To Eat" },
                new HomeMenuItem {Id = MenuItemType.Transportation, Title="Transportation" },
                new HomeMenuItem {Id = MenuItemType.Jobs, Title="Jobs" },
                new HomeMenuItem {Id = MenuItemType.Rooms, Title="Accomodation" },
                new HomeMenuItem {Id = MenuItemType.Emergency, Title="Emergency" },
                //new HomeMenuItem {Id = MenuItemType.Others, Title="Others" },
                new HomeMenuItem {Id = MenuItemType.AboutDev, Title="About Dev" },
                //new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                //new HomeMenuItem {Id = MenuItemType.Help, Title="Help"},
                //new HomeMenuItem {Id = MenuItemType.AboutUs, Title="About Us"}
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}