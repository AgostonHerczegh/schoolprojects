using System;

namespace Store
{
    class Table : Furniture
    {
        protected int height;
        protected double tableFactor = 0.3;

        public override double Price()
        {
            return base.Price() * tableFactor;

        }
        public Table(int height) : base()
        {
            this.height = height;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("ID:" + getID());
            Console.WriteLine("Height of the table:" + height);
        }
    }
}
