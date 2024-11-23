﻿namespace ex06a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //determinar si un numero es primer
            //Variables
            int num, i = 2;
            bool esPrimer = true;

            //Entrada de dades
            Console.Write("Introdueix un numero: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Calculs
            while (i <= num / 2 && esPrimer)
            {
                if (num % i == 0)
                    esPrimer = false;
                i++;
            }

            //Sortida
            if (esPrimer)
                Console.WriteLine($"El numero {num} és primer");
            else
                Console.WriteLine($"El numero {num} no és primer");
        }
    }
}