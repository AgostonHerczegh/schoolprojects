using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teki
{
    class Program
    {
        static void Main(string[] args)
        {
            Food[] foods = new Food[15];
            foods[0] = new Salad();
            foods[1] = new Crab(6);
            foods[2] = new Crab(3);
            foods[3] = new Salad(); 
            foods[4] = new Crab(25);
            foods[5] = new Crab(1);
            foods[6] = new Crab(10);
            foods[7] = new Crab(10);
            foods[8] = new Crab(10);
            foods[9] = new Crab(10);
            foods[10] = new Crab(10);
            foods[11] = new Crab(10);
            foods[12] = new Crab(10);
            foods[13] = new Crab(10);
            foods[14] = new Crab(10);
            Turtle turtle = new Turtle();
            for (int i = 0; i < foods.Length; i++)
            {
                turtle.Eat(foods[i].Calories());
            }
        }
    }
}
