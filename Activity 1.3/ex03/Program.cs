namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char majuscula, minuscula;
            Console.WriteLine("Escriu minuscula");
            minuscula = Convert.ToChar(Console.ReadLine());
            majuscula = Majuscules(minuscula);
            Console.WriteLine(majuscula);
        }
        static char Majuscules(char minuscules)
        {
            char majuscules;
            majuscules = (char)(minuscules - 32);
            return majuscules;
        }
    }
}
