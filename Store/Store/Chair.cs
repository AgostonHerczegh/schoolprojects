using System;

namespace Store
{
    class Chair : Furniture
    {
        protected double chairFactor = 1.2;
        protected int legs;
        public override double Price()
        {
            return base.Price() * chairFactor;

        }
        public Chair(int legs) : base()
        {
            this.legs = legs;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("ID:" + getID());
            Console.WriteLine("The chair has " + legs + " legs.");
        }
    }
}
