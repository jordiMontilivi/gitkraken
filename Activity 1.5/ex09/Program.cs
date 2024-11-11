namespace ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int num, cont = 0, aux;

            //Demanar valor enter (primer valor)
            Console.WriteLine("Escriu un valor enter");
            num = Convert.ToInt32 (Console.ReadLine());
            aux = num;

            //mentre no final
            while (aux != 0) 
            {
                cont++;
                //actualitzar valor
                aux /= 10;
            }
            Console.WriteLine($"El numero {num} te {cont} digits");
        }
    }
}
