using System;
using System.Collections.Generic;
using System.Text;

namespace practica_3.Models
{
    public class Persona   // Creado un objeto clase persona que recibira los atributos del formulario
    {
        public string nombre;
        public string primerApellido;
        public int telefono;
        public string email;
        public string codigoPostal; // En un principio lo habia declarado int pero no mostraba los 0 ala izquierda que se muestran en los codigos postales, al hacerlo cadena de texto se muestran manteniendo la restrinccion (solo numeros)
        public string direccion;
        public string poblacion;
        public string provincia;

        public Persona() // Creado un constructor vacio
        {
        }
        public Persona(string nombre, string primerApellido, int telefono, string email, string codigoPostal, string direccion, string provincia, string poblacion) // Creado constructor sobrecargado
        {
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.telefono = telefono;
            this.email = email;
            this.codigoPostal = codigoPostal;
            this.direccion = direccion;
            this.provincia = provincia;
            this.poblacion = poblacion;
        }
        public string ToSQL(string tabla) // esta funcion crea la sentencia de SQL con los valores de persona y el tipo (distribuidor/cliente) recogidos del formulario
        {
            return string.Format("INSERT INTO {0} " +
                    "(nombre, primerApellido, telefono, email, codigoPostal, direccion, poblacion, provincia) VALUES ({1}, {2}, {3}, {4}, {5}, {6}, {7}, {8})",
                     tabla, nombre, primerApellido, telefono, email, codigoPostal, direccion, poblacion, provincia);
        }


        // Creados gets and sets 
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public void SetprimerApellido(string primerApellido)
        {
            this.primerApellido = primerApellido;

        }
        public string GetprimerApellido()
        {
            return primerApellido;
        }
        public void SetTelefono(int telefono)
        {
            this.telefono = telefono;
        }
        public int GetTelefono()
        {
            return telefono;
        }
        public void SetEmail(string email)
        {
            this.email = email;

        }
        public string GetEmail()
        {
            return email;
        }
        public void SetCodigoPostal(string codigoPostal)
        {
            this.codigoPostal = codigoPostal;
        }
        public string GetCodigoPostal()
        {
            return codigoPostal;
        }
        public void SetDireccion(string direccion)
        {
            this.direccion = direccion;
        }
        public string GetDireccion()
        {
            return direccion;
        }
        public void SetProvincia(string provincia)
        {
            this.provincia = provincia;
        }
        public string GetProvincia()
        {
            return provincia;
        }
    }
}
