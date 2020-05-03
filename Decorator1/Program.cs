using System;

namespace Decorator1
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleMessage simpleMessage = new SimpleMessage("Simple Message");
            simpleMessage.PrintMessage();

            AlertMessage alertMessage = new AlertMessage("Alert Message");
            alertMessage.PrintMessage();

            Console.WriteLine("Decorator starting");

            NormalDecorator normalDecorator = new NormalDecorator(simpleMessage);
            ErrorDecorator errorDecorator = new ErrorDecorator(normalDecorator);
            errorDecorator.PrintMessage();
            
     

            Console.ReadLine();
        }
    }
}
