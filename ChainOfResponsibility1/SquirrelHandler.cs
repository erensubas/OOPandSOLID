using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility1
{
    public class SquirrelHandler:AbstractClassHandler
    {
        public override object Handler(object request)
        {
            if (request.ToString() == "Nut")
            {
                return $"Squirrel: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handler(request);
            }
        }
    }
}
