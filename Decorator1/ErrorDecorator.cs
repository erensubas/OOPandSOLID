using Decorator1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator1
{
    public class ErrorDecorator: MessageDecorator
    {
        
        public ErrorDecorator(IMessage message): base(message)
        {

        }

        public override void PrintMessage()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ErrorDecorator init");
            _message.PrintMessage();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
