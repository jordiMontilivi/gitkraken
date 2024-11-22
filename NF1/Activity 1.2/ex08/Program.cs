namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Declaracio de variables
            decimal euro, dolar, canviDolarEuro;

            //valors inicials
            Console.Write("Escriu el valor del canvi dolar a euro: ");
            canviDolarEuro = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Escriu el valor de dolars que vols canviar: ");
            dolar = Convert.ToDecimal(Console.ReadLine());

            //algorisme/calcul
            euro = (decimal)(dolar * canviDolarEuro);

            //valors sortida
            Console.WriteLine($"dfasfdafafdsfafad");
        }
    }
}
