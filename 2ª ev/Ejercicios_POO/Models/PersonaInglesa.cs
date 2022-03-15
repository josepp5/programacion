using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class PersonaInglesa : Persona
    {
        public PersonaInglesa()
        {
            this.SetNombre("jhon");
        }
        public PersonaInglesa(string nombre)
        {
            this.SetNombre(nombre);
        }

        public void TomarTe()
        {
            Console.WriteLine("Estoy tomando té");
        }

        public new void Saludar()
        {
            Console.WriteLine("Hi I am " + nombre);
        }
    }
}
