namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            const string path = @"..\..\..\..\FITXERS PER RECORREGUTS\";
            StreamReader fitxer = new StreamReader(path + "BONUS3.txt");
            string linia;
            int sumaBonus = 0, bonus = 0, bitllets, percentBonus;
            //Llegir fitxer
            bitllets = Convert.ToInt32(fitxer.ReadLine());
            for (int i = 0; i < bitllets; i++)
            {
                //llegim una linia per saber si te BONUS o NO BONUS
                linia = fitxer.ReadLine();
                if (linia == "BONUS")
                {
                    //Acumulem el valor del bonus
                    sumaBonus += Convert.ToInt32(fitxer.ReadLine());
                    bonus++;
                }
            }
            //Mostrar resultats
            percentBonus = (bonus * 100) / bitllets;
            Console.WriteLine($"Hi ha {bonus} bitllets de BONUS, amb un total de {sumaBonus}€");
            Console.WriteLine($"El percentatge de bitllets de BONUS és del {percentBonus}%");
        }
    }
}
