namespace ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int hores, minuts, segons, hhmmss;

            //Demanem valors entrada
            Console.Write("Escriu una hora en format hhmmss: ");
            hhmmss = Convert.ToInt32(Console.ReadLine());

            //Calculs
            hores = hhmmss / 10000;
            minuts = hhmmss % 10000 / 100;
            segons = hhmmss % 100;

            if (HoraValida(hores, minuts, segons))
                Console.WriteLine($"l'hora introduida {hores:00}:{minuts:00}:{segons:00} es una hora valida");
            else
                Console.WriteLine($"l'hora introduida {hores:00}:{minuts:00}:{segons:00} no es una hora valida");
        }
        /* logica de l'if amb valors no valids
         * 
        public static bool HoraValida(int h, int m, int s)
        {
            bool horavalida;
            if (h >= 24 || h < 0 || m > 59 || m < 0 || s > 59 || s < 0)
                horavalida = false;
            else 
                horavalida = true;
            return horavalida;
        }
        */
        /*
        public static bool HoraValida(int h, int m, int s)
        {
            bool horavalida;
            if (h >= 0 && h < 24 && m >= 0 && m < 60 && s >= 0 && s < 60)
                horavalida = true;
            else
                horavalida = false;
            return horavalida;
        }
        */
        public static bool HoraValida(int h, int m, int s)
        {
            bool horavalida = h >= 0 && h < 24 && m >= 0 && m < 60 && s >= 0 && s < 60;
            return horavalida;
        }
    }
}
