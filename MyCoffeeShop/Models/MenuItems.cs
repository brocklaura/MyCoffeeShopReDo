using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoffeeShop.Models
{
    public class MenuItems
    {
        private static string[] IOH = { "Iced", "Hot" };
        private static string[] flavors = { "Vanilla", "Caramel", "None" };
        private static string[] type = { "Latte", "Espresso", "Frappe" };
        public static double ItemPrice = 4.25;
        internal static double itemPrice;

        public static string[] IOH1 { get => IOH; set => IOH = value; }
        public static string[] Flavors { get => flavors; set => flavors = value; }
        public static string[] Type { get => type; set => type = value; }
    }
}
