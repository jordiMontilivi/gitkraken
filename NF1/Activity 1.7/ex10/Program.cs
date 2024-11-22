namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Concepte de Finestra
            //concepte de rang de valors

            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            string linia;
            string nomFitxer;
            int rang = 0, musclos;

            //Entrada de dades
            Console.Write("Introdueix el nom del fitxer: ");
            nomFitxer = Console.ReadLine() + ".txt";

            //Comprovem si existeix el fitxer
            if (File.Exists(path + nomFitxer))
            {
                //Llegir fitxer
                StreamReader fitxer = new StreamReader(path + nomFitxer);
                linia = fitxer.ReadLine();
                //Cerca del fitxer fins trobar 5 trams amb musclos majors a 500
                while (linia != null && rang < 5)
                {
                    musclos = Convert.ToInt32(linia);
                    if (musclos > 500 )
                        rang ++;
                    else
                        rang = 0;

                    linia = fitxer.ReadLine();
                }
                fitxer.Close();
                if (rang == 5)
                    Console.WriteLine("HI HA PLAGA\n" +
                        "Hem trobat 5 trams amb musclos majors a 500");
                else
                    Console.WriteLine("NO HI HA PLAGA\n" +
                        "No hem trobat 5 trams amb musclos majors a 500");
            }
            else
                Console.WriteLine($"No existeix el fitxer {nomFitxer}.txt");
        }
    }
}
