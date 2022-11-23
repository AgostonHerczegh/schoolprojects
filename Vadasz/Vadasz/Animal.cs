using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    abstract class Animal
    {
        const int basePrice = 100000;
        public virtual double getP()
        {
            return basePrice;
        }
        public virtual string getType()
        {
            return " ";
        }
    }
}