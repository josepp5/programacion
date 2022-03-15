using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected int cilindrada;
        protected float potencia;
        protected int cantidadDeRuedas;
        public int velocidad;

        public void Circular()
        {
            this.velocidad = 50;
        }

        public void Circular(int velocidad)
        {
            Console.Write("introduce la velocidad a la que circulas:");
            Console.Write("Tu velocidad es: " + velocidad);
        }

        public int GetVelocidad()
        {
            return velocidad;
        }
        public void SetVelocidad(int velocidad)
        {
            this.velocidad = velocidad;
        }

        public void MostrarCoche()
        {
            Console.WriteLine(this.marca);
            Console.WriteLine(this.modelo);
            Console.WriteLine(this.cilindrada);
            Console.WriteLine(this.potencia);
        }
        public string GetMarca()
        {
            return marca;
        }
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
        public string GetModelo()
        {
            return modelo;
        }
        public void SetModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public int GetCilindrada()
        {
            return cilindrada;
        }
        public void SetCilindrada(int Cilindrada)
        {
            this.cilindrada = Cilindrada;
        }
        public float GetPotencia()
        {
            return potencia;
        }
        public void SetPotencia(float Potencia)
        {
            this.potencia = Potencia;
        }
        public int GetCantidadDeRuedas()
        {
            return cantidadDeRuedas;
        }
        public void SetCantidadDeRuedas(int cantidadDeRuedas)
        {
            this.cantidadDeRuedas = cantidadDeRuedas;
        }
    }
}
