using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Eren.MealFolder
{
    public class Pizza: Meal
    {
        public PizzaSize PizSize { get; set; }

        public PizzaType PizType { get; set; }

        public Pizza()
        {
            Name = "Pizza";
            Price = 10;
            Count = 0;
        }

        public string GetReceipt() => $"{PizSize} {PizType} {Name} X({Count}) ";
         
    }

    public enum PizzaSize
    {
        Little,
        Medium,
        Big

    }

    public enum PizzaType
    {
        Hot,
        Mashroom,
        Cheese

    }
}
