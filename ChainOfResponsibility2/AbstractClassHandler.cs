using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility2
{
    abstract class AbstractClassHandler : ICarServiceHandler
    {
        protected ICarServiceHandler _nexthandler;
        protected ServiceRequirements _servicesProvided;

        public AbstractClassHandler(ServiceRequirements _servicesProvided)
        {
            this._servicesProvided = _servicesProvided;
        }

        public virtual object ServiceHandler(AbstractClassCarService carService)
        {
            if ( !carService.IsServiceComplete() || this._nexthandler != null)
            {
                return this._nexthandler.ServiceHandler(carService);
            }
            else
            {
                return null;
            }
        }

        public ICarServiceHandler setNextHandler(ICarServiceHandler serviceHandler)
        {
            this._nexthandler = serviceHandler;
            return serviceHandler;
        }

    }
}
