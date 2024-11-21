namespace ex06f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriu un programa que demani un valor numero per teclat, i mostri per pantalla els numero primers nombres primers.
            //Variables
            int numero, i = 1, contPrimer = 0;

            //Entrada de dades
            Console.Write("Introdueix un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //Calculs
            while (contPrimer < numero)
            {
                if (EsPrimer(i))
                {
                    Console.WriteLine(i);
                    //incrementem el contador de nombres primers solament si es primer
                    contPrimer++;
                }
                i++;
            }
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
