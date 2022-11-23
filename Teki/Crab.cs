using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teki
{
    class Crab : Food
    {
        public Crab(int size)
        {
            if (size > 10 || size<1)
            {
                Console.WriteLine("Crab size is incorrect.");
            }
            else
            {
                this.size = size;
            }


        }
        int size = 1;
        public override int Calories()
        {
            return size * 10;
        }
    }
}
