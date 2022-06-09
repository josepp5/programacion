using System;
using System.Collections.Generic;
using System.Text;

namespace practicandoexamen4.Models
{
    public class Persona
    {
        string nombre;
        string apellido;
        string tipo;

        public Persona(string nombre, string apellido, string tipo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.tipo = tipo;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public override string ToString()
        {
            return nombre + " " + apellido + " " + tipo;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public string ToJSON()
        {
            return "{\"nombre\" : \"" + nombre + "\" , \"apellido\" : \"" + apellido + "\"}";
        }
    }
}
