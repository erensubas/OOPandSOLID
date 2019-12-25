using System;
using System.Collections.Generic;
using System.Text;

namespace Observer1
{
    public class Observer
    {
        private ConsoleColor _color;
        public Observer(ConsoleColor color)
        {
            this._color = color;
        }

        public void ObserverQuantity(int quantity)
        {
            Console.ForegroundColor = this._color;
            Console.WriteLine($"I observer the new quantity value of {quantity}.");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
