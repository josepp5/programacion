using herencia.Models;
using System;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] misAnimales = new Animal[10];
           
           
            misAnimales[1] = new Perro();
            misAnimales[2] = new Gato();
            misAnimales[3] = new Animal();

            misAnimales[1].hablar();
            misAnimales[2].hablar();
            misAnimales[3].hablar();


            misAnimales[1].Vidas();
            misAnimales[2].Vidas();
            misAnimales[3].Vidas();



        }
    }
}
