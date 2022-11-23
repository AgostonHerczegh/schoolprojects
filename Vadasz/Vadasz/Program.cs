using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vadasz
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];

            animals[0] = new Rabbit();
            animals[1] = new PolarBear();
            animals[2] = new Squirrel();

            for (int i = 0; i < animals.Length; i++)
            {
                Console.Write(animals[i].getP() + "FT a prém" + " a(z) ");
                Console.Write(animals[i].getType() + " -nak/nek");
                Console.WriteLine("");
            }
        }
    }
}