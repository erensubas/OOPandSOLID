using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility1
{
    public class AbstractClassHandler : IHandler
    {
        private IHandler _nextHandler;

        public virtual object Handler(object request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handler(request);
            }
            else
            {
                return null;
            }
        }

        public IHandler SetNextHandler(IHandler handler)
        {
            this._nextHandler = handler;
            return handler;
        }
    }
}
