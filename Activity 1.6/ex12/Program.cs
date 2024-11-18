namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            const string path = @"..\..\..\..\FITXERS PER RECORREGUTS\";
            StreamReader fitxer = new StreamReader(path + "coordenades2.txt");
            string linia;
            int coordenades;
            double x, y, radi, distancia;

            //Valors entrada
            Console.Write($"Escriu el valor del radi: ");
            radi = Convert.ToDouble(Console.ReadLine());

            //Llegir fitxer
            coordenades = Convert.ToInt32(fitxer.ReadLine());
            for (int i = 0; i < coordenades; i++)
            {
                //linia = fitxer.ReadLine();
                //x = Convert.ToDouble(linia);
                //linia = fitxer.ReadLine();
                //y = Convert.ToDouble(linia);
                x = Convert.ToDouble(fitxer.ReadLine().Replace('.',','));
                y = Convert.ToDouble(fitxer.ReadLine().Replace('.', ','));
                distancia = Distancia(x, y);
                if (distancia < radi)
                    Console.WriteLine($"Les coordenades ({x}, {y}) estan dins del perímetre del radi {radi}");
                else if (distancia > radi)
                    Console.WriteLine($"Les coordenades ({x}, {y}) estan fora del perímetre del radi {radi}");
                else
                    Console.WriteLine($"Les coordenades ({x}, {y}) estan sobre el perímetre del radi {radi}");
            }
        }
        static double Distancia(double x, double y)
        {
            return Math.Sqrt(Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2));
        }
    }
}
