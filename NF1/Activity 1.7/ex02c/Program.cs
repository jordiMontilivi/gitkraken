namespace ex02c
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
            linia = fitxer.ReadLine();

            //Mentre no trobat i no final
            while (linia != null && (valor = Convert.ToInt32(linia)) != primer);
            fitxer.Close();
            if (linia == null)
                Console.WriteLine($"No hem trobat el primer element repetit el numero {primer}");
            else
                Console.WriteLine($"Hem trobat el primer element repetit el numero {primer}");
        }
    }
}
