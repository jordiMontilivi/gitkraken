namespace ex16b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5, m = 2;
            double resultat = Factorial(n) / (Factorial(m) * Factorial(n - m));
        }
        static int Factorial(int num)
        {
            int res = 1;
            for (int i = 1; i <= num; i++)
                res *= i;
            return res;
        }
    }
}
