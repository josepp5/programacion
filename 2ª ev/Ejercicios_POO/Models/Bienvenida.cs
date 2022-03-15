using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class Bienvenida
    {
        public void Lanzar()
        {
            bool fin = false;
            Console.WriteLine("Bienvenido a Console Invaders. Pulse Intro para jugar o ESC para salir");
            ConsoleKeyInfo tecla = Console.ReadKey();

            do
            {
                if (tecla.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Ésta sería la pantalla de juego.Pulse Intro para salir");
                }
                if (tecla.Key == ConsoleKey.Escape)
                {
                    GetSalir();
                    fin = true;
                }
            } while (fin == false);
        }

        public void GetSalir()
        {
            Console.WriteLine("Adios");
        }
    }
}
