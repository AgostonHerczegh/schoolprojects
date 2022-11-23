using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    class PolarBear : Animal
    {
        const double polarBearFactor = 2.4;
        public override double getP()
        {
            return base.getP() * polarBearFactor;
        }
        public override string getType()
        {
            return "Polar Bear";
        }
    }
}
