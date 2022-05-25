using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2Solucion
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected string telefono1;
        protected string telefono2;
        protected string direccion;
        protected string email;
        protected string poblacion;
        protected string provincia;
        protected Random random = new Random();

        public Persona(string nombre, string apellido, string telefono1, string telefono2, string direccion, string email, string poblacion, string provincia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono1 = telefono1;
            this.telefono2 = telefono2;
            this.direccion = direccion;
            this.email = email;
            this.poblacion = poblacion;
            this.provincia = provincia;
        }
        
        public new string ToString()
        {
            return nombre + " " + apellido;
        }

        public virtual string GetDetalles()
        {
            return "nombre : " + nombre + "|| apellido : " + apellido + " || telefono : " + telefono1 + " || direccion : " + direccion + " || poblacion : " + poblacion + " || email : " + email + " || provincia : " + provincia;
        }

        public string GetPoblacion()
        {
            return poblacion;
        }

        public string GetApellido()
        {
            return apellido;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public string GetTelefono1()
        {
            return telefono1;
        }

        public string GetDireccion()
        {
            return direccion;
        }

        public string GetEmail()
        {
            return email;
        }


        public void SetApellidos(string apellido)
        {
            this.apellido = apellido;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetPoblacion(string poblacion)
        {
            this.poblacion = poblacion;
        }

        public void SetTelefono1(string telefono1)
        {
            this.telefono1 = telefono1;
        }

        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }

        public void SetEmail(string email)
        {
            this.email = email;
        }
    }
}
