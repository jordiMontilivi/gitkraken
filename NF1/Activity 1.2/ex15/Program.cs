namespace ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            double quantitatUsuari;
            int qUsuariCentims;
            int bitllet100, bitllet50, bitllet20, bitllet10, bitllet5, moneda2, moneda1, centims50, centims20, centims10, centims5, centims2, centims1;

            //valors inicials
            Console.Write("Escriu el teu canvi en euros: ");
            quantitatUsuari = Convert.ToDouble(Console.ReadLine());
            qUsuariCentims = (int)(quantitatUsuari * 100);

            //algorisme/calcul
            bitllet100 = qUsuariCentims /10000;
            //qUsuariCentims = qUsuariCentims % 10000;
            qUsuariCentims %= 10000;
            bitllet50 = qUsuariCentims / 5000;
            qUsuariCentims %= 5000;

            //valors sortida
        }
    }
}
