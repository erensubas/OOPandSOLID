using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility2
{
    interface ICarServiceHandler
    {
        ICarServiceHandler setNextHandler(ICarServiceHandler serviceHandler);
        object ServiceHandler(AbstractClassCarService carService);
    }

    [Flags]
    enum ServiceRequirements
    {
        None = 0,
        WheelAlignment = 1,
        Dirty = 2,
        EngineTune = 4,
        TestDrive = 8
    }
}
