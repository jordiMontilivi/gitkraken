namespace ex06b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num;

            //Entrada de dades
            Console.Write("Introdueix un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Calculs
            if (EsPrimer(num))
                Console.WriteLine($"El numero {num} és primer");
            else
                Console.WriteLine($"El numero {num} no és primer");
        }
        static bool EsPrimer(int num)
        {
            int i = 2;
            bool esPrimer = true;
            while (i <= num / 2 && esPrimer)
            {
                if (num % i == 0)
                    esPrimer = false;
                i++;
            }
            return esPrimer && num > 1;
        }
    }
}
