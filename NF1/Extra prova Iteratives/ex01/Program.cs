using System.Net.Http.Headers;
using System.Net.NetworkInformation;

namespace ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tenint les funcions creades podem cridar-les
        }
        static bool Equip(int dorsal)
        {
            int count7 = 0;
            while (dorsal > 0 && count7 < 2)
            {
                if (dorsal % 10 == 7)
                    count7++;
                dorsal /= 10;
            }
            return count7 == 2;
        }
        //Distància en km entre el primer i l'últim corredor del teu equip
        static double Distancia()
        {
            //sabem que el primer corredor de tots diu temps inicial i
            //cada nou corredor diu temps respecte l'anterior
            //Com no sabem on es troba l'ultim corredor del nostre equip al nomFitxer
            //fem un recorregut
            int tempsPrimerEquip = 0, tempsUltimEquip = 0, temps= 0, dorsal;
            double distancia = 0;
            string path = @"..\..\..\..\fitxers\";
            string nomFitxer;
            Console.Write("Nom nomFitxer de la cursa: ");
            nomFitxer = Console.ReadLine() +".txt";
            StreamReader fitxer = new StreamReader(path+nomFitxer);
            string linia;

            //lleig el primer dorsalFitxer del nomFitxer
            linia = fitxer.ReadLine();

            while(linia != null)
            {
                //dupla de dades dorsalFitxer i temps
                dorsal = Convert.ToInt32(linia);
                temps += Convert.ToInt32(fitxer.ReadLine());
                if (Equip(dorsal))
                {
                    //si el primer temps era 0 és perque no haviem trobat cap dorsalFitxer del nostre equip
                    if (tempsPrimerEquip == 0)
                        tempsPrimerEquip = temps;
                    //sempre que trobem un dorsalFitxer del nostre equip guardem el temps ja acabarà sent l'ultim
                    tempsUltimEquip = temps;
                }
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            //fem regla de tres per saber la distancia
            distancia = (tempsUltimEquip - tempsPrimerEquip) * 30.0 / tempsUltimEquip;
            return distancia;
        }
        static double Distancia(int dorsal1, int dorsal2) 
        {
            //sabem que el primer corredor de tots diu temps inicial i
            //cada nou corredor diu temps respecte l'anterior
            //Ara ja sabem que quan trobem dorsal2 parem
            //fem un cerca fins trobar dorsal2
            int tempsDorsal1 = 0, tempsDorsal2 = 0, temps = 0, dorsal;
            double distancia = 0;
            string path = @"..\..\..\..\fitxers\";
            string nomFitxer;
            Console.Write("Nom nomFitxer de la cursa: ");
            nomFitxer = Console.ReadLine() + ".txt";
            StreamReader fitxer = new StreamReader(path + nomFitxer);
            string linia;

            //lleig el primer dorsalFitxer del nomFitxer
            linia = fitxer.ReadLine();
            dorsal = Convert.ToInt32(linia);

            //No comprovaré si dorsal1 ha arribat abans de dorsal2
            while (linia != null && dorsal != dorsal2)
            {
                //dupla de dades dorsalFitxer i temps
                dorsal = Convert.ToInt32(linia);
                temps += Convert.ToInt32(fitxer.ReadLine());
                if (dorsal == dorsal1)
                    tempsDorsal1 = temps;
                else if (dorsal == dorsal2)
                    tempsDorsal2 = temps;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            //fem regla de tres per saber la distancia
            distancia = (tempsDorsal2 - tempsDorsal1) * 30.0 / tempsDorsal2;
            return distancia;
        }
        static double VelocitatMitjana(int dorsal)
        {
            //sabem que el primer corredor de tots diu temps inicial i
            //cada nou corredor diu temps respecte l'anterior
            //Ara ja sabem que quan trobem dorsal parem
            //fem un cerca fins trobar dorsal
            int tempsDorsal = 0, temps = 0, dorsalFitxer;
            double mitjana = 0;
            string path = @"..\..\..\..\fitxers\";
            string nomFitxer;
            Console.Write("Nom nomFitxer de la cursa: ");
            nomFitxer = Console.ReadLine() + ".txt";
            StreamReader fitxer = new StreamReader(path + nomFitxer);
            string linia;

            //lleig el primer dorsalFitxer del nomFitxer
            linia = fitxer.ReadLine();
            dorsalFitxer = Convert.ToInt32(linia);

            //No comprovaré si dorsal1 ha arribat abans de dorsal2
            while (linia != null && dorsalFitxer != dorsal)
            {
                //dupla de dades dorsalFitxer i temps
                dorsalFitxer = Convert.ToInt32(linia);
                temps += Convert.ToInt32(fitxer.ReadLine());
                if (dorsalFitxer == dorsal)
                    tempsDorsal = temps;
                linia = fitxer.ReadLine();
            }
            fitxer.Close();
            //fem regla de tres per saber la distancia
            mitjana = 30.0 / tempsDorsal;
            return mitjana;
        }
    }
}
