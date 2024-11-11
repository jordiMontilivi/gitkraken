using System.Collections.Concurrent;
using System.Runtime.InteropServices;

namespace ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            char lletra, lletraMajuscula;

            //valors inicials
            Console.Write("Escriu una lletra: ");
            lletra = Convert.ToChar(Console.ReadLine());

            //algorisme/calcul
            lletraMajuscula = (char)(lletra - 32);

            //valors sortida
            Console.WriteLine($"la lletra majuscula de {lletra} es {lletraMajuscula}");
        }
    }
}
