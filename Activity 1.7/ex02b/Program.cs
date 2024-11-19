namespace ex02b
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            //Igual que el 2 però dir en quina posició del fitxer l'hem trobat

            //Variables
            int primer, valor, cont = 1;

            //Llegir fitxer
            //agafem el primer valor per veure si es repeteix
            Console.Write("Primer element: ");
            primer = Convert.ToInt32(Console.ReadLine());
            //Agafem el primer valor dels possibles repetits
            Console.Write("Continua la serie: ");
            valor = Convert.ToInt32(Console.ReadLine());
            cont++;

            //Mentre no trobat i no final
            while (valor != -9999 && valor != primer)
            {
                Console.Write("Continua la serie: ");
                valor = Convert.ToInt32(Console.ReadLine());
                cont++;
            }
            Console.Clear();
            if (primer == valor)
                Console.WriteLine($"Hem trobat el primer element repetit el numero {primer} a la posició {cont}");
            else
                Console.WriteLine($"No hem trobat el primer element repetit el numero {primer} a la posició {cont}");
        }
    }
}
