using System;

namespace ChainOfResponsibility2
{
    class Program
    {
        static void Main(string[] args)
        {
            var mechanic = new Mechanic();
            var detailer = new Detailer();
            var wheels = new WheelSpecialist();
            var qa = new QualityControl();

            qa.setNextHandler(detailer);
            wheels.setNextHandler(qa);
            mechanic.setNextHandler(wheels);


            Console.WriteLine("Car 1 is dirty");
            Console.WriteLine(mechanic.ServiceHandler(new AbstractClassCarService { Requirements = ServiceRequirements.Dirty }));
            Console.WriteLine();
            Console.WriteLine("Car 2 requires full service");
            Console.WriteLine(
            mechanic.ServiceHandler(new AbstractClassCarService
            {
                Requirements = ServiceRequirements.Dirty |
            ServiceRequirements.EngineTune |
            ServiceRequirements.TestDrive |
            ServiceRequirements.WheelAlignment
            })
            );


            Console.Read();
        }
    }
}
