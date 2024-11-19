namespace ex05d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Indiccar si el fitxer te algun numero perfecte
            //Variables
            bool trobat = false;
            int num = 0;
            string linia;
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            StreamReader fitxer = new StreamReader(path + "PERFECTES.txt");

            //Llegir fitxer
            linia = fitxer.ReadLine();

            //Cerca del fitxer fins trobar un numero perfecte o final
            while (linia != null && !trobat)
            {
                num = Convert.ToInt32(linia);
                trobat = EsPerfecet(num);
                linia = fitxer.ReadLine();
            }
            if (trobat)
                Console.WriteLine($"Hem trobat un numero perfecte {num}");
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
