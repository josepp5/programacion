using System;

namespace practica_ahorcado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaro y inicializo algunas de las variables que usare mas tarde en el programa.
            bool caracterCorrecto;              
            char caracter = ' ';
            int acierto = 0;
            int vidas = 6;
            string original;

            do
            {             
                Console.Write("Introduce una palabra:");  // Le pido al usuario una palabra para adivinar, la palabra introducida sera el valor de la variable original.
                original = Console.ReadLine();
                Console.Clear();                          // Borro la consola para que la palabra no quede escrita en la terminal.
            }
            while (original.Length <= 1);                 // Bucle que seguira pidiendo una palabra mientras el valor introducido por el usuario tenga menos de dos caracteres.
                  
            char[] letras = original.ToCharArray();       // Convierte el string en un array de caracteres.

            char[] resuelto = new char[original.Length]; // Inicializo un Array de caracteres del mismo tamaño cuyos valores estan sin asignar.
            
            do
            {
                caracterCorrecto = false;
                while (caracterCorrecto == false)
                {
                    try
                    {
                        Console.WriteLine();
                        Console.Write("Letra :");                       
                        caracter = Convert.ToChar(Console.ReadLine()); // Pedimos al usuario que introduzca una letra que guardamos en formato char en la variable.
                        Console.WriteLine();
                        caracterCorrecto = true;
                    }
                    catch (Exception) // Con este catch capturamos la excepcion en caso que se produzca y mostramos un mensaje en la terminal.
                    {
                        Console.WriteLine();
                        Console.WriteLine("Debes introducir solo una letra");
                        Console.WriteLine();
                    }
                }

                string imprimir = ""; // Declaro y inicializo la variable que contiene la pista con los huecos y letras acertadas de la palabra.
                
                if (original.Contains(caracter)) // Entramos en este If si la variable original contiene el caracter introducido por el usuario.
                {
                    for (int i = 0; i < letras.Length; i++) // Bucle for para recorrer la palabra y comprobar si la palabra a adivinar contiene el caracter introducido.
                    {
                        if (resuelto[i] == caracter)  // Este If muestra un mensaje si el caracter se encuentra en la palabra original y ademas se ha introducido anteriormente.
                        {
                            Console.WriteLine("Esa letra ya la has introducido anteriormente! Prueba de nuevo con otra letra :)");
                            Console.WriteLine();
                            imprimir += caracter;
                            
                        } else 
                        {
                            if (letras[i] == caracter) // En esta parte del bucle se comprueba si la letra esta y se guarda en su correspondiente posicion.
                            {
                                resuelto[i] = caracter;
                                imprimir += caracter;
                                acierto++;
                            } else                      // O en caso de que no este se mostrara una barra baja.
                            {
                                if (resuelto[i] != letras[i])
                                {
                                    imprimir += "_ ";
                                }
                                else            // Si la letra esta resuelta y no ha entrado en niguna de las condiciones anteriores entonces añadimos la letra resuelta
                                {
                                    imprimir += resuelto[i];  
                                }
                            }
                        }
                    }
                    Console.WriteLine(imprimir); // imprimimos por pantalla la palabra que tiene convertidos los huecos sin resolver a '_' 
                }
                else                // else que restara una vida en caso de que la palabra no contenga la letra introducida
                {
                    vidas--;

                    Console.WriteLine(" ______ ");
                    Console.WriteLine(" |    |");
                    Console.WriteLine(" |    o");
                    switch (vidas)      // Switch que mostrara el dibujo del ahorcado correspondiente segun las vidas que queden.
                    {
                        case 5:
                            Console.WriteLine(" |");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |_________ ");
                            Console.WriteLine();
                            Console.WriteLine(); break;

                        case 4:
                            Console.WriteLine(" |    |");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |_________ ");
                            Console.WriteLine();
                            Console.WriteLine(); break;
                        case 3:
                            Console.WriteLine(" |   /|");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |_________ ");
                            Console.WriteLine();
                            Console.WriteLine(); break;
                        case 2:
                            Console.WriteLine(" |   /|\\");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |_________ ");
                            Console.WriteLine();
                            Console.WriteLine(); break;
                        case 1:
                            Console.WriteLine(" |   /|\\");
                            Console.WriteLine(" |   /");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |_________ ");
                            Console.WriteLine();
                            Console.WriteLine(); break;
                        case 0:
                            Console.WriteLine(" |   /|\\");
                            Console.WriteLine(" |   / \\");
                            Console.WriteLine(" |");
                            Console.WriteLine(" |_________ ");
                            Console.WriteLine();
                            Console.WriteLine(); break;

                    }

                    for (int i = 0; i < letras.Length; i++)  // Se le imprime por pantalla el resultado acumulado para que lo tenga en cuenta para la siguiente letra que introducira.
                    {
                        if (resuelto[i] != letras[i])
                        {
                            Console.Write("_ ");
                        }
                        Console.Write(resuelto[i]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("tienes {0} vidas", vidas);

            } while (acierto != original.Length && vidas != 0);   // el juego termina cuando el usuario ha acertado todas las letras de la palabra o pierde todas las vidas.

            if (vidas == 0)             // If que muestra mensaje cuando pierdes todas las vidas
            {
                Console.WriteLine();
                Console.WriteLine("R.I.P Has perdido la palabra era {0}", original);
                Console.WriteLine();
            }
            if (acierto == resuelto.Length)     // If que muestra mensaje cuando aciertas la palabra
            {
                Console.WriteLine();
                Console.WriteLine("ENHORABUENA!! HAS ACERTADO LA PALABRA!!!");
                Console.WriteLine();
            }
        }

    }

}