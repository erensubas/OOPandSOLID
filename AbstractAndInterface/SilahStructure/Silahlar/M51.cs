using AbstractAndInterface.SilahStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface.SilahStructure.Silahlar
{
    public class M51 : AtesliSilah, IYakinlastirilabilir
    {
        public override void NisanAl()
        {
            Console.WriteLine("Nişan Alındı...");
        }

        public void Yakinlasitr()
        {
            Console.WriteLine("Hedef Yakınlaştırıldı...");
        }
    }
}
