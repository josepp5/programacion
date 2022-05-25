using System;
using System.Collections.Generic;
using System.Text;

namespace herencia.Models
{
    class Animal
    {
        public virtual void hablar()
        {

            Console.WriteLine("Soy un animal");
            
        }

        public virtual void Vidas()
        {
            Console.WriteLine("tengo muchas vidas");
        }
    }
}
