using Decorator2.Decorator;
using System;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Mail mail = new Mail("Eren SUBAŞ", "Zehra Subaş");
 
            Console.WriteLine("Decorator starting");

            SifreliMail sifreliMail = new SifreliMail(mail);
            ZipMail zipMail = new ZipMail(sifreliMail);
            zipMail.SendMail();

            Console.ReadLine();
        }
    }
}
