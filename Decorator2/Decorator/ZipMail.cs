using System;
using System.Collections.Generic;
using System.Text;
using Decorator2.Interface;

namespace Decorator2.Decorator
{
    public class ZipMail : MailDecorator
    {
        public ZipMail(IMail mail) : base(mail)
        {
        }

        public override void SendMail()
        {
            Console.WriteLine("Sıkıştırma Yapıldı");
            base.SendMail();
        }
    }
}
