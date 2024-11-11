namespace ex03b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicial, final;
            Console.Write("Escriu un valor inicial: ");
            inicial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Escriu el valor final");
            final = Convert.ToInt32(Console.ReadLine());

            for (; inicial <= final; inicial++)
            {
                Console.WriteLine(inicial);
            }
        }
    }
}
