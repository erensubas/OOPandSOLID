using Decorator2.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class Mail : IMail
    {
        public string _kimden { get; set; }
        public string _kime { get; set; }

        public Mail(string kimden, string kime)
        {
            this._kimden = kimden;
            this._kime = kime;

        }
        public void SendMail()
        {
            Console.WriteLine("Mail, {0} dan {1} e gönderildi", _kimden, _kime);
        }
    }
}
