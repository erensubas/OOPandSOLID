using PetFeed.enums;
using PetFeed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFeed
{
    public class Animal : IAnimal
    {
        public string Name { get ; set; }
        public Enums.AnimalColor Color { get ; set; }

        private int _hungrLevel;

        protected Animal(string petName, Enums.AnimalColor petColor)
        {
            Name = petName;
            Color = petColor;
        }

        public string MyPet() => $"Benim adım {Name}, Rengim {Color}, Açlık Durumum {_hungrLevel}";

        public virtual void Feed(IFood food)
        {
            _hungrLevel -= food.Energy;
        }
    }
}
