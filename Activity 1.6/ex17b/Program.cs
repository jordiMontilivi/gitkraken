namespace ex17b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taula multiplicar
            for (int i = 0; i <= 10; i++)
            {
                MostrarTaula(i);
                Console.WriteLine();
                // Console.Clear();
            }
        }
        static void MostrarTaula(int num)
        {
            Console.WriteLine($"Taula del {num}");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
