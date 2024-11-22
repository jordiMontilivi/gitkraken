using System.Xml.Linq;

namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escriu un programa que llegeixi una seqüència d’enters d’un fitxer i ens informi si es compleix
            //sempre la condició que l’element llegit és igual a la suma de tots els anteriors que han aparegut.

            //Exercici no te massa sentit...
            //sempre hauria de llegir un numero doble dels anteriors i haver llegit 1 numero previament...

            //Variables
            const string path = @"..\..\..\..\FITXERS PER CERQUES\";
            string linia;
            string nomFitxer;
            int numero, suma = 0;

            //Entrada de dades
            Console.Write("Introdueix el nom del fitxer: ");
            nomFitxer = Console.ReadLine() + ".txt";

            //Comprovem si existeix el fitxer
            if (File.Exists(path + nomFitxer))
            {
                //Llegir fitxer
                StreamReader fitxer = new StreamReader(path + nomFitxer);
                linia = fitxer.ReadLine();
                numero = Convert.ToInt32(linia);
                suma += numero;
                linia = fitxer.ReadLine();

                //cerca si algun numero no compleix la condicio
                //trobat es suma diferent de numero per la qual cosa !trobat es suma igual a numero
                while (linia != null && numero == suma)
                {
                    numero = Convert.ToInt32(linia);
                    suma += numero;
                    linia = fitxer.ReadLine();                        
                }
                fitxer.Close();

                //Sortida de dades
                if (numero != suma)
                    Console.WriteLine("No es compleix la condició");
                else
                    Console.WriteLine("Es compleix la condició");
            }
        }
    }
}
