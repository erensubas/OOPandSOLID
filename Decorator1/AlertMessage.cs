using Decorator1.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator1
{
    public class AlertMessage : Message
    {
        public AlertMessage(string text): base(text)
        {

        }
        public override void PrintMessage()
        {
            Console.Beep();
            Console.WriteLine(_text);
        }
    }
}
