using AbstractAndInterface.OyuncuFolder;
using AbstractAndInterface.SilahStructure.Silahlar;
using System;

namespace AbstractAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Oyuncu _oyuncu = new Oyuncu();
            _oyuncu.Ad = "Eren Subaş";
            _oyuncu.Yas = 35;
            _oyuncu.YasamDegeri = 100;
            _oyuncu.OyuncununSilahi = new M51();
            _oyuncu.NisanAl();
            _oyuncu.Yakinlastir();


            _oyuncu.OyuncununSilahi = new Kama();
            _oyuncu.NisanAl();
            _oyuncu.Yakinlastir();


            Console.ReadLine();
        }
    }
}
