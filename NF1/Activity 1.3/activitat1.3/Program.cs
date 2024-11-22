namespace activitat1._3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Declaracio de variables
            int hores, minuts, segons, segonsTotals;

            //valors inicials
            Console.Write("hores: ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Write("minuts: ");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.Write("segons: ");
            segons = Convert.ToInt32(Console.ReadLine());

            //algorisme/calcul
            segonsTotals = SegonsTotals(hores, minuts, segons);

            //valors sortida
            Console.WriteLine(SegonsTotals(hores, minuts, segons));
            Console.WriteLine();
        }
        static int SegonsTotals(int h, int m, int s)
        {
            //Declaracio de variables
            int segonsTotal;
            //valors inicials

            //algorisme/calcul
            segonsTotal = h * 3600 + m * 60 + s;
            //valors sortida
            return segonsTotal;
        }

    }
}
