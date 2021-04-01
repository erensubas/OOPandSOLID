using PetFeed.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetFeed
{
    public static class PetFeeder
    {
        public static void Feed<TA,TF>(Animal petAnimal, IFood petFood) where TA: Animal where TF: IFood
        {
            petAnimal.Feed(petFood);
        }
    }
}
