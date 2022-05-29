using System;
using System.Collections.Generic;
using System.Text;

namespace practica5_Jose_Poveda_DAM1.Models
{
    public struct Cliente
    {
        int id;
        string nombre;
        string apellido;
        string provincia;

        public Cliente(string nombre, string apellido, string provincia)
        {
            this.id = Cliente.identificador++;
            this.nombre = nombre;
            this.apellido = apellido;
            this.provincia = provincia;
        }

        private static int identificador = 0;

        public string ToString(bool conProvincia)
        {
            if (conProvincia)
            {
                return nombre + "#" + apellido + "#" + provincia;
            } else return nombre + " " + apellido;
        }

        public int GetIdentificador()
        {
            return id;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public string GetProvincia()
        {
            return provincia;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public void SetProvincia(string provincia)
        {
            this.provincia = provincia;
        }
    }
}
