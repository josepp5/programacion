using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            // --------------------------------------------
            // Jose Poveda Perez
            // Curso DAM
            // Modalidad Presencial
            // Práctica nº 1
            // --------------------------------------------


            int inputNumber = 0; // Se inicializa la variable que guardará el número introducido por teclado.
            char operador = '0'; // Se inicializa la variable que guardará el operador y le damos un caracter por defecto.
            int resultado; // Se declara la variable que acumulara el resultado de las operaciones. 


        Inicio:
        
            try
            {
                Console.Write("Introduce un numero:");
                resultado = Convert.ToInt32(Console.ReadLine());  // El usuario introduce el primer número y se asigna a la variable resultado.
            }
            catch (Exception)   // Capturamos la excepción si el usuario introduce un numero que no puede convertirse a Int32.
            {
                Console.WriteLine("--> Numero incorrecto");
                goto Inicio;   // La ejecución del codigo salta a la etiqueta de Inicio.
            }

            while (operador != 's')   // Bucle que debe iterarse mientras que el usuario no introduzca el caracter 's' cuando le pidan un operador.
            {
                do // Bucle que como minimo se ejecuta en una ocasión y se para cuando el usuario introduce un operador válido.
                {
                    try
                    {
                        Console.Write("Introduce un operador: ");
                        operador = Convert.ToChar(Console.ReadLine());  // El usuario introduce un operador. 
                        switch (operador)   // Determina la lógica a seguir dependiendo del operador que el usuario ha introducido.
                        {
                            case '+': goto PedirNumero; // Como se trata de un operador válido, la ejecución del código salta a la etiqueta de PedirNumero.
                            case '-': goto PedirNumero; //
                            case '*': goto PedirNumero; //
                            case '/': goto PedirNumero; //
                            case '=': Console.WriteLine("El resultado es: {0}\n", resultado); goto Inicio; // Se muestra el resultado y luego vuelve al principio del programa.
                            case 's': Console.WriteLine("El resultado es: {0}", resultado); goto Final; // Se muestra el resultado acumulado y luego va a la etiqueta Final que termina el programa.
                            default: throw new Exception(); // Para cualquier otro valor de operador se entiende que no es un caracter válido y se genera una excepción.
                        }
                    }
                    catch (Exception)   // Se captura una excepción cuando el operador introducido no es un caracter esperado.
                    {
                        Console.WriteLine("--> Operación incorrecta");
                        operador = '0'; // Se restablece el valor de operador al "por defecto", que en nuestro programa es 0.
                    }
                    
                } while (operador == '0'); // Se ejecuta el bucle mientras el valor de operador es 0.

            PedirNumero: 
                try
                {
                    Console.Write("Introduce un numero: ");
                    inputNumber = Convert.ToInt32(Console.ReadLine());  // Se asigna el último valor necesario para realizar la operación matemática

                    switch (operador) // Bloque condicional que ejecuta la operación matemática configurada por el usuario
                    {
                        case '+': resultado += inputNumber; break;
                        case '-': resultado -= inputNumber; break;
                        case '*': resultado *= inputNumber; break;
                        case '/': resultado /= inputNumber; break;
                    }
                }
                catch (DivideByZeroException) // Captura la excepción que aparece al intentar dividir por 0.
                {
                    Console.WriteLine("No se puede dividir entre 0\n");
                    goto Inicio;
                }
                catch (Exception) // Captura cualquier otro tipo de excepción
                {
                    Console.WriteLine("--> Numero incorrecto");
                    goto Inicio;
                }
            }
        Final: // Se ejecuta solo cuando el usuario introduce 's' como operador.
            Console.WriteLine("\n--> Fin del programa");
        }
    }
}
