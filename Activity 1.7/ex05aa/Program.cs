namespace ex05aa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //els 5 primers numeros perfectes son 6, 28, 496, 8128, 33550336
            //Variables
            int num = 1, sumaDivisors = 0, i, contPerfecte = 0;

            //Calculs
            //Millorar fent una cerca i si suma divisors > num acabem i no recorrem tots els valors
            //agafem el primer valor 
            while (contPerfecte < 5)
            {
                i = 1;
                sumaDivisors = 0;
                while (i <= num/2 && sumaDivisors <= num)
                {
                    if (num % i == 0)
                        sumaDivisors += i;
                    i++;
                }
                if (sumaDivisors == num)
                {
                    Console.WriteLine($"El numero {num} és perfecte");
                    contPerfecte++;
                }
                num++;
            }
        }
    }
}
