namespace ex09b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int num, cont = 0, aux, modul = 1;

            //Demanar valor enter (primer valor)
            Console.WriteLine("Escriu un valor enter");
            num = Convert.ToInt32(Console.ReadLine());
            aux = num % modul;

            //mentre no final (no hem arribat al num)
            while (aux != num)
            {
                cont++;
                //actualitzar valor
                modul *= 10;
                aux = num % modul;
            }
            Console.WriteLine($"El numero {num} te {cont} digits");
        }
    }
}
