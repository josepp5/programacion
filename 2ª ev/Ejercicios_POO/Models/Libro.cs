using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class Libro : Documento
    {
        protected string autor;
        protected string titulo;
        protected string ubicacion;

        public Libro(string autor, string titulo, string ubicacion)
        {
            this.SetAutor(autor);
            this.SetTitulo(titulo);
            this.SetUbicacion(ubicacion);
        }

        public Libro()
        {
            this.SetAutor(autor);
            this.SetTitulo(titulo);
            this.SetUbicacion("No detallada");
        }

        public void MostrarLibro()
        {
            Console.WriteLine("Autor - " + this.autor);
            Console.WriteLine("Titulo - " + this.titulo);
            Console.WriteLine("Ubicacion - " + this.ubicacion);
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
