using System;
using System.Collections.Generic;
using System.Text;


namespace _01_03_2022.Models
{
    public class Persona
    {
        public string nombre;
        public int edad;
        public string ciudad;

        public Persona(string nombre, int edad, string ciudad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.ciudad = ciudad;
        }

        public Persona()
        {

        }

        public string Mostrar() 
        {
            return string.Format("Nombre: {0}, Edad: {1}, Ciudad: {2}", nombre, edad, ciudad);
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public string GetCiudad()
        {
            return ciudad;
        }

        public void SetCiudad(string ciudad)
        {
            this.ciudad = ciudad;
        }
    }
}
