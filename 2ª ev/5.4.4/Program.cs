using System;

namespace _5._4._4
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Inicial());
        }

        static char Inicial()
        {
            string hola = "Hola caracola";
            char letra_inicial = hola[0];

            return letra_inicial;
        }
    }
}
