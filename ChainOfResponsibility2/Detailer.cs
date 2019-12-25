using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility2
{
    class Detailer : AbstractClassHandler    
    {
        public Detailer(): base(ServiceRequirements.Dirty)
        {

        }

        public override object ServiceHandler(AbstractClassCarService carService)
        {
            if (_servicesProvided == (carService.Requirements & _servicesProvided))
            {
                carService.Requirements &= ~_servicesProvided;
                Console.WriteLine($"{this.GetType().Name} providing {this._servicesProvided} services.");
            }
            
             return base.ServiceHandler(carService);

        }

    }
}
