namespace ex06ff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriu un programa que demani un valor primers per teclat, i mostri per pantalla els primers primers nombres primers.
            //Variables
            int primers, i = 1;

            //Entrada de dades
            Console.Write("Introdueix un primers: ");
            primers = Convert.ToInt32(Console.ReadLine());

            //Calculs
            while (primers > 0)
            {
                if (EsPrimer(i))
                {
                    Console.WriteLine(i);
                    //decrementem el contador de nombres primers solament si es primer
                    primers--;
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
