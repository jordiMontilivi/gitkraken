namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int num, suma = 0;

            for(int i= 0; i < 10; i++)
            {
                Console.Write("Escriu un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                suma += num;
            }
            Console.WriteLine($"La suma dels numeros entrats és {suma}");

        }
    }
}
