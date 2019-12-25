using AbstractAndInterface.SilahStructure;
using AbstractAndInterface.SilahStructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface.OyuncuFolder
{
    public class Oyuncu
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public int YasamDegeri { get; set; }

        public Silah OyuncununSilahi { get; set; }
        public void NisanAl()
        {
            OyuncununSilahi.NisanAl();
        }

        public void Yakinlastir()
        {
            if (OyuncununSilahi is IYakinlastirilabilir)
            {
                IYakinlastirilabilir zoom = (IYakinlastirilabilir)OyuncununSilahi;
                zoom.Yakinlasitr();
            }

        }

        public void Saldir()
        {

        }
    }
}
