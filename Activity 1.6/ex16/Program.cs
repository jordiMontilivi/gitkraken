namespace ex16
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

            // Mostrar resultat triangle d'asteriscs
            //eix vertical
            for (int i = 1; i <= num; i++)
            {
                //eix horitzontal
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
