using AbstractAndInterface.SilahStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface.SilahStructure.Silahlar
{
    public class Kama : KesiciSilah, IEldeTutulabilir
    {
        public void Firlat()
        {
            Console.WriteLine("Kama Fırlatıldı..");
        }

        public override void NisanAl()
        {
            Console.WriteLine("Kama Dikleştirildi..");
        }

    }
}
