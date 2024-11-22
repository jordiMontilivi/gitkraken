namespace ex05a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num, sumaDivisors = 0, i;

            //Entrada de dades
            Console.Write("Introdueix un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Calculs
            //recorregut...
            //Millorar fent una cerca i si suma divisors > num acabem i no recorrem tots els valors
            //agafem el primer valor 
            i = 1;
            while(i != num && sumaDivisors <= num)
            {
                if (num % i == 0)
                    sumaDivisors += i;
                i++;
            }
            if (sumaDivisors == num)
                Console.WriteLine($"El numero {num} és perfecte");
            else
                Console.WriteLine($"El numero {num} no és perfecte");
        }
    }
}
