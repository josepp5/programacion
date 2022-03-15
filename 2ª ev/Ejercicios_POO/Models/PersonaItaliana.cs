using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class PersonaItaliana : Persona
    {
        public PersonaItaliana()
        {

        }

        public new void Saludar()
        {
            Console.WriteLine("Ciao");
        }
    }
}
