using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Eren.MealFolder
{
    public class Soup: Meal
    {
        public SoupType SpType { get; set; }
        public Soup()
        {
            Name = "Soup";
            Price = 6;
            Count = 0;
        }

        public string GetReceipt() => $"{SpType} {Name} X({Count}) ";
    }

    public enum SoupType
    {
        Mercimek,
        Ezo

    }
}
