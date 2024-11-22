namespace ex18b
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

            //triangle numerica dreta
            for (int i = 1; i <= num; i++)
            {
                //desplacem numero a la dreta amb espais
                for (int j = 1; j <= num - 1; j++)
                {
                    //analitzar espais dobles per que?
                    Console.Write("  ");
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
