using System;

namespace ejercicio_5._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            DibujarCuadrado3x3();
        }

        public static void DibujarCuadrado3x3()
        {
            for (int i = 0; i <= 2; i++)
            {
                for ( int y = 0; y <= 2; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }                          
        }
    }
}
