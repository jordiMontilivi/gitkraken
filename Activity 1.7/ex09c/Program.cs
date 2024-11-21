namespace ex09c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Llegir un fitxer i trobar subcadena pizz o embotit
            //linia.Contains("pizz") || linia.Contains("embotit")...
            //Ara podem posar fins a 5 productes amb colesterol pero importen les quantitats

            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            string linia;
            string nomFitxer;
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
                while (linia != null && ricColesterol < 6)
                {
                    if (linia.Contains("pizz") || linia.Contains("embotit"))
                    {
                        ricColesterol += Convert.ToInt32(fitxer.ReadLine());
                    }

                    //Descartem el preu
                    fitxer.ReadLine();

                    //Llegim següent linia
                    linia = fitxer.ReadLine();
                }
                fitxer.Close();

                //Sortida de dades
                if (ricColesterol == 6)
                    Console.WriteLine("Rebutgem la compra");
                else
                    Console.WriteLine("No rebutgem la compra");
            }
        }
    }
}
