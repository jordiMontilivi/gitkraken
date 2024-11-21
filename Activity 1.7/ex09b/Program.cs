namespace ex09b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //simbolo € consola c#
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //llegir fitxers d'una carpeta
            //Variables per a elegir fitxers en la carpeta
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            //Array de strings que contendra los nombres de los ficheros
            //Ho vorem en un futur (col·lecció de dades string)
            string[] fitxers = Directory.GetFiles(path);
            string[] nomsFitxer = new string[fitxers.Length];
            int i = 0;

            //Variables per a fer el programa
            string linia;
            string nomFitxer;
            string producteColesterol = "";
            double importTotal = 0;
            int ricColesterol = 0;

            //Entrada de dades
            Console.WriteLine("Elegeix un fitxer");
            foreach (string fitxer in fitxers)
            {
                nomFitxer = fitxer.Substring(fitxer.LastIndexOf(@"\") + 1);
                if (nomFitxer.Contains("TIQUET"))
                {
                    //nomsFitxer[i] = fitxers[i];
                    nomsFitxer[i] = nomFitxer;
                    Console.WriteLine($"{i} - {nomFitxer}");
                    i++;
                }
            }

            Console.Write("\nElegeix una opcio: ");
            nomFitxer = nomsFitxer[Convert.ToInt32(Console.ReadLine())];

            Console.Clear();    

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
                            $"L'import total que hem gastat és {Math.Round(importTotal,2)}€");
                    else
                        Console.WriteLine($"Compra SANA, no conté cap producte amb colesterol\n" +
                            $"L'import total que hem gastat és {Math.Round(importTotal, 2)}€");
                }
            }
            else
                Console.WriteLine($"Fitxer {nomsFitxer} no exiesteix");
        }
    }
}
