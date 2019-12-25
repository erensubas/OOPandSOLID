using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Decorator
{
    public class SifreliMail: MailDecorator
    {
        public SifreliMail(IMail mail): base(mail)
        {

        }

        public override void SendMail()
        {
            Console.WriteLine("Şifreleme Yapıldı");
            base.SendMail();
        }
    }
}
