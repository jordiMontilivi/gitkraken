namespace ex05b
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
            if (EsPerfecet(num))
                Console.WriteLine($"El numero {num} és perfecte");
            else
                Console.WriteLine($"El numero {num} no és perfecte");
        }
        static bool EsPerfecet( int num)
        {
            int sumaDivisors = 0;
            bool perfecte = false;
            int i = 1;
            while (i <= num / 2 && sumaDivisors <= num)
            {
                if (num % i == 0)
                    sumaDivisors += i;
                i++;
            }
            if (sumaDivisors == num)
                perfecte = true;
            return perfecte;
        }
    }
}
