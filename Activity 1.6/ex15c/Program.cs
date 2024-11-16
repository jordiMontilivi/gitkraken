using System.Text;

namespace ex15c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Igual que l'ex15b pero optimitzant el mètode GenerarLinia
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
            StringBuilder sb = new StringBuilder();
            //eix horitzontal
            for (int i = 1; i <= num; i++)
            {
                sb.Append("* ");
            }
            return sb.ToString();
        }
    }
}
