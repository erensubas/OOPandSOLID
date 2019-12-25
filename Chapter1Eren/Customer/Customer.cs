using Chapter1Eren.MealFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Eren.CustomerFolder
{
    public interface ICustomer
    {
        string Name { get; set; }
        string Adress { get; set; }
        List<Meal> Orders { get; set; }
        void AddOrder(Meal meal);
        void DeleteOrder(Meal meal);
        void ClearOrder();
    }
    public class Customer : ICustomer
    {
        public string Name { get; set; }
        public string Adress { get; set; }

        private List<Meal> orders;

        public List<Meal> Orders
        {
            get {
                if (orders == null)
                {
                    orders = new List<Meal>();
                }
                return orders;
            }
            set {
                if(orders == null)
                {
                    orders = new List<Meal>();
                }
                orders = value;
            }
        }


        public void AddOrder(Meal meal)
        {
            Orders.Add(meal);
        }

        public void DeleteOrder(Meal meal)
        {
            Orders.Remove(meal);
        }

        public void ClearOrder()
        {
            Orders.Clear();
        }

    }
}
