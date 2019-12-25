using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Eren.MealFolder
{
    public class Coca: Meal
    {
        public CocaType cocType { get; set; }
        public Coca()
        {
            Name = "Coca Cole";
            Price = 5;
            Count = 0;
        }

        public string GetReceipt() => $"{cocType} {Name} X({Count}) ";
    }

    public enum CocaType
    {
        Zero,
        Normal

    }
}
