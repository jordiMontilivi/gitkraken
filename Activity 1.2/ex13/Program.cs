namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int any, unitats, desenes, centenes, milers;

            //valors inicials
            Console.Write("Escriu un any ");
            any = Convert.ToInt32(Console.ReadLine());

            //algorisme/calcul
            unitats = any % 10;
            desenes = any % 100 / 10;
            desenes = any / 10 % 10;
            centenes = any / 100 % 10;

            //valors sortida
            Console.WriteLine();
        }
    }
}
