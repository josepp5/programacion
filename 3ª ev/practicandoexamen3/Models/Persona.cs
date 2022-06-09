using System;
using System.Collections.Generic;
using System.Text;

namespace Jose_Poveda_DAM_1.Models
{
    public class Persona
    {
        public int codigo;
        public string nombre;
        public string apellido;
        public string telefono;
        public string direccion;
        public string tipo;

        public Persona(int codigo ,string nombre, string apellido, string telefono, string direccion, string tipo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.direccion = direccion;
            this.tipo = tipo;
        }

        public Persona(int codigo, string nombre, string telefono, string direccion, string tipo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;
            this.tipo = tipo;
        }

        public void SetCodigo(int codigo)
        {
            this.codigo = codigo;
        }

        public int GetCodigo()
        {
            return codigo;
        }
        
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public void SetTelefono(string telefono)
        {
            this.telefono = telefono;
        }

        public string GetTelefono()
        {
            return telefono;
        }

        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public string GetDireccion()
        {
            return telefono;
        }

        public string ToStringCliente(string a)
        {
            if (a == "#")
                return codigo + "#" + nombre + "#" + apellido + "#" + telefono + "#" + direccion;
            else
                return codigo + " " + nombre + " " + apellido + " " + telefono + " " + direccion;
        }

        public string ToStringDistribuidor(string a)
        {
            if (a == "#")
                return codigo + "#" + nombre + "#" + telefono + "#" + direccion;
            else
                return codigo + " " + nombre + " " + telefono + " " + direccion;
        }

        public string PersonaToJSON(string tipo)
        {
            if (tipo == "c")
                return "\"" + codigo + "\" :{ \"nombre\" : \"" + nombre +"\", \"apellido\" : \"" + apellido + "\", \"telefono\" : \"" + telefono + "\", \"direccion\" : \"" + direccion + "\"},";
            else
                return "\"" + codigo + "\" :{ \"nombre\" : \"" + nombre + "\", \"telefono\" : \"" + telefono + "\", \"direccion\" : \"" + direccion + "\"},";


        }
    }
}
