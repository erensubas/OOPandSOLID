using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility1
{
    public class MonkeyHandler:AbstractClassHandler
    {
        public override object Handler(object request)
        {
            if ((request as string) == "Banana")
            {
                return $"Monkey: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handler(request);
            }
        }
    }
}
