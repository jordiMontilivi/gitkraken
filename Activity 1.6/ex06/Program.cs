namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, positius = 0, negatius = 0, zeros = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Escriu un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                    positius++;
                else if (num < 0)
                    negatius++;
                else
                    zeros++;
            }
            Console.WriteLine($"Has escrit {positius} positius, {negatius} negatius i {zeros} zeros");
        }
    }
}
