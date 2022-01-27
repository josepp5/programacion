using System;

namespace _5._3._1
{
    class Program
    {
        static int alto;
        static int ancho;

        static void DibujarCuadrado()
        {
            Console.WriteLine("introduce alto");
            alto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("introduce ancho");
            ancho = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alto; i++)
            {
                for (int y = 0; y < ancho; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            DibujarCuadrado();
        }
    }
}
