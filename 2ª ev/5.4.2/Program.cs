using System;

namespace _5._4._2
{
    class Program
    {
        static int mayor;
        static int num1;
        static int num2;

        static void Main(string[] args)
        {
            Menor();
        }

        static int Menor()
        {

            Console.WriteLine("Escribe un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe otro numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine(num2);
                mayor = num2;
            } else
            {
                Console.WriteLine(num1);
                mayor = num1;
            }

            return mayor;
        }

        
    }
}
