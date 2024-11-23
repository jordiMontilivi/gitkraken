namespace CrearFitxersCursa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\..\fitxers\";
            char opcio;
            Console.Write("Vols crear un fitxer(s/n): ");
            opcio = Console.ReadKey().KeyChar;
            while (opcio == 's')
            {
                Console.Clear();
                string nom, url;
                int quantitatDorsals, dorsalMin, dorsalMax, tempsInicial, tempsMax;
                StreamWriter fitxer;
                Random rnd = new Random();

                Console.WriteLine("Crearem un fitxer amb el nom escollit i valors randoms entre els rangs delimitats");
                Console.Write("Indica un nom: ");
                nom = Console.ReadLine();
                url = path + nom + ".txt";

                fitxer = new StreamWriter(url);

                Console.Write("Quants dorsals vols afegir: ");
                quantitatDorsals = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dorsal menor: ");
                dorsalMin = Convert.ToInt32(Console.ReadLine());
                Console.Write("Dorsal major: ");
                dorsalMax = Convert.ToInt32(Console.ReadLine());
                Console.Write("Temps inicial: ");
                tempsInicial = Convert.ToInt32(Console.ReadLine());
                Console.Write("Temps màxim: ");
                tempsMax = Convert.ToInt32(Console.ReadLine());
                fitxer.WriteLine(rnd.Next(dorsalMin, dorsalMax + 1));
                fitxer.WriteLine((tempsInicial));

                for (int i = 0; i < quantitatDorsals; i++)
                {
                    fitxer.WriteLine(rnd.Next(dorsalMin, dorsalMax +1));
                    fitxer.WriteLine(rnd.Next(1, tempsMax +1));
                }

                fitxer.Close();
                Console.WriteLine($"Fitxer {nom} afegit correctament ");

                Console.Write("\nVols crear un fitxer(s/n): ");
                opcio = Console.ReadKey().KeyChar;
            }
        }
    }
}
