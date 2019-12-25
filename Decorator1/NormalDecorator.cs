using Decorator1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator1
{
    public class NormalDecorator : MessageDecorator
    {
        public NormalDecorator(IMessage message): base(message)
        {

        }
        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("NormalDecorator init");
            _message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
