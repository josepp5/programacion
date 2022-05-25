using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_Jose_Poveda.Models
{
    public class Cliente
    {
        public string nombre;
        public string primerApellido;
        public int telefono;
        public string email;
        public string direccion;
        public string provincia;
        public int codigo;

        public Cliente(string nombre, string primerApellido, int telefono, string email, string direccion, string provincia, int codigo)
        {
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.telefono = telefono;
            this.email = email;
            this.direccion = direccion;
            this.provincia = provincia;
            this.codigo = codigo;
        }

        public Cliente()
        {

        }

        public string MostrarDatosC()
        {
            return string.Format(nombre + " " + primerApellido + " " + telefono + " " + email + " " + direccion + " " + provincia + " " + codigo);
        }
    }
}
