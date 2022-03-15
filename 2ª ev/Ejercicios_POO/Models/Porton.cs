using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class Porton : Puerta
    {
        bool bloqueada;
        public void Bloquear()
        {
            bloqueada = true;
        }
        public void Desbloquear()
        {
            bloqueada = false;
        }
        public new void MostrarEstado()
        {
            Console.WriteLine("Portón.");
            Console.WriteLine("Ancho: {0}", ancho);
            Console.WriteLine("Alto: {0}", alto);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Abierta: {0}", abierta);
            Console.WriteLine("Bloqueada: {0}", bloqueada);
        }
    }
}
