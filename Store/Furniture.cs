using System;

namespace Store
{
    abstract class Furniture
    {
        protected int ID;
        static int basePrice = 25000;
        public Furniture()
        {
            this.ID = getID();
        }
        public virtual double Price()
        {
            return basePrice;
        }
        public int getID()
        {
            return ID++;
        }
        public virtual void Print()
        {
            Console.WriteLine("Price of furniture:" + Price());
        }
    }
}
