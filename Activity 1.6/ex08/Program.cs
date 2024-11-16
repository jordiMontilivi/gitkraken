namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, producte = 1;
            Console.Write("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                producte *= i;
                if (i == num)
                    Console.Write($"{i} = ");
                else
                    Console.Write($"{i} x ");
            }
            Console.WriteLine($"{producte}");
        }
    }
}
