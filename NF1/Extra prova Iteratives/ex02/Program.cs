namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            string major = "", nom;
            int edatMajor = -1;
            int edat;
            int dataNaixement;
            string path = @"..\..\..\..\fitxers\";
            string nomFitxer;
            Console.Write("Nom nomFitxer de la cursa: ");
            nomFitxer = Console.ReadLine() + ".txt";
            StreamReader fitxer = new StreamReader(path + nomFitxer);
            string linia;

            //lleig la primera persona del fitxer
            linia = fitxer.ReadLine();

            while (linia != null)
            {
                nom = linia;
                //llegim la data de naixement
                dataNaixement = Convert.ToInt32(fitxer.ReadLine());
                edat = CalcularEdat(dataNaixement);
                if (edat > edatMajor)
                {
                    edatMajor = edat;
                    major = nom;
                }
                linia = fitxer.ReadLine();

            }
            static int CalcularEdat(int ddmmaaaa)
            {
                //variables
                int edat = 0;
                int dia, mes, any;
                //Nou tipus de variables que ens permeten treballar amb dates
                DateTime hui = DateTime.Now;

                any = ddmmaaaa % 10000;
                mes = ddmmaaaa / 10000 % 100;
                dia = ddmmaaaa / 1000000;

                //Amb aquest calcul tenim la edat que hauriem de tenir aquest any
                //pero potser encara no hem cumplit els anys
                edat = hui.Year - any;
                //if (mes < hui.Month) //si no hem arribat al mes restem un any
                //    edat--;
                //else if(mes == hui.Month)
                //{
                //    if (dia < hui.Day) 
                //        edat--;
                //}
                if (mes < hui.Month || mes == hui.Month && dia < hui.Year)
                    edat--;

                return edat;
            }
        }
    }
}
