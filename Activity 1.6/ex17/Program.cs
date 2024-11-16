namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taula multiplicar
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Taula del {i}");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
                // Console.Clear();
            }
        }
    }
}
