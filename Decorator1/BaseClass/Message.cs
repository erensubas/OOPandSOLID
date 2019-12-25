using Decorator1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator1.BaseClass
{
    public abstract class Message : IMessage
    {
        public string _text { get; set; }
        public Message(string text)
        {
            _text = text;
        }
        abstract public void PrintMessage();

    }
}
