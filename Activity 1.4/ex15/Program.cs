using System.Security.Cryptography.X509Certificates;

namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables
            int hora, minut, segon;

            //Demanar valors
            Console.WriteLine("hores");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("minuts");
            minut = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("segons");
            segon = Convert.ToInt32(Console.ReadLine());

            //calcul

        }
        static string Incrementa1Segon(int h, int m, int s)
        {
            s += 1;
            if(s >= 60)
            {
                m += 1;
                s -= 60;
                if (m >= 60)
                {
                    h++;
                    m -= 60;
                    if (h >= 24)
                        h -= 24;
                }
                
            }
            
            return $"{h:00}:{m:00}:{s:00}";
        }
    }
}
