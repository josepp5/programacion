using System;
using System.Collections.Generic;
using System.Text;

namespace practica5_Jose_Poveda_DAM1.Models
{
    public class Cliente
    {
        string nombre;
        string apellido;
        string provincia;

        public Cliente(string nombre, string apellido, string provincia)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.provincia = provincia;
        }

        public string ToString(string tipo)
        {
            if (tipo == "Cliente")
            {
                return nombre + "#" + apellido + "#" + provincia;
            }else
                return nombre + " " + apellido + " " + provincia;
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
