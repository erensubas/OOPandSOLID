using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility1
{
    public class DogHandler : AbstractClassHandler
    {
        public override object Handler(object request)
        {
            if (request.ToString() == "MeatBall")
            {
                return $"Dog: I'll eat the {request.ToString()}.\n";
            }
            else
            {
                return base.Handler(request);
            }
        }
    }
}
