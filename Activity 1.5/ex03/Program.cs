using System.Runtime.CompilerServices;

namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int numero, contPositius = 0, contNegatius = 0;

            //primer valor
            Console.Write("Escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //mentre (no final)
            while (numero != 0)
            {
                if(numero < 0) 
                    contNegatius++;
                else contPositius++;

                //Demanar següent
                Console.Write("Escriu un altre numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            //Mostrar els resultats
            Console.WriteLine($"has introduit \t{contPositius} positius \ni \t{contNegatius} negatius");
        }
    }
}
