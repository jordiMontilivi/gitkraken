namespace ex01c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int numAct = -1, numAnt = -1, numAnt2 = -1;
            const string path = @"..\..\..\..\FITXERS FINESTRES\";
            StreamReader sr = new StreamReader(path + "NUMEROS1.txt");
            string linia;

            //Valors entrada
            linia = sr.ReadLine();

            while (linia != null && numAct != numAnt + numAnt2)
            {
                numAct = Convert.ToInt32(linia);
                numAnt2 = numAnt;
                numAnt = numAct;
                linia = sr.ReadLine();
            }
            sr.Close();
            //Mostrar resultats
            if (numAct == numAnt + numAnt2)
                Console.WriteLine($"Si ha trobat");
            else
                Console.WriteLine("No ha trobat");
        }
    }
}
}
