using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Modelo
{
    public class Persona
    {
        private int dni;
        private int edad;
        private string nombre;

        public Persona() { }

        public Persona(int dni, int edad, string nombre)
        {
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
        }

        public void Mostrar()
        {
            Console.WriteLine(dni);
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
        }

        public int GetDni()
        {
            return dni;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public bool Equals(Persona persona)
        {
            if (dni == persona.dni
                && nombre == persona.nombre
                && edad == persona.edad)
            {
                return true;
            }
            return false;
        }
    }
}
