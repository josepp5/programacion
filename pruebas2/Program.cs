using System;

namespace pruebas2
{
    class Program
    {
        static void Main(string[] args)
        {

            // Interger o variables de numeros enteros
            
            int suma; // declaro la variable suma y hago la suma de las variables anteriores
           
            Console.WriteLine("Escribe el valor primero");
            int primero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe el valor segundo");
            int segundo = Convert.ToInt32(Console.ReadLine());


            suma = primero + segundo;

            //  llaves dentro del writeline para llamar a variables         0        1       2
            Console.WriteLine("El resultado de {0} + {1} es igual a {2}", primero, segundo, suma);


        }
    }
}
