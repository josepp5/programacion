using System;

namespace ejercicios_funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            BorrarPantalla();
        }

        static void BorrarPantalla()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine();
            }          
        }
    }
}
