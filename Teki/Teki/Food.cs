using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teki
{
    abstract class Food
    {
        public virtual int Calories()
        {
            return 0;
        }
    }
}
