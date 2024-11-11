namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio de variables
            int cont = 0, num;

            //Demanar primer valor
            Console.Write("Escriu un valor enter: ");
            num = Convert.ToInt32(Console.ReadLine());

            //mentre no final
            while(num != 0)
            {
                cont++;
                Console.Write("Escriu un altre valor enter: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"Has escrit {cont} valors enters");

        }
    }
}
