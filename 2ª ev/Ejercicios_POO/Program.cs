using Ejercicios_POO.Models;
using System;

namespace Ejercicios_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ejercicio 6.2.1 PAG 191
            Persona p1 = new Persona();
            p1.SetNombre("Raul");

            Persona p2 = new Persona();
            p2.SetNombre("Ricardo");

            p1.Saludar();
            p2.Saludar();
            */

            // Ejercicio 6.2.2  
            /*
            Juego SpaceInvaders = new Juego();

            SpaceInvaders.Lanzar();
            */

            // Ejercicio 6.2.3
            /*
            Libro libro1 = new Libro();

            libro1.SetAutor("Rintintin");
            libro1.SetTitulo("Amanecer");
            libro1.SetUbicacion("Caravaca");
            */

            // Ejercicio 6.2.4
            /*
            Coche c1 = new Coche();

            c1.SetMarca("Lexus");
            c1.SetModelo("Candanchu");
            c1.SetCilindrada(1900);
            c1.SetPotencia(20);
            */

            // Ejercicio 6.3.2
            /*
            Persona p1 = new Persona();

            p1.SetNombre(Console.ReadLine());

            p1.Saludar();
            */

            // Ejercicio 6.3.4
            /*
            Juego j1 = new Juego();
            j1.Lanzar();
            */

            // Ejercicio 6.4.1
            /*
            Puerta p = new Puerta();
            Console.WriteLine("Valores iniciales...");
            p.MostrarEstado();
            Console.WriteLine();
            Console.WriteLine("Vamos a abrir...");
            p.Abrir();
            p.SetAncho(80);
            p.MostrarEstado();
            Console.WriteLine();
            Console.WriteLine("Ahora el portón...");
            Porton p2 = new Porton();
            p2.SetAncho(300);
            p2.Bloquear();
            p2.MostrarEstado();
            */

            // Ejercicio 6.4.2
            /*
            Persona p1 = new Persona();
            p1.SetNombre("Raul");

            Persona p2 = new Persona();
            p2.SetNombre("Ricardo");

            PersonaInglesa Pi1 = new PersonaInglesa();
            Pi1.SetNombre("Juan");

            p1.Saludar();
            p2.Saludar();
            Pi1.Saludar();
            Pi1.TomarTe();
            */

            // Ejercicio 6.4.3
            /*
            Libro D1 = new Libro();
            D1.SetPaginas(89);
            */

            // Ejercicio 6.4.5
            /*
            Moto V1 = new Moto();
            V1.SetMarca("Yamaha");
            */

            // Ejercicio 6.5.2
            /*
            Persona p1 = new Persona();
            p1.Saludar();
            PersonaInglesa pi1 = new PersonaInglesa();
            PersonaInglesa pi2 = new PersonaInglesa();
            pi1.TomarTe();
            pi2.TomarTe();
            PersonaItaliana pitaly1 = new PersonaItaliana();
            pitaly1.Saludar();
            */

            // Ejercicio 6.6.1
            /*
            PersonaInglesa pi1 = new PersonaInglesa();
            pi1.SetNombre(Console.ReadLine());
            pi1.Saludar();
            */

            // Ejercicio 6.6.2
            /*
            Libro libro1 = new Libro();
            libro1.SetAutor(Console.ReadLine());
            libro1.SetTitulo(Console.ReadLine());
            libro1.SetUbicacion(Console.ReadLine());
            libro1.MostrarLibro();
            */

            // Ejercicio 6.6.4 DONE!!!


            // Ejercicio 6.7.1 DONE!!!

            // Ejercicio 6.7.2
            /*
            Libro libro1 = new Libro();
            libro1.SetAutor(Console.ReadLine());
            libro1.SetTitulo(Console.ReadLine());
            libro1.SetUbicacion(Console.ReadLine());
            libro1.MostrarLibro();
            */

            // Ejercicio 6.7.4
            Vehiculo vehiculo1 = new Vehiculo();
            vehiculo1.Circular();
            int velocidad = Convert.ToInt32(Console.ReadLine());
            vehiculo1.Circular(velocidad);









        }
    }
}
