namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont, inicial, final;
            Console.Write("Escriu un valor inicial: ");
            inicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriu el valor final: ");
            final = Convert.ToInt32(Console.ReadLine());

            for (cont = inicial ; cont <= final; cont++)
            {
                if(!Multiple7(cont))
                    Console.WriteLine(cont);
            }
        }
        //proves amb carles
        static bool Multiple7(int valor)
        {
            return valor % 7 == 0;
        }
    }
}
