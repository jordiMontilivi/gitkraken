namespace ex02d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Igual que el 2 però dir en quina posició del fitxer l'hem trobat

            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            StreamReader fitxer = new StreamReader(path + "NUMEROS.txt");
            string linia;
            int primer, valor, cont = 1;

            //Llegir fitxer
            //agafem el primer valor per veure si es repeteix
            primer = Convert.ToInt32(fitxer.ReadLine());
            //Agafem el primer valor dels possibles repetits
            linia = fitxer.ReadLine();
            valor = Convert.ToInt32(linia);
            cont++;

            //Mentre no trobat i no final
            while (linia != null && valor != primer)
            {
                valor = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
                cont++;
            }
            fitxer.Close();
            if (primer == valor)
                Console.WriteLine($"Hem trobat el primer element repetit el numero {primer} a la posició {cont}");
            else
                Console.WriteLine($"No hem trobat el primer element repetit el numero {primer} a la posició {cont}");
        }
    }
}
