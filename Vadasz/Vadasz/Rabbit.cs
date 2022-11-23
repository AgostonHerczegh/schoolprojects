using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    class Rabbit : Animal
    {
        const double rabbitFactor = 0.3;
        public override double getP()
        {
            return base.getP() * rabbitFactor;
        }
        public override string getType()
        {
            return "Rabbit";
        }
    }
}
