namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Furniture[] bútorok = new Furniture[3];

            bútorok[0] = new Table(10);
            bútorok[1] = new Bed(200, 180);
            bútorok[2] = new Chair(4);

            for (int i = 0; i < bútorok.Length; i++)
            {
                bútorok[i].Print();
            }
        }

    }
}
