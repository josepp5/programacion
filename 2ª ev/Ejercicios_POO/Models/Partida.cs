using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    public class Partida
    {
        public void Lanzar()
        {

            ConsoleKeyInfo tecla = Console.ReadKey();
            if (tecla.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("Ésta sería la Introducción pantalla de juego.Pulse Intro para salir");
            }  
        }
    }
}
