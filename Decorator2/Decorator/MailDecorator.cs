using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2.Decorator
{
    public abstract class MailDecorator : IMail
    {
        protected IMail mail;
        public MailDecorator(IMail mail)
        {
            this.mail = mail;
        }

        public virtual void SendMail()
        {
            this.mail.SendMail();
        }
    }
}
