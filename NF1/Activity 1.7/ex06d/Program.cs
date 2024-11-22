using static System.Net.Mime.MediaTypeNames;
using System.Runtime.ConstrainedExecution;

namespace ex06d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dona la mateixa seqüència del fitxer de l’apartat 6c, informar si hi ha algun nombre primer
            //a la seqüència(CERCA O RECORREGUT ?) Usar el fitxer ALGUNSPRIMERS.TXT

            //Cerca

            //Variables
            bool trobat = false;
            int num = 0;
            StreamReader sr = new StreamReader("ALGUNSPRIMERS.TXT");
            string linia;

            //Llegir fitxer
            linia = sr.ReadLine();

            //Cerca del fitxer fins trobar un numero primer o final
            while (linia != null && !trobat)
            {
                num = Convert.ToInt32(linia);
                trobat = EsPrimer(num);
                linia = sr.ReadLine();
            }

            if (trobat)
                Console.WriteLine($"Hem trobat un numero primer {num}");
            else
                Console.WriteLine("No hem trobat cap numero primer");

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
