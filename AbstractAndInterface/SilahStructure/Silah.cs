using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractAndInterface.SilahStructure
{
    public abstract class Silah
    {
        public int Agirlik { get; set; }
        public int VurucuGucu { get; set; }

        public abstract void NisanAl();

    }
}
