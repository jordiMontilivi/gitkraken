namespace ex06aaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //determinar si un numero es primer
            //si comencem a dividir per 2 i arribem a la meitat del numero ja sabem que no es primer
            //busquem un divisor fins la meitat del numero, en cas de trobar un divisor ja no es primer
            //Per a poder fer proves he afegit un bucle que demana un numero i comprova si es primer acaba amb 0
            //Variables
            int num, i = 2;

            //Entrada de dades
            Console.Write("Introdueix un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            while (num != 0)
            {
                //Calculs
                while (i <= num / 2 && num % i != 0)
                    i++;

                //Sortida
                if (num < 2 || i <= num / 2)
                    Console.WriteLine($"El numero {num} no és primer");
                else
                    Console.WriteLine($"El numero {num} és primer");

                Thread.Sleep(2000); //espera 2 segons
                //Console.ReadKey();

                Console.Clear();

                Console.Write("Introdueix un numero: ");
                num = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
