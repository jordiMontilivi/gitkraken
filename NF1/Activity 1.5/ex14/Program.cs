namespace ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio de variables
            string linia;
            int acumulador = 0, contBonus = 0, contTotal = 0;
            //StreamReader fitxer = new StreamReader("BONUS2.txt");
            StreamReader fitxer = new StreamReader(@"..\..\..\..\FITXERS PER RECORREGUTS\BONUS2.txt");

            //Demanar primer valor
            linia = fitxer.ReadLine();

            //mentre no final
            while (linia != null)
            {
                if (linia == "BONUS")
                {
                    linia = fitxer.ReadLine();
                    if(linia != null)
                        acumulador += Convert.ToInt32(linia);
                    contBonus++;
                    //valor = aleatori.Next(1,11);
                }
                contTotal++;
                //demanar següent
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"S'han distribuït {contTotal} bitllets \n" +
                $"dels quals {contBonus} han sigut premiats \n" +
                $"sent un percentatge de {Math.Round((double)contBonus / contTotal * 100, 2)}\n" +
                $"Amb unes ganancies acumulades de {acumulador} euros");
        }
    }
}
