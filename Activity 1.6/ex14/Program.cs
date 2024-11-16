namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            const string path = @"..\..\..\..\FITXERS PER RECORREGUTS\";
            StreamReader fitxer = new StreamReader(path + "tiquetsuper.txt");
            string linia;
            int productes, quantitat;
            double preu, total = 0;

            //Llegir fitxer
            productes = Convert.ToInt32(fitxer.ReadLine());

            for (int i = 0; i < productes; i++)
            {
                linia = fitxer.ReadLine(); //nom del producte
                linia = fitxer.ReadLine();
                quantitat = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
                preu = Convert.ToDouble(linia);
                total += quantitat * preu;
            }
            fitxer.Close();
            Console.WriteLine($"El preu total del tiquet és {total}");
        }
    }
}
