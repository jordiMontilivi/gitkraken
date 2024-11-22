namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static double DistanciaPunts(int xPunt1, int yPunt1, int xPunt2, int yPunt2)
        {
            //Declaracio de variables
            double distancia;
            //valors inicials
            //algorisme/calcul
            distancia = Math.Sqrt(Math.Pow(xPunt2 - xPunt1, 2) + Math.Pow(yPunt2 - yPunt1, 2));
            //valors sortida
            return distancia;
            //return Math.Sqrt(Math.Pow(xPunt2 - xPunt1, 2) + Math.Pow(yPunt2 - yPunt1, 2));
        }
    }
}
