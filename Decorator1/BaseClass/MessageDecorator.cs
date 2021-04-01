using Decorator1.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator1
{
    public abstract class MessageDecorator: IMessage
    {
        protected IMessage _message;
        public MessageDecorator(IMessage message)
        {
            this._message = message;
        }

        public abstract void PrintMessage();
    }
}
