using Chapter1Eren.CustomerFolder;
using Chapter1Eren.MealFolder;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter1Eren.OrderFolder
{
    public class Order
    {
        public void AddOrder(ICustomer customer, Meal meal)
        {
            if( meal is Pizza && meal.Count > 1)
            {
                customer.AddOrder(new Soup { Count = 1, SpType = SoupType.Ezo, Price = 0 });
            }

            customer.AddOrder(meal);
        }

        public void ClearOrder(ICustomer customer)
        {
            customer.ClearOrder();
        }

        public void DeleteOrder(ICustomer customer, Meal meal)
        {
            customer.DeleteOrder(meal);
        }

        public string Receipt(ICustomer customer)
        {
            string receipt = string.Empty;
            decimal totalPrice = 0;

            foreach (var item in customer.Orders)
            {
                receipt += item.GetName() + " Meal Price: " + item.Price * item.Count + "\n";
                totalPrice += item.Price * item.Count;
            }

            receipt += "TotalPrice: " + totalPrice;
            return receipt;
        }
    }
}
