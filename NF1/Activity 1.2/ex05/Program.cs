namespace ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            char lletra;
            int num;

            //valors inicials
            Console.Write("Escriu una lletra: ");
            lletra = Convert.ToChar(Console.ReadLine());

            //algorisme/calcul
            num = lletra;

            //valors sortida
            Console.WriteLine($"la lletra {lletra} te el valor {num} a la taula ascii");
        }
    }
}
