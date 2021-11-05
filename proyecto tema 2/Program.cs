using System;

namespace proyecto_tema_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // if (condicion) sentencia
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)

                Console.WriteLine("Mayor que 0 ");

            else

                if (a == 0)
                Console.WriteLine("El numero es 0");

            else

                Console.WriteLine("Menor que 0 ");



            Console.WriteLine("Continuar...");
            */









            // Ejercicio (2.1.1.1) pag 48
            /*
             Console.WriteLine("Introduce un numero");
             int a = Convert.ToInt32(Console.ReadLine());

             if (a % 2 == 0)
                 Console.WriteLine("El numero es par");
             else
                 Console.WriteLine("El numer no es par");
            */






            //Ejercicio (2.1.1.2)
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine(" el numero {0} es mayor que {1}", a, b);
            if (b > a)
                Console.WriteLine("el numero {0} es mayor que {1}", b, a);
            */







            //Ejercicio (2.1.1.3)
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());
            
            if (a % b == 0)
                Console.WriteLine("El numero es multiplo");
            else
                Console.WriteLine("El numer no es multiplo");
            */







            //Ejercicio (2.1.2.1) pag 49
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());


            if (a % 10 == 0)
                Console.WriteLine("Es mutiplo de 10");
            else
                Console.WriteLine("No es mutiplo de 10");

            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            if (b % 10 == 0)
                Console.WriteLine("Es multiplo de 10");
            else
                Console.WriteLine(" no es multiplo de 10");
            */





            //Ejercicio 2.1.5.1

            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 3 == 0 || a % 2 == 0)
                Console.WriteLine("Es mutiplo de 3 y de 2");

            */



            //Ejercicio 2.1.5.2
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());

            if ((a % 2 == 0) && !(a % 3 == 0))
                Console.WriteLine("Es mutiplo de 2 y no de 2");

            */




            //Ejercicio 2.1.5.6
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0 || b % 2 == 0)
                Console.WriteLine("Al menos un numero es par");
            else
                Console.WriteLine("Ningun numero es par");
            */

            //Ejercicio 2.1.5.7
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            if (((a % 2 == 0) && !(b % 2 == 0))
                || (!((a % 2 == 0) && !(b % 2 == 0))))
                Console.WriteLine("Al menos un numero es par");
            else
                Console.WriteLine("Ningun numero es par");
            */





            //Ejercicio 2.1.5.8
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

           
            if ( a > 0 && b > 0)
                Console.WriteLine("Los dos numeros son positivos");
            if (a > 0 || b > 0)
                Console.WriteLine("Uno de los numeros es positivo");
            else
                Console.WriteLine("ninguno de los dos numeros es positivos");
            */





            //Ejercicio (2.1.5.9)
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce un 3er numero");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
                Console.WriteLine("{0} es mayor que {1} y {2}", a , b , c);

            if (b > a && b > c)
                Console.WriteLine("{0} es mayor que {1} y {2}", b, a, c);

            if (c > a && c > b)
                Console.WriteLine("{0} es mayor que {1} y {2}", c, a, b);
            */






            //Ejercicio 2.1.5.10
            /*
            Console.WriteLine("Introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
                Console.WriteLine("Los numeros son iguales");
            else
            {
                if (a > b)
                    Console.WriteLine("{0} es mayor que {1}", a, b);

                else
                    Console.WriteLine("{0} es mayor que {1}", b, a);
            }
            */


            //Ejercicio (2.1.8.1)Crea un programa que use el operador condicional para mostrar un el

            /*

            Console.WriteLine("Introduce un numero");
            int resultado;
            int a = Convert.ToInt32(Console.ReadLine());

            resultado = (a < 0) ? a * -1 : a;
            Console.WriteLine("El resultado es {0}", resultado);
            */




            // Ejercicio 2.1.8.2
            /*
            int a, b, mayor;


            Console.Write("Escriba un número: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Escriba otro: ");
            b = Convert.ToInt32(Console.ReadLine());
           
            mayor = a > b ? a : b;
            Console.WriteLine("El mayor de los números es {0}.", mayor);
            */


            //Ejercicio (2.1.9.1)
            /*


            Console.Write("Escriba un número del 1 al 5: ");
            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1: Console.WriteLine("Uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                
                default: Console.WriteLine("error");
                    break;
            }

            */

            //Ejercicio (2.1.9.2)
            /*
            Console.Write("Escriba un número, letra o caracter ");
            int a = Convert.ToChar(Console.ReadLine());

            switch (a)
            {
              
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("Es un numero");
                    break;

                case ':': case '.': case ';': case '-':
                    Console.WriteLine("Es un caracter");
                    break;
               
                default:
                    Console.WriteLine("error");
                    break;
            }

            */


            //Ejercicio (2.1.9.3)
            /*

            Console.Write("Escriba un número, letra o caracter ");
            int a = Convert.ToChar(Console.ReadLine());

            switch (a)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine("Es un numero");
                    break;

                case 'a': case 'e': case 'i': case 'o': case 'u':
                    Console.WriteLine("Es una vocal");
                    break;

                default:
                    Console.WriteLine("Es una consonante");
                    break;
            }

            */

            //Ejercicio (2.1.9.5)

            Console.Write("Escriba un número, letra o caracter ");
            char a = Convert.ToChar(Console.ReadLine());

            if ((a >= '0') && (a <= '9'))
                Console.WriteLine("Es un numero");

            else
            {
                if ((a == '-') || (a == '.') || (a == ','))
                    Console.WriteLine("es un caracter");

                else
                    Console.WriteLine("Es una letra");
            }





            //Ejercicio (2.1.9.6)
                /*
                Console.Write("Escriba un número, letra o caracter ");
                char a = Convert.ToChar(Console.ReadLine());

                if ((a == 'a') || (a == 'e') || (a == 'i') || (a == 'o') || (a == 'u'))
                    Console.WriteLine("Es una volcal");
                else
                {
                    if ((a >= '0') && (a <= '9'))
                        Console.WriteLine("Es un numero");

                    else
                    {
                        Console.WriteLine("Es una consonante");
                    }


                }
                */

                


















        }
    }
}
