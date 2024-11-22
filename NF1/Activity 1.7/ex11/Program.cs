namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //llegir fitxers d'una carpeta
            //Variables per a elegir fitxers en la carpeta
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            //Array de strings que contendra los nombres de los ficheros
            //Ho vorem en un futur (col·lecció de dades string)
            string[] fitxers = Directory.GetFiles(path);

            //Variables per a fer el programa
            string linia;
            string nomFitxer;
            int sumaSilurs = 0, silurs;

            //Entrada de dades
            Console.WriteLine("Elegeix un fitxer");
            for (int i = 0; i<fitxers.Length;i++)
            {
                Console.WriteLine($"{i} - {fitxers[i].Substring(fitxers[i].LastIndexOf(@"\") + 1)}");
            }
            Console.Write("\nElegeix una opcio: ");
            int opcio = Convert.ToInt32(Console.ReadLine());
            nomFitxer = fitxers[opcio].Substring(fitxers[opcio].LastIndexOf(@"\") + 1);

            Console.Clear();
            //Comprovem si existeix el fitxer
            if (File.Exists(path + nomFitxer))
            {
                //Llegir fitxer
                StreamReader fitxer = new StreamReader(path + nomFitxer);
                linia = fitxer.ReadLine();
                silurs = Convert.ToInt32(linia);

                //Cerca del fitxer fins trobar 5 trams amb musclos majors a 500
                while (linia != null && silurs != 0)
                {
                    silurs = Convert.ToInt32(linia);
                    sumaSilurs += silurs;
                    linia = fitxer.ReadLine();
                }
                fitxer.Close();
                if (silurs == 0 || sumaSilurs < 10)
                    Console.WriteLine("HI HA PERILL EXTINCIO");
                else
                    Console.WriteLine("NO HI HA PERILL EXTINCIO");
            }
            else
                Console.WriteLine($"No existeix el fitxer {nomFitxer}.txt");
        }
    }
}
