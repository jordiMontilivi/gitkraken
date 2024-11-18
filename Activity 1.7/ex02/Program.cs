namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            StreamReader fitxer = new StreamReader(path + "NUMEROS.txt");
            string linia;
            int primer, valor;

            //Llegir fitxer
            //agafem el primer valor per veure si es repeteix
            primer = Convert.ToInt32(fitxer.ReadLine());
            //Agafem el primer valor dels possibles repetits
            linia = fitxer.ReadLine();
            valor = Convert.ToInt32(linia);

            //Mentre no trobat i no final
            while (valor != primer && linia != null)
            {
                valor = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            if (primer == valor)
                Console.WriteLine($"Hem trobat el primer element repetit el numero {primer}");
            else
                Console.WriteLine($"No hem trobat el primer element repetit el numero {primer}");

        }
    }
}
