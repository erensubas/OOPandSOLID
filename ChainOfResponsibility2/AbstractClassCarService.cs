using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility2
{
    class AbstractClassCarService : ICarService
    {
        public ServiceRequirements Requirements { get; set; }
        public bool IsServiceComplete()
        {
           return Requirements == ServiceRequirements.None;
        }

    }
}
