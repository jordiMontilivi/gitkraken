using System.Xml;

namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linia;
            int numero, contador = 0;

            StreamReader fitxer = new StreamReader(@"..\..\..\..\NUMEROS.TXT");
            linia = fitxer.ReadLine();
            while (linia != null)
            {
                numero = Convert.ToInt32(linia);
                contador++;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"hem trobat {contador} valors");
        }
    }
}
