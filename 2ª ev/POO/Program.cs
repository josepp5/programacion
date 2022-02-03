using POO.Modelo;
using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.SetDni(12345678);
            p1.SetNombre("Carlos");
            p1.SetEdad(27);

            p1.Mostrar();

            Persona p2 = new Persona(123456, 27, "Pepe");
            p2.Mostrar();

            Cliente c1 = new Cliente();
            Empleado e1 = new Empleado();
            c1.GetDni();
            e1.GetDni();
            c1.GetCuenta();
            e1.GetCuenta();


            if(p1.Equals(p2))
            {
                Console.WriteLine("si");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
