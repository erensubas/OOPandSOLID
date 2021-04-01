using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PetFeed.enums.Enums;

namespace PetFeed.interfaces
{
    interface IAnimal
    {
        public string Name { get; set; }
        public AnimalColor Color { get; set; }

        public void Feed(IFood food);

        public string MyPet();

    }
}
