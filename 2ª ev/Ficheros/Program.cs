using System;
using System.IO;

namespace Ficheros
{
    class Program
    {
        public const string ruta = "..\\..\\..\\File\\";
        static void Main(string[] args)
        {
            /*   

            // abrir / crear fichero
            StreamWriter fichero = File.CreateText("prueba.txt");


            // Modificar contenido fichero
            fichero.WriteLine("hola");
            fichero.Write("adios");

            // Cerrar fichero
            fichero.Close();

            */

            // StreamReader fichero = File.OpenText("prueba.txt");



            /*
            string nombreFichero = ruta + "prueba.txt";
            StreamWriter ficheroCrear = new StreamWriter("prueba.txt");
            ficheroCrear.WriteLine("asdasda");
            ficheroCrear.Close();


            if (File.Exists(nombreFichero))
            {               
                Mostrar(nombreFichero);

                StreamWriter ficheroWriter = File.AppendText("prueba.txt");

                ficheroWriter.WriteLine("Otra linea mas");

                ficheroWriter.Close();

                Mostrar(nombreFichero);
            } 
            */
            /*
           (8.1.1) Crea un programa que vaya leyendo las frases que el usuario teclea y las
           guarde en un fichero de texto llamado "registroDeUsuario.txt".Terminará cuando
           la frase introducida sea "fin"(esa frase no deberá guardarse en el fichero).
           */

            string fichero = ruta + "prueba.txt";
            string texto;
            StreamWriter edicion = new StreamWriter(fichero);
            Console.WriteLine("Inicio programa");

            do
            {
                texto = Console.ReadLine();
                if (texto != "fin")
                    edicion.WriteLine(texto);
            } while (texto != "fin");
            edicion.Close();
            Console.WriteLine("Fin del programa");


        }
        /*
        public static void Mostrar(string nombreFichero)
        {
            StreamReader ficheroReader = new StreamReader("prueba.txt");
            string linea;
            do
            {
                linea = ficheroReader.ReadLine();
                if (linea != null)
                    Console.WriteLine(linea);
            } while (linea != null);

            ficheroReader.Close();
        */
            
        

    }
}
