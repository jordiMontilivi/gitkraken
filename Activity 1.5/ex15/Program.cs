namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio de variables
            int rival = 0, girona , punts = 0, guanyats = 0, perduts = 0, empatats = 0, cont = 0;
            string linia;
            //StreamReader sr = new StreamReader("Girona lliga23_24.txt");
            StreamReader sr = new StreamReader(@"..\..\..\..\FITXERS PER RECORREGUTS\Girona lliga23_24.txt");

            //demanar primer valor
            linia = sr.ReadLine();
            while (linia != null)
            {
                if(cont %2 == 0)
                    rival = Convert.ToInt32(linia);
                else
                {
                    girona = Convert.ToInt32(linia);
                    if (girona > rival)
                    {
                        guanyats++;
                        punts += 3;
                    }
                    else if (girona == rival)
                    {
                        empatats++;
                        punts++;
                    }
                    else
                        perduts++;
                    
                }
                cont++;
                //demanar següent
                linia = sr.ReadLine();
            }            
            //Mostrar els resultats
            Console.WriteLine("PJ\tPG\tPE\tPP\tPunts");
            Console.WriteLine($"{guanyats + perduts + empatats}\t{guanyats}\t{empatats}\t{perduts}\t{punts}");
            Console.WriteLine("\nValors per separat");
            Console.WriteLine($"Partits jugats: {guanyats + perduts + empatats}");
            Console.WriteLine($"Partits guanyats: {guanyats}");
            Console.WriteLine($"Partits empatats: {empatats}");
            Console.WriteLine($"Partits perduts: {perduts}");
            Console.WriteLine($"Percentantge partits guanyats: {Math.Round((double)guanyats * 100 / (guanyats + perduts + empatats), 2)}%");
            Console.WriteLine($"Punts aconseguits: {punts}");
        }
    }
}
