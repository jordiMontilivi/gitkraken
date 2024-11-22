namespace ex07b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, suma = 0;
            Console.Write("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                suma += i;
                if (i == num)
                    Console.Write($"{i} = ");
                else 
                    Console.Write($"{i} + ");
            }
            Console.WriteLine($"{suma}");
        }
    }
}
