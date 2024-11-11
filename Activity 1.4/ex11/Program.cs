namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int angle;
            string quadrant;

            //variables entrada
            Console.WriteLine("escriu l'angle");
            angle = Convert.ToInt32(Console.ReadLine());

            //calculs
            quadrant = Quadrant(angle);

            //Mostrar resultat
            Console.WriteLine(Quadrant(angle));
        }
        static string Quadrant(int valor)
        {
            string resultat;
            if (valor >= 0 && valor < 90 || valor <= -270 && valor > -360)
                resultat = "Q1";
            else if (valor < 180 || valor < -180)
                resultat = "Q2";
            else if (valor < 270 || valor < -90)
                resultat = "Q3";
            else
                resultat = "Q4";

            return resultat;
        }

        /*
        static string Quadrant(int valor)
        {
            //return $"Q{(valor + 360) % 360 / 90 + 1}";
            
        valor = valor % 360;
            if (valor < 0)
                valor += 360;
            string resultat;
            if (valor >= 0 && valor < 90)
                resultat = "Q1";
            else if (valor < 180)
                resultat = "Q2";
            else if (valor < 270)
                resultat = "Q3";
            else
                resultat = "Q4";
            return resultat;

        }
        */

    }
}
