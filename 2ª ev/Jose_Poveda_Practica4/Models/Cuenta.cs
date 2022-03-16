using System;
using System.Collections.Generic;
using System.Text;

namespace Jose_Poveda_Practica4.Models
{
    public class Cuenta
    {
        public int dinero = 1000;
        public int identificador;
        public int codigo_sucursal;

        public Cuenta(int dinero, int identificador, int codigo_sucursal)
        {
            this.dinero = dinero;
            this.identificador = identificador;
            this.codigo_sucursal = codigo_sucursal;
        }

        public string MostrarCuentasSuc()
        {
            return string.Format("        {0}       |       {1}      |       {2}         ", identificador, dinero , codigo_sucursal);
        }

        public int Ingresar(int cantidad)
        {
            dinero += cantidad;
            return dinero;
        }
        public int Retirar(int cantidad)
        {         
            dinero -= cantidad;
            return dinero;
        }
        public int GetIdentificador_cuenta()
        {
            return identificador;
        }
        public void SetIdentificador_cuenta(int identificador)
        {
            this.identificador = identificador;
        }
        public int GetDinero()
        {
            return dinero;
        }
        public void SetDinero(int dinero)
        {
            this.dinero = dinero;
        }
    }
}
