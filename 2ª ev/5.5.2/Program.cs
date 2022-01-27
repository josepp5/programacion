using System;

namespace _5._5._2
{
    class Program
    {
        static int num;
        static void TablaMultiplicar()
        {
            Console.WriteLine("Escribe un numero para saber su tabla de multiplicar");
            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", num, i, num*i);
            }          
        }        
        static void Main(string[] args)
        {
            TablaMultiplicar();
        }
    }
}
