using System;

namespace _5._5._1
{
    class Program
    {
        static int numero;
        static int PedirEntero()
        {
            do
            {
                Console.WriteLine("Introduce un numero entre 1800 y 2100");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero !< 1800 || numero !> 2100)
                {
                    Console.WriteLine("Prueba otra vez");
                }

            }
            while (numero < 1800 || numero > 2100);
            
            return numero;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(PedirEntero());
        }
    }
}
