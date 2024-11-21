namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simbolo € consola c#
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //Llegir un fitxer i trobar subcadena pizz o embotit
            //linia.Contains("pizz") || linia.Contains("embotit")...

            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            string linia;
            string nomFitxer;
            string producteColesterol ="";
            double importTotal = 0;
            int ricColesterol = 0;

            //Entrada de dades
            Console.Write("Introdueix el nom del fitxer: ");
            nomFitxer = Console.ReadLine() + ".txt";

            //Comprovem si existeix el fitxer
            if (File.Exists(path + nomFitxer))
            {
                //Llegir fitxer
                StreamReader fitxer = new StreamReader(path + nomFitxer);
                linia = fitxer.ReadLine();

                //Cerca del fitxer mentre no rebutgem la compra
                while (linia != null && ricColesterol < 2)
                {
                    if (linia.Contains("PIZZ") || linia.Contains("EMBOTIT"))
                    {
                        ricColesterol++;
                        producteColesterol = linia;
                    }
                    //Calculem import total llegint la quantitat i el preu del fitxer
                    importTotal += Convert.ToInt32(fitxer.ReadLine()) * Convert.ToDouble(fitxer.ReadLine());

                    //Llegim següent linia
                    linia = fitxer.ReadLine();
                }
                fitxer.Close();

                //Sortida de dades
                if (ricColesterol == 2)
                    Console.WriteLine("Rebutgem la compra per ser rica en colesterol");
                else
                {
                    if (ricColesterol == 1)
                        Console.WriteLine($"La compra conté únicament un producte amb colesterol, aquest és {producteColesterol}\n" +
                            $"L'import total que hem gastat és {Math.Round(importTotal, 2)}€");
                    else
                        Console.WriteLine($"Compra SANA, no conté cap producte amb colesterol\n" +
                            $"L'import total que hem gastat és {Math.Round(importTotal, 2)}€");
                }
            }
            else
                Console.WriteLine($"No existeix el fitxer {nomFitxer}.txt");
        }
    }
}
