using System;

namespace _5._2._3
{
    class Program
    {

        static void Main(string[] args)
        {
            do
            {
                MostrarMenu();

                switch (opcion)
                {
                    case 1: AñadirDato(); break;
                    case 2: MostrarTodas(); break;
                    case 3: MostrarPorTamanyo(); break;
                    case 4: VerFichero(); break;
                    case 5: Finalizar(); break;

                    default: // Otra opcion: no válida
                        Console.WriteLine("Opción desconocida!");
                        break;

                }
            }
            while (opcion != 5); // Si la opcion es 5, terminamos
        }

        public struct tipoFicha
        {
            public string nombreFich; // Nombre del fichero
            public long tamanyo; // El tamaño en KB
        };

        public static tipoFicha[] fichas // Los datos en si
            = new tipoFicha[1000];
        static int numeroFichas = 0; // Número de fichas que ya tenemos
        static int i;
        static long tamanyoBuscar;
        static string textoBuscar;
        static int opcion;

        static void VerFichero()
        {
            Console.WriteLine("¿De qué fichero quieres ver todos los datos?");
            textoBuscar = Console.ReadLine();
            for (i = 0; i < numeroFichas; i++)
                if (fichas[i].nombreFich == textoBuscar)
                    Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                    fichas[i].nombreFich, fichas[i].tamanyo);
        }

        static void MostrarPorTamanyo()
        {
            Console.WriteLine("¿A partir de que tamaño quieres ver?");
            tamanyoBuscar = Convert.ToInt64(Console.ReadLine());
            for (i = 0; i < numeroFichas; i++)
                if (fichas[i].tamanyo >= tamanyoBuscar)
                    Console.WriteLine("Nombre: {0}; Tamaño: {1} KB", fichas[i].nombreFich, fichas[i].tamanyo);

        }

        static void MostrarTodas()
        {
            for (i = 0; i < numeroFichas; i++)
                Console.WriteLine("Nombre: {0}; Tamaño: {1} KB",
                fichas[i].nombreFich, fichas[i].tamanyo);

        }

        static int MostrarMenu()
        {

            Console.WriteLine();
            Console.WriteLine("Escoja una opción:");
            Console.WriteLine("1.- Añadir datos de un nuevo fichero");
            Console.WriteLine("2.- Mostrar los nombres de todos los ficheros");
            Console.WriteLine("3.- Mostrar ficheros por encima de un cierto tamaño");
            Console.WriteLine("4.- Ver datos de un fichero");
            Console.WriteLine("5.- Salir");
            opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }

        static void AñadirDato()
        {
            if (numeroFichas < 1000)
            { // Si queda hueco
                Console.WriteLine("Introduce el nombre del fichero: ");
                fichas[numeroFichas].nombreFich = Console.ReadLine();
                Console.WriteLine("Introduce el tamaño en KB: ");
                fichas[numeroFichas].tamanyo = Convert.ToInt32(
                Console.ReadLine());
                // Y ya tenemos una ficha más
                numeroFichas++;
            }
            else // Si no hay hueco para más fichas, avisamos
                Console.WriteLine("Máximo de fichas alcanzado (1000)!");
        }

        static void Finalizar()
        {
            Console.WriteLine("Fin del programa");                   
        }       
    }   
}
    
