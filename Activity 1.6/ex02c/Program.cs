using System.Drawing;

namespace ex02c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0, valor = 1; i < 20; valor++) 
            { 
                if (valor %2 == 0)
                {
                    Console.WriteLine(valor);
                    i++;
                }
            }

        }
    }
}
