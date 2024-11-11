namespace ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar variables
            //StreamReader fitxer = new StreamReader("alumnesDAMDAW.txt");
            StreamReader fitxer = new StreamReader(@"..\..\..\..\FITXERS PER RECORREGUTS\alumnesDAMDAW.txt");
            string linia;
            int contAlex = 0, contIker = 0;

            //valors entrada primer element
            linia = fitxer.ReadLine();
            
            //mentre no final
            while (linia != null)
            {
                if( linia == "Alex")
                    contAlex++;
                else if( linia == "Iker")
                    contIker++;
                //següent element
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            if (contAlex == contIker)
                Console.WriteLine("Hi ha la mateixa quantitat d'Ikers que d'Alex");
            else if (contAlex > contIker)
                Console.WriteLine();
            else
                Console.WriteLine();



        }
    }
}
