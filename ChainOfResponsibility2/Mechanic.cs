using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility2
{
    class Mechanic: AbstractClassHandler    
    {
        public Mechanic(): base(ServiceRequirements.EngineTune)
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
