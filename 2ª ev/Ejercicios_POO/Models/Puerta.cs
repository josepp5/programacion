using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class Puerta
    {
        protected int ancho; // Ancho en centimetros
        protected int alto; // Alto en centimetros
        protected int color; // Color en formato RGB
        protected bool abierta; // Abierta o cerrada


        public void Abrir()
        {
            abierta = true;
        }
        public void Cerrar()
        {
            abierta = false;
        }

        public int GetAncho()
        {
            return ancho;
        }

        public void SetAncho(int nuevoValor)
        {
            ancho = nuevoValor;
        }
        public void MostrarEstado()
        {
            Console.WriteLine("Ancho: {0}", ancho);
            Console.WriteLine("Alto: {0}", alto);
            Console.WriteLine("Color: {0}", color);
            Console.WriteLine("Abierta: {0}", abierta);
        }
    }
}
