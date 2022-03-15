using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO
{
    class Persona
    {
        public string nombre;
       
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void Saludar()
        {
            Console.WriteLine("Hola, soy " + this.nombre);
        }
    }
}
