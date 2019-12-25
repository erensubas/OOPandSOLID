﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ConsoleApp1
{
    public class PetAnimal
    {
        private readonly string PetName;
        public readonly PetColor PetColor;
        private int _hunger;

        protected PetAnimal(string petName, PetColor petColor)
        {
            PetName = petName;
            PetColor = petColor;
        }

        public virtual void Feed(IPetFood food)
        {
            Eat(food);
        }

        protected void Eat(IPetFood food)
        {
            _hunger -= food.Energy;
        }

        public string MyPet() => $"My pet is {PetName} and its color is {PetColor.Color}. My Energy is {_hunger}";
    }
}
