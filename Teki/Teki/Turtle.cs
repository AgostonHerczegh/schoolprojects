using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Teki
{
    class Turtle : Food
    {
        public uint happiness= 0;
        public int fedLevel = 0;
        public void Eat(int eat)
        {
            fedLevel+=Calories();
            if (fedLevel>1000)
            
                Console.WriteLine("Turtle is full.");
            
            if (fedLevel<500)
            {
                Console.WriteLine("Eaten calories are less than 500, turtle is gaining happiness.");
                happiness++;
            }
            else
            {
                Console.WriteLine("Eaten calories are above 500, turtle is losing happiness.");
                happiness--;
            }
            Console.WriteLine("Turtle's happiness is " + happiness);
            Console.WriteLine("");
        }
    
    }
}
