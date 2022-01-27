using System;

namespace _5._4._5
{
    class Program
    {        
        static char UltimaLetra()
        {
            Console.WriteLine("Escribe una palabra");
            string palabra = Convert.ToString(Console.ReadLine());

            int numletras = palabra.Length;
            char letra = palabra[numletras - 1];

            return letra;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(UltimaLetra());
        }
    }
}
