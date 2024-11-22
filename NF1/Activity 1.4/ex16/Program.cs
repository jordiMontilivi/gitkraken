namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(EsAnyTraspas(any))
                Console.WriteLine("traspas");
            else if(EsFestivaHulukulu(any))
                Console.WriteLine("Hulukulu");
            else if (EsNoseque(any))
                Console.WriteLine("noseque");
            else
                Console.WriteLine("res");
        }
        //static bool EsAnyTraspas(int any)
        //{
        //    bool traspas;
        //    if (any % 400 == 0)
        //        traspas = true;
        //    else if (any % 100 == 0)
        //        traspas = false;
        //    else if (any % 4 == 0)
        //        traspas = true;
        //    else
        //        traspas = false;
        //    return traspas;
        //}
        //static bool EsAnyTraspas(int any)
        //{
        //    bool traspas = false;
        //    if (any % 400 == 0 || any % 100 != 0 && any % 4 == 0)
        //        traspas = true;
        //    //else 
        //    //    traspas = false;
        //    return traspas;
        //}
        static bool EsAnyTraspas(int any)
        {
            return any %400 == 0 || any % 100 != 0 && any % 4 == 0;
        }
        //static bool EsAnyFestivalHulukulu(int any)
        //{
        //    return any % 15 == 0;
        //}

        static bool EsAnyFestivalHulukulu(int any)
        {
            bool hulukulu = false;
            if(any % 15 == 0) 
                hulukulu = true;
            //else 
            //    hulukulu = false;
            return hulukulu;
        }
    }
}
