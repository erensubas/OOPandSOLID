using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility2
{
    interface ICarService
    {
        ServiceRequirements Requirements { get; set; }
        bool IsServiceComplete();
 
    }
}
