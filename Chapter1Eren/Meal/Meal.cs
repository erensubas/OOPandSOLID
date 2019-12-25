using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Eren.MealFolder
{
    public class Meal 
    {
        protected string Name { get; set; }

        public decimal Price { get; set; }

        public int Count { get; set; }

        public string GetName() => $"Meal Name: {Name} Price: {Price}";
    }
}
