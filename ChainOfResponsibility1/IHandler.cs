using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility1
{
    public interface IHandler
    {
        IHandler SetNextHandler(IHandler handler);

        object Handler(object request);
    }
}
