namespace ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracio de variables
            int hores, minuts, segons, segonsTotal;

            //Valors entrada
            Console.Write("Hores: ");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuts: ");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segons: ");
            segons = Convert.ToInt32(Console.ReadLine());

            //Algorisme / càlcul
            //segonsTotal = hores * 3600;
            //segonsTotal = segonsTotal + minuts * 60;
            //segonsTotal = segonsTotal + segons;
            segonsTotal = hores * 3600 + minuts * 60 + segons;

            //Valors sortida
            // 3 hores 20 minuts 17 segons son 12017 segons total
            Console.WriteLine($"{hores} hores {minuts} minuts {segons} segons son {segonsTotal} segons total"); 
            
        }
    }
}
