using System;
using System.Text;

namespace tema_4_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*(4.1.1.1) Un programa que pida al usuario 4 números, los memorice(utilizando un
            array), calcule su media aritmética y después muestre en pantalla la media y los
            datos tecleados.

            int[] num = new int[3];
            int media;
            int resultado;
            Console.WriteLine("Introduce un numero");
            num[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero");
            num[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero mas");
            num[2] = Convert.ToInt32(Console.ReadLine());

            media = num[0] + num[1] + num[2];
            resultado = media / 3;

            Console.WriteLine("La media es {0}", resultado);

            */
            /*
             pag 114 (4.1.1.2) Un programa que pida al usuario 5 números reales(pista: necesitarás un
            array de "float") y luego los muestre en el orden contrario al que se introdujeron.
            

            float[] num = new float[5];
            int i = 0;

            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine("Dame un numero");
                num[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine();

            for ( i = 4; i >= 0; i--)
            {
                Console.WriteLine(num[i]);
            }
            */

            /* (4.1.2.1) Un programa que almacene en una tabla el número de días que tiene 
            cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique 
            un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que 
            tiene ese mes.
            
            int[] mes = new int[12] { 31, 28, 30, 31, 30, 31, 30, 31, 30, 31, 30, 31 };

            Console.WriteLine("Escribe el numero del mes para saber cuantos dias tiene");
            int i = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(mes[i-1]);
            */


            /*(4.1.3.1) Crea un programa que pida al usuario 6 números enteros cortos y luego
            los muestre en orden inverso(pista: usa un array para almacenarlos y "for" para
            mostrarlos).

            float[] num = new float[6];
            int i;

            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Dame un numero");
                num[i] = Convert.ToSingle(Console.ReadLine());
            }

            Console.WriteLine();
            

            for (i = 5; i >= 0; i--)
            {
                Console.Write("{0}, " , num[i]);
            }

            */


            /* (4.1.3.2) Crea un programa que pregunte al usuario cuántos números enteros va a
              introducir(por ejemplo, 10), le pida todos esos números, los guarde en un array y
              finalmente calcule y muestre la media de esos números. 

            
            int i;
            int veces;
            int media;

            Console.WriteLine("Cuantos numeros vas a introducir?");
            veces = Convert.ToInt32(Console.ReadLine());

            float[] num = new float[veces];

            for (i = 0; i < veces; i++)
            {
                Console.WriteLine("Dame un numero");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            media = num[i] + veces;
            media /= veces;

            Console.WriteLine("La media es {0}", media);
           */

            // Ejercicio clase mirar pag 131 y 132 substring y indexOf interesa tener 3 int's.
            /*
            string original = "Hola Adios Pepe rthrhrtg rsggsrgersg";
            int numero = original.Split(' ').Length;

            string[] resultado = new string[numero];
            int inicio = 0;
            int num_char;
            int final;
                      
            for (int i = 0; i < numero; i++)
            {
                final = original.IndexOf(' ', inicio);               
                num_char = final - inicio;

                if (final == -1)
                    num_char = original.Length - inicio;
                    
                resultado[i] = original.Substring(inicio, num_char);             
                inicio = final + 1;
            }

            for (int i = 0; i < numero; i++)
            Console.WriteLine(resultado[i]);
            */

            /* (4.4.9.2) Un programa que pida una cadena al usuario y la modifique, de modo
             que las letras de las posiciones impares(primera, tercera, etc.) estén en
             minúsculas y las de las posiciones pares estén en mayúsculas, mostrando el
             resultado en pantalla. Por ejemplo, a partir de un nombre como "Nacho", la
             cadena resultante sería "nAcHo". 

            Console.WriteLine("Dame una palabra");
            string aux = Console.ReadLine();
            StringBuilder cadena = new StringBuilder(aux);

            for (int i = 0; i < cadena.Length; i++)
                if (i % 2 == 0)
                    cadena[i] = char.ToLower(cadena[i]);
                else
                    cadena[i] = char.ToUpper(cadena[i]);

            Console.WriteLine(cadena);

        */
            Console.WriteLine("Dame una frase");
            string[] palabra = new string[2];

            palabra[1] = Console.ReadLine();

            Console.WriteLine("Dame otra frase");

            palabra[2] = Console.ReadLine();

            if (palabra[1].Length > palabra[2].Length)
                Console.WriteLine("La primera frase es mayor");
            else
                Console.WriteLine("La segunda frase introducida es mayor")























        }
    }
}
