namespace ex10b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont4 = 0;
            for (int i = 0; i <= 300; i += 4)
            {
                Console.WriteLine($"{i}");
                cont4++;
                if (cont4 == 20)
                {
                    Console.ReadKey();
                    Console.Clear();
                }
            }
        }
    }
}
