namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio de variables
            double radi, x = 0, y = 0;
            double distancia;
            int cont = 0, dintre = 0;
            string linia;
            //StreamReader sr = new StreamReader("coordenades.txt");
            StreamReader sr = new StreamReader(@"..\..\..\..\FITXERS PER RECORREGUTS\coordenades.txt");
            
            bool local = false; //el girona juga de local

            //Demanar el valor del radi a l'usuari
            Console.Write("Escriu el valor del radi: ");
            radi = Convert.ToDouble(Console.ReadLine());

            //demanar primer valor
            linia = sr.ReadLine();

            //Mentre no final
            while (linia != null)
            {
                if (cont % 2 == 0)
                    x = Convert.ToDouble(linia.Replace(".", ","));
                else
                {
                    y = Convert.ToDouble(linia.Replace(".", ","));
                    distancia = Math.Round(Distancia(x, y),2);
                    if(radi > distancia)
                        Console.WriteLine($"Les coordenades ({Math.Round(x,2)}:{Math.Round(y,2)}) està a una distancia {distancia} del centre per tant està dintre del radi {radi} amb oritge (0:0)");
                    else
                        Console.WriteLine($"Les coordenades ({Math.Round(x, 2)}:{Math.Round(y, 2)}) està a una distancia {distancia} del centre per tant està fora del radi {radi} amb oritge (0:0)");
                }
                cont++;
                //demanar següent
                linia = sr.ReadLine();
            }
            //Mostrar els resultats
        }
        static double Distancia(double x, double y)
        {
            double resultat;
            resultat = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            return resultat;
        }
    }
}
