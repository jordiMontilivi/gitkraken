namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static double VolumEsfera(double radi)
        {
            double resultat;
            resultat = 4.0/3 * Math.PI * Math.Pow(radi, 3);
            return Math.Round(resultat, 2);
        }
    }
}
