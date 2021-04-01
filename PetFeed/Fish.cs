using PetFeed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFeed
{
    public class Fish : IFood
    {
        public int Energy => 10; 
    }
}
