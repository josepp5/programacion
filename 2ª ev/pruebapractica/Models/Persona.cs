using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace practica4.Models
{
    public class Persona
    {
        public string nombre;
        public string primerApellido;
        public int dni;
        public int cuenta;
        public int codigo_sucursal;
        
        public Persona(string nombre, int dni, string primerApellido, int cuenta, int codigo_sucursal)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.primerApellido = primerApellido;
            this.cuenta = cuenta;
            this.codigo_sucursal = codigo_sucursal;
        }
        public Persona()
        { }
        public string MostrarCuenta()
        {
            return string.Format("        {0}       |       {1}      |       {2}         ", nombre, cuenta, codigo_sucursal);
        }
        public string MostrarCliente()
        {
            return string.Format("        {0}       |       {1}      |       {2}     |      {3}    |       {4}   ", nombre, primerApellido, dni, cuenta, codigo_sucursal);
        }

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public int GetDni()
        {
            return dni;
        }
        public void SetCDni(int dni)
        {
            this.dni = dni;
        }
        public string GetPrimerApellido()
        {
            return primerApellido;
        }
        public void SetPrimerApellido(string primerApellido)
        {
            this.primerApellido = primerApellido;
        }
        public int GetCuenta()
        {
            return cuenta;
        }
        public void SetCuenta(int cuenta)
        {
            this.cuenta = cuenta;
        }
    }
}
