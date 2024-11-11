namespace ex30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio de variables
            int dia, mes;

            //demanar dades entrada
            Console.WriteLine("escriu mes");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escriu dia");
            dia = Convert.ToInt32(Console.ReadLine());

            //calculs
            if((dia >= 21 && mes >=3) && (dia <=20 && mes <= 6))
            if (dia >= 21 && mes == 3 || mes == 4 || mes == 5 || dia <= 20 && mes == 6)
                Console.WriteLine("primavera");

        }
    }
}
