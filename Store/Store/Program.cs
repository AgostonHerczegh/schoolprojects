namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture[] Furniture = new Furniture[3];

            Furniture[0] = new Table(10);
            Furniture[1] = new Bed(200, 180);
            Furniture[2] = new Chair(4);

            for (int i = 0; i < Furniture.Length; i++)
            {
                Furniture[i].Print();
            }
        }

    }
}
