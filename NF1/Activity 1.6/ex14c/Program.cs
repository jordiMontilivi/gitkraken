using System.Globalization;
using System.Text;

namespace ex14c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //per a tenir el simbol de l'euro
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Fer el mateix que l'anterior però mostrar en mode tiquet xulo
            //optimitzem el codi per no saturar el buffer de consola
            //Variables
            const string path = @"..\..\..\..\FITXERS PER RECORREGUTS\";
            StreamReader fitxer = new StreamReader(path + "tiquetsuper.txt");
            string linia;
            int productes, quantitat;
            double preu, total = 0;
            string tiquet = "";
            //StringBuilder per optimitzar el codi i poder afegir strings sense saturar el buffer de consola
            StringBuilder sb = new StringBuilder();

            //Llegir fitxer
            productes = Convert.ToInt32(fitxer.ReadLine());

            for (int i = 0; i < productes; i++)
            {
                //nom del producte
                linia = fitxer.ReadLine(); //nom del producte
                if(linia.Length > 15) //comprova si l'string te mes de 15 caracters
                    //si te mes de 15 caracters, nomes mostra els 15 primers i afegeix punts suspensius
                    sb.Append(linia.Substring(0, 15) + "..... "); 
                else
                {
                    sb.Append(linia);
                    //si te menys de 15 caracters, afegeix punts suspensius fins a arribar a 15
                    for (int j = linia.Length; j < 15; j++)
                        sb.Append(".");
                    sb.Append("..... ");
                }

                //quantitat
                linia = fitxer.ReadLine();
                quantitat = Convert.ToInt32(linia);
                //si la quantitat es menor que 10, afegeix 2 espais entre la quantitat i la x
                if (quantitat < 10)
                    sb.Append(quantitat + "  x  ");
                else
                    sb.Append(quantitat + " x  ");

                //preu
                linia = fitxer.ReadLine();
                preu = Convert.ToDouble(linia);
                sb.Append(linia + "\n");

                total += quantitat * preu;
            }
            fitxer.Close();
            sb.Append("TOTAL ");
            //si el total es menor que 15, afegeim punts suspensius fins arribar a 15
            for (int j = "TOTAL ".Length; j < 15; j++)
                sb.Append(".");
            //Mostrem el total amb 2 decimals i simbol de l'euro
            sb.Append($".....\t{Math.Round(total,2):0.00} €");
            //Passem el StringBuilder a string
            tiquet = sb.ToString();
            Console.WriteLine(tiquet);
        }
    }
}
