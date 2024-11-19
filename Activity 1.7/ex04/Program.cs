namespace ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Trobar la posició en la que es troba el valor introduit per l'usuari

            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            StreamReader fitxer = new StreamReader(path + "NUMEROS.txt");
            string linia;
            int numero, valor, cont = 1;

            //Llegir fitxer;
            //Agafem el primer valor dels possibles repetits
            Console.Write("Introdueix un valor: ");
            numero = Convert.ToInt32(Console.ReadLine());

            //llegim la primera linea del fitxer
            linia = fitxer.ReadLine();
            valor = Convert.ToInt32(linia);

            //Mentre no trobat i no final
            while (linia != null && valor != numero)
            {
                valor = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
                cont++;
            }
            fitxer.Close();
            if (valor == numero)
                Console.WriteLine($"Hem trobat un numero {numero} a la posició {cont}");
            else
            {
                Console.WriteLine(-1);
                Console.WriteLine($"No hem trobat el numero {numero} i hem recorregut tot el fitxer amb {cont} elements");
            }

        }
    }
}
