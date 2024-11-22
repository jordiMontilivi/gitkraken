namespace ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaracio de variables
            string linia;
            int acumulador = 0, contBonus= 0, contTotal = 0;
            int valor;
            Random aleatori = new Random();
            //StreamReader fitxer = new StreamReader("bonus.txt");
            StreamReader fitxer = new StreamReader(@"..\..\..\..\FITXERS PER RECORREGUTS\bonus.txt");
            
            //Demanar primer valor
            linia = fitxer.ReadLine();

            //mentre no final
            while (linia != null)
            {
                if(linia == "BONUS")
                {
                    contBonus++;
                    //valor = aleatori.Next(1,11);
                    acumulador += aleatori.Next(1,11);
                }
                contTotal++;
                //demanar següent
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            Console.WriteLine($"S'han distribuït {contTotal} bitllets \n" +
                $"dels quals {contBonus} han sigut premiats \n" +
                $"sent un percentatge de {Math.Round((double)contBonus/contTotal*100,2)}\n" +
                $"Amb unes ganancies acumulades de {acumulador} euros");
        }
    }
}
