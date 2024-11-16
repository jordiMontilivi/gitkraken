namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //taula multiplicar
            int num;
            Console.Write("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
