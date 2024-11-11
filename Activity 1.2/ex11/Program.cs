namespace ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int totalHores;
            double salariHora, percentatgeImpostos, salariBrut, salariNet, retencioImpostos;

            //valors inicials
            Console.Write("Hores treballades: ");
            totalHores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sou brut per hora treballada: ");
            salariHora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indica el percentatge d'impostos aplicat: ");
            percentatgeImpostos = Convert.ToDouble(Console.ReadLine());

            //algorisme/calcul
            salariBrut = totalHores * 4.3 * salariHora;
            retencioImpostos = salariBrut * percentatgeImpostos / 100;
            salariNet = salariBrut - retencioImpostos;

            //valors sortida
            Console.WriteLine($"salariBrut = {salariBrut}, retencio= {retencioImpostos} salariNet = {salariNet}");
        }
    }
}
