using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;

namespace ex06c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Donada una seqüència de valors procedents d’un fitxer, informar per a cada valor,
            //si és primer o no(CERCA O RECORREGUT ?) Usar el fitxer ALGUNSPRIMERS.TXT

            //Recorregut

            //Variables
            int num, i = 2;
            StreamReader sr = new StreamReader("ALGUNSPRIMERS.TXT");
            string linia;

            //Llegir fitxer
            linia = sr.ReadLine();

            //recorregut del fitxer informant si es primer o no
            while (linia != null)
            {
                num = Convert.ToInt32(linia);
                if (EsPrimer(num))
                    Console.WriteLine($"El numero {num} és primer");
                else
                    Console.WriteLine($"El numero {num} no és primer");
                linia = sr.ReadLine();
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
