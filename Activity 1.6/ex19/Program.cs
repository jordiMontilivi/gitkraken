namespace ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int num, total;

            //Demanar valors entrada
            Console.Write("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            // Mostrar resultat triangle d'asteriscs
            //eix vertical
            for (int i = 1; i <= num; i++)
            {
                //eix horitzontal
                //inicialitzar total a 0
                total = 0;
                for (int j = 1; j <= i; j++)
                {
                    total += j;
                    Console.Write($"{j}");
                    //si no es l'ultim numero
                    if (j < i)
                        //escriure +
                        Console.Write("+");
                    else
                        //escriure = i el total
                        Console.Write($"={total}");
                }
                Console.WriteLine();
            }
        }
    }
}
