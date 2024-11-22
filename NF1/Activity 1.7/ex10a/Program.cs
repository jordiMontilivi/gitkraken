using System;

namespace ex10a
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
            string[] nomsFitxer = new string[fitxers.Length];
            int i = 0;

            //Variables per a fer el programa
            string linia;
            string nomFitxer;
            int rang = 0, musclos;

            //Entrada de dades
            Console.WriteLine("Elegeix un fitxer");
            foreach (string fitxer in fitxers)
            {
                nomFitxer = fitxer.Substring(fitxer.LastIndexOf(@"\") + 1);
                if (nomFitxer.Contains("PLAGA"))
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
                //Cerca del fitxer fins trobar 5 trams amb musclos majors a 500
                while (linia != null && rang < 5)
                {
                    musclos = Convert.ToInt32(linia);
                    if (musclos > 500)
                        rang++;
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
