namespace ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            Random aleatori = new Random();
            int nCares, dau;

            //valors inicials
            Console.Write("numero de cares: ");
            nCares = Convert.ToInt32(Console.ReadLine());

            //algorisme/calcul
            dau = aleatori.Next(1,nCares+1);

            //valors sortida
            Console.WriteLine($"");
        }
    }
}
