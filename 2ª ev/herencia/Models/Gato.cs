using System;
using System.Collections.Generic;
using System.Text;

namespace herencia.Models
{
    class Gato: Animal
    {
        public int vidas = 7;
        public override void hablar()
        {
            Console.WriteLine("Soy un Gato");
        }

        public override void Vidas()
        {
            Console.WriteLine("tengo " + vidas + " vidas");
        }
    }
}
