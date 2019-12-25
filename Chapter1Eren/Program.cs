using Chapter1Eren.CustomerFolder;
using Chapter1Eren.MealFolder;
using Chapter1Eren.OrderFolder;
using System;

namespace Chapter1Eren
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pizza piz = new Pizza();
            piz.Count = 2;

            Coca cc = new Coca();
            cc.cocType = CocaType.Normal;
            cc.Count = 2;
            
            Customer cust = new Customer();
            cust.Adress = "İstanbul";
            cust.Name = "Eren SUBAŞ";

            Order ord1 = new Order();
            ord1.AddOrder(cust, piz);
            ord1.AddOrder(cust, cc);

         
            Console.WriteLine(piz.GetReceipt());
            Console.WriteLine(cc.GetReceipt());

            Console.WriteLine(ord1.Receipt(cust));

            Console.ReadLine();
        }
    }
}
