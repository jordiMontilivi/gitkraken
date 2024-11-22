namespace ex15b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int num;

            //Demanar valors entrada
            Console.Write("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Mostrar Resultat quadrat d'asteriscs
            //eix vertical
            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(GenerarLinia(num));
            }
        }
        static string GenerarLinia(int num)
        {
            string linia = "";
            //eix horitzontal
            for (int i = 1; i <= num; i++)
            {
                linia += "* ";
            }
            return linia;
        }
    }
}
