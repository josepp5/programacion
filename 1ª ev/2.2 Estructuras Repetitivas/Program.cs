using System;

namespace _2._2_Estructuras_Repetitivas
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio (2.2.1.1.1)
            /*
            Console.WriteLine("introduce la contraseña");
            int contraseña = Convert.ToInt32(Console.ReadLine());
            

            while (contraseña != 1111 ) // --> FALSO
            {
                contraseña = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("contraseña aceptada");
            */




            //Ejercicio (2.2.1.1.2)
            /*
             Console.WriteLine("introduce un numero para saber su cuadrado");
             int num = Convert.ToInt32(Console.ReadLine());


             while (num != 0) // --> FALSO
             {

                 int res = (num * num);
                 Console.WriteLine(res);
                 Console.WriteLine("introduce otro numero para saber su cuadrado");
                 num = Convert.ToInt32(Console.ReadLine());


             }
             Console.WriteLine("Se acabo");
            
            */


            /* Ejercicio (2.2.1.1.3/4) Crea un programa que pida de forma repetitiva pares de números al
            usuario.Tras introducir cada par de números, responderá si el primero es múltiplo
           del segundo 


            Console.WriteLine("introduce un numero (El cero para finalizar)");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introduce otro numero (El cero para finalizar)");
            int num2 = Convert.ToInt32(Console.ReadLine());



            while (num1 != 0|| num2 != 0) // --> FALSO
            {
                if (num1 % num2 == 0)
                    Console.WriteLine("son multiplos");
                else
                    Console.WriteLine("no son multiplos");

                Console.WriteLine("introduce un numero (El cero para finalizar)");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("introduce otro numero (El cero para finalizar)");
                num2 = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Finalizado");
            */







            /*(2.2.1.2.1) Crea un programa que escriba en pantalla los números del 1 al 10,
                usando "while". 

            int num1 = 0;


            while (num1 < 11)

            {
                Console.WriteLine(num1++);
            } */





            /*  (2.2.1.2.2) Crea un programa que escriba en pantalla los números pares del 26 al
                  10(descendiendo), usando "while". 


            int num1 = 26;

            while (num1 >=  10)
            {
                Console.WriteLine(num1);
                num1 = num1 - 2;
            }*/





            /*(2.2.1.2.3) Crea un programa calcule cuantas cifras tiene un número entero
            positivo(pista: se puede hacer dividiendo varias veces entre 10).


            
            int num1 = Convert.ToInt32(Console.ReadLine());
            int contador = 1;


            while (num1 >= 10 ) 
            {
                num1 = num1 / 10;
                contador++;
            }

            Console.WriteLine(contador);
            */




            /* (2.2.1.2.4) Crea el diagrama de flujo y la versión en C# de un programa que dé al
             usuario tres oportunidades para adivinar un número del 1 al 10.

            Console.WriteLine("Adivina");
            int num= Convert.ToInt32(Console.ReadLine());
            int intentos = 2;

            while ( num!= 5 && intentos != 0)
            {
                Console.WriteLine("Prueba otra vez");
                num = Convert.ToInt32(Console.ReadLine());
                intentos--;

            }

            if (num == 5)
            Console.WriteLine("confirmado");
            else
                Console.WriteLine("Denegado");

            */





            /* (2.2.2.1) Crear un programa que pida números positivos al usuario, y vaya
            calculando y mostrando la suma de todos ellos (terminará cuando se teclea un
            número negativo o cero). 

            int num1;
            int resultado = 0;
            do
            {
                
                Console.WriteLine("introduce un numero (Valor negativo o cero para finalizar)");
                num1 = Convert.ToInt32(Console.ReadLine());

                int suma = num1 + resultado;
                           
                Console.WriteLine("{0} mas {1} es {2}", num1, resultado, suma);

                resultado = suma;
                               
            }
            while (num1 > 0);
            {
                Console.WriteLine("finalizado"); 
            }  


            */



            /*  (2.2.2.2) Crea un programa que escriba en pantalla los números del 1 al 10,
                  usando "do..while"   


            int num1 = 1;
            do
            {
                Console.WriteLine(num1++);
            }

            while (num1 <= 10);
            {
                
            }
            */


            /*  (2.2.2.3) Crea un programa que escriba en pantalla los números pares del 26 al 10
  (descendiendo), usando "do..while".   

            int num1 = 26;


            do
            {
             Console.WriteLine(num1);
             num1 = num1 - 2;
            }
            while (num1 >= 10);
                               
            
            */

            /*  (2.2.2.4) Crea un programa que pida al usuario su identificador y su contraseña
              (ambos numéricos), y no le permita seguir hasta que introduzca como
              identificador "1234" y como contraseña "1111" 

            int identi;
            int pass;

            do
            {
                Console.WriteLine("introduce tu identificador");
                identi = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("introduce tu password");
                pass = Convert.ToInt32(Console.ReadLine());

                if (identi != 1234 || pass != 1111)
                    Console.WriteLine("Has Fallado");

                else
                {
                    Console.WriteLine("Has Acertado");
                }
            }
            while (identi != 1234 || pass != 1111);
                     
            */





            /*   (2.2.2.5) Crea un programa que pida al usuario su identificador y su contraseña, y
               no le permita seguir hasta que introduzca como nombre "Pedro" y como
               contraseña "Peter" 

            string identi;
            string pass;

            do
            {
                Console.WriteLine("introduce tu identificador");
                identi = Console.ReadLine();

                Console.WriteLine("introduce tu password");
                pass = Console.ReadLine();

                if (identi != "pedro" || pass != "peter")
                    Console.WriteLine("Has Fallado");

                else
                {
                    Console.WriteLine("Has Acertado");
                }
            }
            while (identi != "pedro" || pass != "peter");

            */







            /* (2.2.3.1) Crea un programa que muestre los números del 10 al 20, ambos
            incluidos. 



            for (int num1 = 10; num1 < 21; num1++) 
            {
                Console.WriteLine(num1);
            }

           */




            /*  (2.2.3.2) Crea un programa que escriba en pantalla los números del 1 al 50 que
                  sean múltiplos de 3(pista: habrá que recorrer todos esos números y ver si el resto
                  de la división entre 3 resulta 0). 


            for (int num1 = 0; num1 < 51; num1++)
            
            {
               if ( num1 % 3 == 0 )
                Console.WriteLine(num1);
            }

            */


            /*  (2.2.3.1.3) Crea un programa que muestre los números del 100 al 200(ambos
  incluidos) que sean divisibles entre 7 y a la vez entre 3. 


            for (int num1 = 100; num1 < 200; num1++)

            {
                if (num1 % 7 == 0 && num1 % 3 == 0)
                    Console.WriteLine(num1);
            }
            */


            /*  (2.2.3.4) Crea un programa que muestre la tabla de multiplicar del 9. 

            int num1;


            for (num1 = 0; num1 <= 10; num1++)
                Console.WriteLine(num1 * 9);

            */


            /* (2.2.3.5) Crea un programa que muestre los primeros ocho números pares: 2 4 6 8 
            10 12 14 16 (pista: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar 
            el doble del valor que hace de contador). 

            int num1;


            for (num1 = 0; num1 <= 16; num1 = num1 + 2)
                Console.WriteLine(num1 );


        */



            /* (2.2.3.6) Crea un programa que muestre los números del 15 al 5, descendiendo
             (pista: en cada pasada habrá que descontar 1, por ejemplo haciendo i = i - 1, que se
             puede abreviar i--).  


            int num;

            for (num = 15; num >= 5; num--) 
            Console.WriteLine(num);

            */


            /* (2.2.4.1) Crea un programa que contenga un bucle sin fin que escriba "Hola " en
             pantalla, sin avanzar de línea 

            string hola;

            for (hola = "hola"; ;)
                Console.Write( hola);
            */


            /*(2.2.4.2) Crea un programa que contenga un bucle sin fin que muestre los
            números enteros positivos a partir del uno. 


            int num;
            for (num = 0; num >= 0; num++)
                Console.WriteLine(num);
            */


            /*(2.2.5.1) Crea un programa escriba 4 veces los números del 1 al 5, en una misma
            línea, usando "for": 12345123451234512345 

            int num, serie;

            for ( serie = 0; serie < 5; serie++)
             for (num = 1; num <= 5; num++)
                Console.Write(num);
            */

            /* (2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5, en una misma
             línea, usando "while": 12345123451234512345
            

            int num = 1;
            int serie = 0;

            while (serie < 5)
            {               
                serie++;
                while (num <= 5)
                {
                    Console.Write(num);
                    num++;                   
                }
                num = 1;
            }
            */



            /*(2.2.5.3) Crea un programa que, para los números entre el 10 y el 20(ambos
            incluidos) diga si son divisibles entre 5, si son divisibles entre 6 y si son divisibles
            entre 7.


            int num;
            int num1;


            for (num = 10; num <= 20; num++)
            {
                for (num1 = 5; num1 <= 7; num1++)
                {
                    if (num % num1 == 0)
                        Console.WriteLine("{0} es multiplo de {1}", num, num1);
                }
            }
            */



            /* (2.2.6.1) Crea un programa que escriba 4 líneas de texto, cada una de las cuales
             estará formada por los números del 1 al 5 

            int num, serie;

            for (serie = 0; serie < 5; serie++)
            {
                for (num = 1; num <= 5; num++)
                    Console.Write(num);
                Console.WriteLine();
            }

        */

            /*(2.2.6.2) Crea un programa que pida al usuario el ancho(por ejemplo, 4) y el alto
            (por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos:
            

            int num;
            Console.WriteLine("introduce el ancho");
            num = Convert.ToInt32(Console.ReadLine());
                
            int num1;
            Console.WriteLine("introduce el alto");
            num1 = Convert.ToInt32(Console.ReadLine());


            int ancho;
            int alto;

            for (alto =1; alto <= num1 ; alto++)
            {
                for (ancho = 1; ancho <= num; ancho++)
                    Console.Write("*");
                Console.WriteLine();
            }
            */

            /*(2.2.7.1) Crea un programa que muestre las letras de la Z(mayúscula) a la A
            (mayúscula, descendiendo) 

            char letra;

            for (letra = 'Z'; letra >= 'A'; letra--)
                Console.WriteLine(letra);

            */



            /* (2.2.7.2) Crea un programa que muestre 5 veces las letras de la L(mayúscula) a la
             N(mayúscula), en la misma línea.

            char letra;

            for (letra = 'L'; letra <= 'N'; letra++)
                for (int i = 0; i <= 5; i++ )
                Console.Write(letra);

            */


            /*(2.2.8.1) Crea un programa que escriba 6 líneas de texto, cada una de las cuales
            estará formada por los números del 1 al 7.Debes usar dos variables llamadas
            "linea" y "numero", y ambas deben estar declaradas en el "for"

            int linea, num;

            for (linea = 0; linea < 6; linea++)
            {
                for (num = 1; num <= 7; num++)
                    Console.Write(num);
                Console.WriteLine();
            }


            */



            /*(2.2.8.2) Crea un programa que pida al usuario el ancho(por ejemplo, 4) y el alto
            (por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos,
            como en el ejercicio 2.2.6.2.Deberás usar las variables "ancho" y "alto" para los
            datos que pidas al usuario, y las variables "filaActual" y "columnaActual"
            (declaradas en el "for") para el bloque repetitivo.

            int ancho;
            Console.WriteLine("introduce el ancho");
            ancho = Convert.ToInt32(Console.ReadLine());

            int alto;
            Console.WriteLine("introduce el alto");
            alto = Convert.ToInt32(Console.ReadLine());

            int filaActual;
            int columnaActual;

            for (filaActual = 1; filaActual <= alto; filaActual++)
            {
                for (columnaActual = 1; columnaActual <= ancho; columnaActual++)
                    Console.Write("*");
                Console.WriteLine();
            }
            */


            /*(2.2.9.1) Crea un programa que pida un número al usuario y escriba los múltiplos
            de 9 que haya entre 1 ese número. Debes usar llaves en todas las estructuras de
            control, aunque sólo incluyan una sentencia 


            {    
                int num1;
                {
                    Console.WriteLine("introduce un numero");
                    num1 = Convert.ToInt32(Console.ReadLine());
                }
                            
                for (int num = 0; num <= num1; num++)
                {
                    if ( num % 9 == 0)
                    Console.WriteLine(num);
                }
            }
            */


            /*(2.2.9.2) Crea un programa que pida al usuario dos números y escriba sus
            divisores comunes. Debes usar llaves en todas las estructuras de control, aunque
            sólo incluyan una sentencia. 


            int x;
            Console.WriteLine("introduce un numero");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("introduce otro numero");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Los divisores comunes de {0} y {1} son:", x , y);
            int min = x < y ? x : y;

            for (int i = 2; i <= min; i++)
            {
                if(x % i == 0 && y % i ==  0)
                {
                    Console.WriteLine(i);
                }
            }
            */


            /*(2.2.10.1) Crea un programa que pida al usuario dos números y escriba su máximo
            común divisor(pista: una solución lenta pero sencilla es probar con un "for" todos
            los números descendiendo a partir del menor de ambos, hasta llegar a 1; cuando
            encuentres un número que sea divisor de ambos, interrumpes la búsqueda).
            




            int x;
            Console.WriteLine("introduce un numero");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("introduce otro numero");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El MCD de {0} y {1} es:", x, y);
            int min = x < y ? x : y;

            int resultado = 1;
            for (int i = 2; i <= min; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                        resultado = i;
                }
            }
            Console.WriteLine(resultado);
            */


            /* (2.2.10.2) Crea un programa que pida al usuario dos números y escriba su mínimo
             común múltiplo(pista: una solución lenta pero sencilla es probar con un "for"
             todos los números a partir del mayor de ambos, de forma creciente; cuando
             encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda).
            
            

            int x;
            Console.WriteLine("introduce un numero");
            x = Convert.ToInt32(Console.ReadLine());

            int y;
            Console.WriteLine("introduce otro numero");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("El MCM de {0} y {1} es:", x, y);
            int max = x > y ? x : y;

            int resultado = 1;
            for (int i = 1; i <= max; i++)
            {
                if (x % i == 0 && y % i == 0)
                {
                    int mcd = i;
                    resultado = (x * y) / mcd;

                }
            }
            Console.WriteLine(resultado);

            */



            /*(2.2.11.1) Crea un programa que escriba los números del 20 al 10, descendiendo, 
                excepto el 13, usando "continue".
            

            for (int i = 20; i >= 10; i--)
            {
                if (i == 13)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            */




            /* (2.2.11.2) Crea un programa que escriba los números pares del 2 al 106, excepto
                los que sean múltiplos de 10, usando "continue" 


            for (int i = 2; i <= 106; i = i + 2)
            {
                if ( i % 10 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            */


            /* (2.2.12.1) Crea un programa que escriba los números del 100 al 200, separados
              por un espacio, sin avanzar de línea, usando "for".En la siguiente línea, vuelve a
              escribirlos usando "while". 
           
           

            for (int i = 100; i <= 200; i++)
            {               
                Console.Write(" ");
                Console.Write(i);
            }

            Console.WriteLine();

            int b = 100;
            while ( b >= 100 )
            {
                b++;
                Console.Write(b);
                Console.Write(" ");

                if ( b >= 200 )
                {
                    break;
                }
            }

            */



            /*(2.2.12.2) Crea un programa que escriba los números pares del 20 al 10, 
            descendiendo, excepto el 14, primero con "for" y luego con "while". 

            int i = 20;

            for (i = 20; i >= 10; i = i - 2)
            {

                if (i == 14)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();


            int j = 20;

            while ( j >= 10 )
            {
                if (j != 14)
                    Console.WriteLine(j);
                j = j - 2;
                
            }

            */



            /* (2.3.1) Crea un programa que escriba los números del 1 al 10, separados por un
             espacio, sin avanzar de línea.No puedes usar "for", ni "while", ni "do..while", sólo
             "if" y "goto" 

            int i = 0;
        
        comporobar_condicion:
            
            Console.Write(i);
            Console.Write(" ");
            if ( i < 10)
            {
                i++;
                goto comporobar_condicion;
            }

            */
            /* (2.5.1) Crea un programa que cuente cuantas veces aparece la letra 'a' en una 
            frase que teclee el usuario, utilizando "foreach". 

            Console.WriteLine(" Teclea una frase");
            string frase = Console.ReadLine();


            int contador = 0;
            foreach (char letra in frase)
            {
                if (letra == 'a')
                    contador++;
            }
            Console.WriteLine("La frase tiene {0}" , contador);


            */





































        }

    }
}
