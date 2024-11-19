namespace ex05da
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //Indiccar si el fitxer te algun numero perfecte
            //Variables
            int num;
            string linia;
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            StreamReader fitxer = new StreamReader(path + "PERFECTES.txt");

            //Llegir fitxer
            linia = fitxer.ReadLine();

            //Cerca del fitxer fins trobar un numero perfecte o final
            //bucle que no te instruccions
            while (linia != null && !EsPerfecet(Convert.ToInt32(fitxer.ReadLine())));
            if (linia != null)
                Console.WriteLine($"Hem trobat un numero perfecte");
            else
                Console.WriteLine("No hem trobat cap numero perfecte");
        }
        static bool EsPerfecet(int num)
        {
            int sumaDivisors = 0;
            bool perfecte = false;
            int i = 1;
            while (i <= num / 2 && sumaDivisors <= num)
            {
                if (num % i == 0)
                    sumaDivisors += i;
                i++;
            }
            if (sumaDivisors == num)
                perfecte = true;
            return perfecte;
        }
    }
}
