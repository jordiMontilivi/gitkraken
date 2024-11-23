namespace ex01b
{
    internal class Program
    {
        //Millores:
        //Demanar el fitxer en el main i passar-lo com a paràmetre (no repetir codi)
        //Poder triar quants km te la cursa (passem com a paràmetre)
        //Reaprofitar Funcions i cridar d'unes a altres
        static void Main(string[] args)
        {
            string url;
            do
            {
                //Fem un Menu per triar un fitxer de la carpeta NO CAL FER-HO
                url = MenuFitxer();
                Console.Clear();

                //Comprovem si existeix el fitxer
                if (url != "final" && File.Exists(url))
                {
                    //Llegir fitxer
                    StreamReader fitxer;
                    double distanciaCursa;
                    int opcio;
                    //Fem un Menu per triar una funció
                    opcio = MenuFuncio();
                    while (opcio != 0)
                    {
                        fitxer = new StreamReader(url);
                        Console.Write("\n\tQuants km té la cursa: ");
                        distanciaCursa = Convert.ToDouble(Console.ReadLine());

                        if (opcio == 1)
                        {
                            //Distancia
                            double distancia = Distancia(fitxer, distanciaCursa);
                            if (distancia == -1)
                                Console.WriteLine("\tNo hi ha dos membres de l'equip");
                            else
                                Console.WriteLine($"\tLa distancia entre el primer i l'últim corredor del teu equip és de {distancia} km");
                            Thread.Sleep(2000);
                        }
                        else if (opcio == 2)
                        {
                            //Distancia Dorsals
                            Console.Write("\tDorsal 1: ");
                            int dorsal1 = Convert.ToInt32(Console.ReadLine());
                            Console.Write("\tDorsal 2: ");
                            int dorsal2 = Convert.ToInt32(Console.ReadLine());
                            double distancia = Distancia(fitxer, distanciaCursa, dorsal1, dorsal2);
                            if (distancia == -1)
                                Console.WriteLine("\tNo existeixen els dorsals");
                            else
                                Console.WriteLine($"\tLa distancia entre el dorsal {dorsal1} i el dorsal {dorsal2} és de {distancia} km");
                            Thread.Sleep(2000);
                        }
                        else if (opcio == 3)
                        {
                            //Mitjana Dorsal
                            Console.Write("\tDorsal: ");
                            int dorsal = Convert.ToInt32(Console.ReadLine());
                            double mitjana = VelocitatMitjana(fitxer, distanciaCursa, dorsal);
                            if (mitjana == -1)
                                Console.WriteLine("\tEl dorsal no existeix");
                            else
                                Console.WriteLine($"\tLa velocitat mitjana del dorsal {dorsal} és de {mitjana} km/h");
                            Thread.Sleep(2000);
                        }

                        //Fem un Menu per triar una funció
                        opcio = MenuFuncio();
                    }
                }
                else if (url == "final")
                {
                    Console.WriteLine("\tFinal del programa");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("\tEl fitxer no existeix");
                    Console.ReadKey();
                }

            } while (url != "final" );


        }

        //Funció per pintar un menú que ens retorna el nom del fitxer
        static string MenuFitxer()
        {
            //llegir fitxers d'una carpeta
            //Variables per a elegir fitxers en la carpeta
            string path = @"..\..\..\..\FITXERS\";
            //Array de strings que contendra los nombres de los ficheros
            //Ho vorem en un futur (col·lecció de dades string)
            string[] fitxers = Directory.GetFiles(path);
            string nomFitxer;
            string url;
            int opcio = 0;
            do
            {
                Console.Clear();
                //Entrada de dades
                //Mostrem un menu per a que l'usuari pugui elegir un fitxer
                Console.WriteLine("\tElegeix un fitxer");
                Console.WriteLine("\t╔═════════════════════════════════════╗");
                Console.WriteLine("\t║              FITXERS                ║");
                Console.WriteLine("\t╠═════════════════════════════════════╣");

                for (int i = 0; i < fitxers.Length; i++)
                {
                    //Agafem la posició inicial i final del nom del fitxer sense la ruta ni l'extensió
                    int posInicial = fitxers[i].LastIndexOf(@"\") + 1;
                    int posFinal = fitxers[i].LastIndexOf(".");
                    //Mostrem el nom del fitxer
                    Console.Write($"\t║\t{i + 1} - {fitxers[i].Substring(posInicial, posFinal - posInicial)}");

                    //Espais en blanc per a que quede be
                    for (int j = 0; j < 37 - 7 /*el 7 es el tabulador*/ - $"{i + 1} - {fitxers[i].Substring(posInicial, posFinal - posInicial)}".Length; j++)
                        Console.Write(" ");
                    Console.WriteLine("║");
                }
                Console.WriteLine("\t║                                     ║");
                Console.WriteLine("\t║\t0. Sortir                     ║");
                Console.WriteLine("\t╚═════════════════════════════════════╝");

                Console.Write("\n\tElegeix una opcio: ");
                opcio = Convert.ToInt32(Console.ReadLine());
                if (opcio < 0 || opcio > fitxers.Length + 1)
                {
                    Console.WriteLine("\tOpció incorrecta");
                    Thread.Sleep(2000);
                }
            } while (opcio < 0 || opcio > fitxers.Length + 1);

            if (opcio == 0)
                url = "final";
            else
                url = fitxers[opcio - 1];

            return url;
        }
        //Funció per pintar un menú que ens retorna la funció a executar
        static int MenuFuncio()
        {
            int opcio = 0;
            do // Elegir una opció vàlida
            {
                Console.Clear();
                Console.WriteLine("\tElegeix una funció");
                Console.WriteLine("\t╔═════════════════════════════════════╗");
                Console.WriteLine("\t║             FUNCIONS                ║");
                Console.WriteLine("\t╠═════════════════════════════════════╣");
                Console.WriteLine("\t║\t1. Distancia                  ║");
                Console.WriteLine("\t║\t2. Distancia Dorsals          ║");
                Console.WriteLine("\t║\t3. Vel Mitjana Dorsal         ║");
                Console.WriteLine("\t║                                     ║");
                Console.WriteLine("\t║\t0. Cambiar Fitxer             ║");
                Console.WriteLine("\t╚═════════════════════════════════════╝");

                Console.Write("\n\tElegeix una opcio: ");
                opcio = Convert.ToInt32(Console.ReadLine());
                if (opcio < 0 || opcio > 3)
                {
                    Console.WriteLine("\tOpció incorrecta");
                    Thread.Sleep(2000);
                }
            } while (opcio < 0 || opcio > 3);

            return opcio;
        }
        //Funció per comprovar si un dorsal té dos 7
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
        static double Distancia(StreamReader fitxer, double distanciaCursa)
        {
            //sabem que el primer corredor de tots diu temps inicial i
            //cada nou corredor diu temps respecte l'anterior
            //Com no sabem on es troba l'ultim corredor del nostre equip al url
            //fem un recorregut
            int tempsPrimerEquip = 0, tempsUltimEquip = 0, temps = 0, dorsal;
            double distancia = -1;

            string linia;

            //lleig el primer dorsalFitxer del url
            linia = fitxer.ReadLine();

            while (linia != null)
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
            //Ens asegurem que hi ha dos memebres de l'equip
            if (tempsPrimerEquip != 0 && tempsUltimEquip != 0)
                distancia = (tempsUltimEquip - tempsPrimerEquip) * distanciaCursa / tempsUltimEquip;
            return Math.Round(distancia,3);
        }
        static double Distancia(StreamReader fitxer, double distanciaCursa, int dorsal1, int dorsal2)
        {
            //sabem que el primer corredor de tots diu temps inicial i
            //cada nou corredor diu temps respecte l'anterior
            //Ara ja sabem que quan trobem dorsal2 parem
            //fem un cerca fins trobar dorsal2
            int tempsDorsal1 = 0, tempsDorsal2 = 0, temps = 0, dorsal;
            double distancia = -1;

            string linia;

            //lleig el primer dorsalFitxer del url
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
            //Ens asegurem que els dorsals existeixen i el dorsal1 ha arribat abans que el dorsal2
            if (tempsDorsal1 != 0 && tempsDorsal2 != 0)
                distancia = (tempsDorsal2 - tempsDorsal1) * distanciaCursa / tempsDorsal2;
            return Math.Round(distancia,3);
        }
        static double VelocitatMitjana(StreamReader fitxer, double distanciaCursa, int dorsal)
        {
            //sabem que el primer corredor de tots diu temps inicial i
            //cada nou corredor diu temps respecte l'anterior
            //Ara ja sabem que quan trobem dorsal parem
            //fem un cerca fins trobar dorsal
            int tempsDorsal = 0, temps = 0, dorsalFitxer;
            double mitjana = -1;

            string linia;

            //lleig el primer dorsalFitxer del url
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
            //fem formula v = d/t
            //Ens asegurem que el dorsal existeix
            if (tempsDorsal != 0)
                mitjana = distanciaCursa / ((double)tempsDorsal/3600);
            return Math.Round(mitjana, 2);
        }
    }
}
