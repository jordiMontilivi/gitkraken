namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables entrada
            int numero, numMajor, numMenor;

            //Demanar primer element
            Console.Write("Escriu un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            numMajor = numero;
            numMenor = numero;

            //mentre no final
            while(numero != 0)
            {
                if(numMajor > numero) 
                    numMajor = numero;
                else if (numMenor < numero)
                    numMenor = numero;

                //Demanar següent valor
                Console.Write("Escriu un altre numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
            }
            //Mostrar resultats

        }
    }
}
