namespace ex05c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int num;
            string linia;
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            StreamReader fitxer = new StreamReader(path + "PERFECTES.txt");

            //Llegir fitxer
            linia = fitxer.ReadLine();

            //Recorregut hem de llegir tot el fitxer per veure quins numeros són perfectes
            while (linia != null)
            {
                num = Convert.ToInt32(linia);
                if (EsPerfecet(num))
                    Console.WriteLine($"El numero {num} és perfecte");
                else
                    Console.WriteLine($"El numero {num} no és perfecte");
                linia = fitxer.ReadLine();
            } 
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
