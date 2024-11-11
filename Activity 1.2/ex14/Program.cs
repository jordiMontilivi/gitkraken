namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int segonsTotal, hores, minuts, segons;

            //valors inicials
            Console.Write("Introdueix segons totals: ");
            segonsTotal = Convert.ToInt32(Console.ReadLine());

            //algorisme/calcul
            hores = segonsTotal / 3600;
            //segonsTotal = segonsTotal - hores * 3600;
            
            //segonsTotal = segonsTotal % 3600;
            //minuts = segonsTotal / 60;
            minuts = segonsTotal % 3600 / 60;
            segons = segonsTotal % 60;

            //valors sortida
            Console.WriteLine($"{segonsTotal} son {hores:00}:{minuts:00}:{segons:00}");

        }
    }
}
