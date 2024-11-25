namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int n, m, factN = 1, factM = 1, factNM = 1;
            double resultat;

            //Demanar valors entrada
            Console.Write("Escriu n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriu m: ");
            m = Convert.ToInt32(Console.ReadLine());

            if (n < m)
            {
                int aux = m;
                m = n;
                n = aux;
            }

            if (n > m && n > 1 && m > 0)
            {
                for (int i = 1; i <= n; i++)
                    factN *= i;
                for (int i = 1; i <= m; i++)
                    factM *= i;
                for (int i = 1; i <= n - m; i++)
                    factNM *= i;

                resultat = (double)factN/(factM*factNM);
                Console.WriteLine(resultat);
            }

        }

    }
}
