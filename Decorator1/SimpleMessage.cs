using Decorator1.BaseClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator1
{
    public class SimpleMessage : Message
    {
        public SimpleMessage(string text): base(text)
        {

        }

        public override void PrintMessage()
        {
            Console.WriteLine(_text);
        }
    }
}
