using System;

namespace Observer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject _subject = new Subject();
            _subject.UpdateQuantity(3);


            Observer greenObserver = new Observer(ConsoleColor.Green);
            Observer yellowObserver = new Observer(ConsoleColor.Yellow);
            Observer redObserver = new Observer(ConsoleColor.Red);

            _subject.OnquantityUpdated += greenObserver.ObserverQuantity;
            _subject.OnquantityUpdated += yellowObserver.ObserverQuantity;
            _subject.OnquantityUpdated += redObserver.ObserverQuantity;

            _subject.UpdateQuantity(4);
            _subject.UpdateQuantity(5);


            Console.ReadLine();
        }
    }
}
