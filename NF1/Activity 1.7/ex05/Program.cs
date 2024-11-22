namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num, sumaDivisors = 0;

            //Entrada de dades
            Console.Write("Introdueix un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Calculs
            //recorregut...
            //Millorar fent una cerca, si trobem suma divisors > num acabem i no recorrem tots els valors
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                    sumaDivisors+=i;
            }
            if (sumaDivisors == num)
                Console.WriteLine($"El numero {num} és perfecte");
            else
                Console.WriteLine($"El numero {num} no és perfecte");
        }
    }
}
