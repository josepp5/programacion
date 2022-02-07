using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class Libro
    {
        public string autor;
        public string titulo;
        public string ubicacion;


        public void Mostrar()
        {
            Console.WriteLine(this.autor);
            Console.WriteLine(this.titulo);
            Console.WriteLine(this.ubicacion);
        }
        public string GetAutor()
        {
            return autor;
        }
        public void SetAutor(string autor)
        {
            this.autor = autor;
        }
        public string GetTitulo()
        {
            return titulo;
        }
        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
        }
        public string GetUbicacion()
        {
            return ubicacion;
        }
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
    }
}
