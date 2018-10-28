using System;
using System.Collections.Generic;
using System.Text;

namespace IntStd1.Models
{
    public enum MenuItemType
    {
        //IntStd,
        Dashboard,
        Essentials,
        Shop,
        //Eat,
        Transportation,
        Jobs,
        Rooms,
        Emergency,
        //Others,
        AboutDev,
        About,
        Help,
        AboutUs
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
