namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture[] Furnitures = new Furniture[3];

            Furnitures[0] = new Table(10);
            Furnitures[1] = new Bed(200, 180);
            Furnitures[2] = new Chair(4);

            for (int i = 0; i < Furnitures.Length; i++)
            {
                Furnitures[i].Print();
            }
        }

    }
}
