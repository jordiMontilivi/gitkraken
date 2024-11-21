namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            string linia;
            string nomFitxer;
            int dorsal, posicio = 1;

            //Entrada de dades
            Console.Write("Introdueix el nom del fitxer: ");
            nomFitxer = Console.ReadLine() + ".txt";

            //Comprovem si existeix el fitxer
            if (File.Exists(path + nomFitxer))
            {
                //Llegir fitxer
                StreamReader fitxer = new StreamReader(path + nomFitxer);
                linia = fitxer.ReadLine();
                dorsal = Convert.ToInt32(linia);

                //Cerca del fitxer fins trobar el dorsal o final
                while (linia != null && dorsal != 231)
                {
                    dorsal = Convert.ToInt32(linia);
                    posicio++;
                    linia = fitxer.ReadLine();
                }
                fitxer.Close();

                //Sortida de dades
                if (dorsal == 231)
                    Console.WriteLine($"Hem trobat el dorsal {dorsal} a la posició {posicio}");
                else
                    Console.WriteLine("No hem trobat el dorsal");
            }
            else
                Console.WriteLine("No existeix el fitxer");
            
        }
    }
}
