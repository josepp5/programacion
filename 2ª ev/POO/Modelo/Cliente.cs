using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Modelo
{
    public class Cliente : Persona
    {
        private string cuenta;

        ~Cliente()
        {

        }

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
