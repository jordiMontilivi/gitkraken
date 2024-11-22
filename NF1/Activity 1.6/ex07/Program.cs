namespace ex07
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
            }
            Console.WriteLine($"La suma de 1 a {num} es {suma}");
        }
    }
}
