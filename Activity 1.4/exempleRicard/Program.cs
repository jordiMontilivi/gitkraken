namespace exempleRicard
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            double nota;

            //Valors inicials
            Console.Write("Escriu una nota: ");
            nota = Convert.ToDouble(Console.ReadLine());

            //calculs
            //Mostrar resultats
            if (nota < 0 || nota > 10)
                Console.WriteLine("nota erronea");
            else if (nota >= 5)
            {
                Console.Write("Aprovat ");
                if (nota < 7)
                    Console.WriteLine("suficient"); 
                else if (nota < 9) 
                    Console.WriteLine("Notable");
                else 
                    Console.WriteLine("exel·lent");
            }
            else
                Console.WriteLine("suspès");
        }
    }
}
