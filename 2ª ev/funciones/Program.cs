using System;

namespace funciones
{
    class Program
    {
        public struct Persona
        {
            public string nombre;
        }
        
        static void Main(string[] args)
        {
            int numero1 = PedirNumero();
            int numero2 = PedirNumero();

            Console.WriteLine(numero1);

            int suma = Sumar( ref numero1, ref numero2);

            Console.WriteLine(numero1);
            Console.WriteLine(suma);
        }

        static int PedirNumero()
        {
            Console.WriteLine("Dame un numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            return numero;
        }

        static int Sumar( ref int numero1, ref int numero2)
        {
            numero1 = 10;
            numero2 = 20;

            return numero1 + numero2;
        }
    }
}
