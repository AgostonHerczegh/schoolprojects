using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    class Squirrel : Animal
    {
        const double squirrelFactor = 1.2;
        public override double getP()
        {
            return base.getP() * squirrelFactor;
        }
        public override string getType()
        {
            return "Squirrel";
        }
    }
}
