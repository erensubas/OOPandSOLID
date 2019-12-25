using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IPetFood
    {
        int Energy { get; }
    }

    public class Kibble : IPetFood
    {
        public int Energy => 7;
    }

    public class Fish : IPetFood
    {
        int IPetFood.Energy => 8;
    }
}
