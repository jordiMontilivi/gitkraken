namespace ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int anys, anySeguent;

            //Valors entrada
            Console.WriteLine("Escriu la teva edat: ");
            anys = Convert.ToInt32(Console.ReadLine());

            //Algorisme / càlcul
            anySeguent = anys + 1;

            //Valors sortida
            Console.WriteLine($"La teva edat es {anys} i la teva edat l'any vinent sera {anySeguent}");
            Console.WriteLine("La teva edat es {0} i la teva edat l'any vinent sera {1}", anys, anySeguent);
            Console.WriteLine("La teva edat es " + anys + " i la teva edat l'any vinent sera " + anySeguent);
        }
    }
}
