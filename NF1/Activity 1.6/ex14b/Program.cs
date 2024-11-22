using System.Text;

namespace ex14b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fer el mateix que l'anterior però mostrar en mode tiquet
            //Variables
            const string path = @"..\..\..\..\FITXERS PER RECORREGUTS\";
            StreamReader fitxer = new StreamReader(path + "tiquetsuper.txt");
            string linia;
            int productes, quantitat;
            double preu, total = 0;
            string tiquet = "";
            StringBuilder sb = new StringBuilder();

            //Llegir fitxer
            productes = Convert.ToInt32(fitxer.ReadLine());

            for (int i = 0; i < productes; i++)
            {
                linia = fitxer.ReadLine(); //nom del producte
                tiquet += linia + "\t";
                linia = fitxer.ReadLine();
                quantitat = Convert.ToInt32(linia);
                tiquet += quantitat + "  x\t";
                linia = fitxer.ReadLine();
                preu = Convert.ToDouble(linia);
                tiquet += preu + "\n";
                total += quantitat * preu;
            }
            fitxer.Close();
            tiquet += $"TOTAL \t\t\t{total}";
            Console.WriteLine(tiquet);
        }
    }
}
