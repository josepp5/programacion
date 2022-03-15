using Ejercicios_POO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO
{
    public class Juego
    {
        public void Lanzar()
        {
            Bienvenida b1 = new Bienvenida();
            Partida p1 = new Partida();

            b1.Lanzar();
            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Enter)
            {
                p1.Lanzar();
            }
            else
                b1.Lanzar();
        }
    }
}
