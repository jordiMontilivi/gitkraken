namespace ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declarar variables
            int num;

            //valors entrada
            Console.Write("Escriu un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Piramide numerica centrada
            for (int i = 1; i <= num; i++)
            {
                //centrar numero amb espais
                for (int j = i; j < num; j++)
                //for (int j = 1; j <= num - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }
    }
}
