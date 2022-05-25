using herencia.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace herencia
{
    class Perro: Animal
    {
        public int vidas = 1;

        public Perro()
        {
            Console.WriteLine("Guau");
            hablar();
            Vidas();
        }

        public override void hablar()
        {
            Console.WriteLine("Soy un Perro");
        }
        public override void Vidas()
        {
            Console.WriteLine("tengo " + vidas + " vidas");
        }
    }
}
