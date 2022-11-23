using System;

namespace Store
{
    class Bed : Furniture
    {
        protected int length;
        protected int width;
        public Bed(int length, int width) : base()
        {
            this.length = length;
            this.width = width;
        }
        protected double bedFactor = 2.4;
        public override double Price()
        {
            return base.Price() * bedFactor;

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("ID:" + getID());
            Console.WriteLine("Length of the bed:" + length);
            Console.WriteLine("Width of the bed:" + width);

        }
    }
}
