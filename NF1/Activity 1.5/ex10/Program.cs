namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int cont1 = 0, cont6 = 0, cont = 0, dau;
            Random aleatori = new Random();

            //inicialitzem variables 
            //Demanar primer
            dau = aleatori.Next(1, 7);

            //mentre no final
            while (cont1 != cont6 || cont1 == 0 || cont6 == 0)
            {
                if (dau == 1)
                    cont1++;
                else if (dau == 6)
                    cont6++;

                cont++;

                //actualitzar element
                dau = aleatori.Next(1, 7);
            }
            Console.WriteLine($"Has tirat el dau {cont} vegades\nHan aparegut {cont6} vegades el numero 6");

        }
    }
}
