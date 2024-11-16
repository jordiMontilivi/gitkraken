namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont4 = 0;
            for (int i = 0; i <= 300; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine($"{i}");
                    cont4++;
                }
                if (cont4 == 20)
                {
                    Console.ReadKey();
                    cont4 = 0;
                }
            }
        }
    }
}
