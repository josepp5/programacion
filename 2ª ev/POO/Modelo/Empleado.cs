using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Modelo
{
    public class Empleado : Persona
    {
        private string cuenta;

        public string GetCuenta()
        {
            return cuenta;
        }

        public void SetCuenta(string cuenta)
        {
            this.cuenta = cuenta;
        }
    }
}
