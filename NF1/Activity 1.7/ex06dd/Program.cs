namespace ex06dd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dona la mateixa seqüència del fitxer de l’apartat 6c, informar si hi ha algun nombre primer
            //a la seqüència(CERCA O RECORREGUT ?) Usar el fitxer ALGUNSPRIMERS.TXT

            //Cerca

            //Variables
            StreamReader sr = new StreamReader("ALGUNSPRIMERS.TXT");
            string linia;

            //Llegir fitxer
            //Cerca del fitxer fins trobar un numero primer o final
            //bucle que no te instruccions
            //Compactem la lectura de la linia i la comprovació de si és primer en una sola instrucció
            //No fem aixo, dificulta la lectura del codi
            while ((linia = sr.ReadLine()) != null && !EsPrimer(Convert.ToInt32(linia)));

            if (linia != null)
                Console.WriteLine($"Hem trobat un numero primer {Convert.ToInt32(linia)}");
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
