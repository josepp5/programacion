using System;

namespace _2._5_foreach_y_excepciones
{
    class Program
    {
        static void Main(string[] args)
        {



            /*(2.5.1) Crea un programa que cuente cuantas veces aparece la letra 'a' en una
            frase que teclee el usuario, utilizando "foreach".


            Console.WriteLine("Escribe una frase o palabra");
            string palabra = Console.ReadLine();
            int contador = 0;

            foreach (char letra in palabra )
            {
                if ( letra == 'a')
                    contador++;
            }
            Console.WriteLine(contador);
            */


            /*(2.6.1) Crear un programa que dé al usuario la oportunidad de adivinar un número
            del 1 al 100(prefijado en el programa) en un máximo de 6 intentos.En cada
            pasada deberá avisar de si se ha pasado o se ha quedado corto.
            
            
            int pass = 54;                               
            int contador = 6;
            int intento;

            do
            {
                Console.WriteLine("Adivina un numero del 1 al 100");
                intento = Convert.ToInt32(Console.ReadLine());
                contador--;
                                             
                if (intento > pass)
                    Console.WriteLine("Este numero es mayor");
                if (intento < pass)
                    Console.WriteLine("Este numero es menor");
                if (intento == pass)
                { Console.WriteLine("contraseña correcta");                
                    break;                   
                }
                Console.WriteLine("Te quedan {0} intentos", contador);
            } 
            while (contador != 0);                                                        
            if (contador == 0)
                    Console.WriteLine("Te has quedado sin intentos");
             */




            /*(2.6.2) Crear un programa que descomponga un número(que teclee el usuario)
            como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5  


            Console.WriteLine("Teclea un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            int primo;

            for (primo = 2; primo <= 10; primo++)

                while (numero % primo == 0)
                {
                    if (numero % primo == 0)
                    {
                        Console.Write(primo);
                        numero = numero / primo;
                    }
                    
                    if (numero != 1)
                        Console.Write(" · ");
                }
            */

            /*(2.6.3) Crea un programa que calcule un número elevado a otro, usando
            multiplicaciones sucesivas.

            Console.WriteLine("Teclea un numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teclea el numero que quieres elevar el anterior");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int potencia = 1;

           
            for (; num2 > 0; num2--)
            {
                potencia = potencia * numero;
            }
            Console.WriteLine(potencia);

            */

            /*(2.6.4) Crea un programa que "dibuje" un rectángulo formado por asteriscos, con
            el ancho y el alto que indique el usuario, usando dos "for" anidados.Por ejemplo,
            si desea anchura 4 y altura 3, el rectángulo sería así: 

            Console.WriteLine("Teclea el ancho");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teclea el alto");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int ancho;
            int alto;

            for (alto = 1; alto <= num2; alto++)
            {
                for ( ancho = 1; ancho <= num1; ancho++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }             
            */

            /* (2.6.5) Crea un programa que "dibuje" un triángulo decreciente, con la altura que
             indique el usuario.Por ejemplo, si el usuario dice que desea 4 caracteres de alto, el
             triángulo sería así: 

            Console.WriteLine("Teclea el ancho");
            int num1 = Convert.ToInt32(Console.ReadLine());           
            int alto;
            int ancho;
            int contador = num1;

            for (alto = 1; alto <= num1; alto++)
            {   
                for (ancho = 1; ancho <= contador; ancho++)
                {
                    Console.Write("*");                   
                }               
                Console.WriteLine();
                contador--;                                
            }
            */

            /* (2.6.6) Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una
             fila(o columna) de asteriscos y cuyo interior esté formado por espacios en blanco, 
             con el ancho y el alto que indique el usuario. Por ejemplo, si desea anchura 4 y
             altura 3, el rectángulo sería así:

            Console.WriteLine("Teclea el ancho");
            int ancho = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teclea el alto");
            int alto = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < alto; i++)
            {
                string cadena = "";
                for (int j = 0; j < ancho; j++)
                {
                    if(i == 0 || i == alto-1)
                    {
                        cadena += "*";
                    } else
                    {
                        cadena += (j == 0 || j == ancho - 1) ? "*":" ";
                    }
                }
                Console.WriteLine(cadena);
            }
            */



            /*(2.6.7) Crea un programa que "dibuje" un triángulo creciente, alineado a la
            derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice que
            desea 4 caracteres de alto, el triángulo sería así:

            Console.WriteLine("Teclea el ancho");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int alto;
            int ancho;
            int contador = num1;

            for (alto = 1; alto <= num1; alto++)
            {
                for (ancho = 1; ancho <= num1; ancho++)
                {
                    if ( ancho >= contador )
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
                contador--;                
            }
            */


            /*(2.6.8) Crea un programa que devuelva el cambio de una compra, utilizando
            monedas(o billetes) del mayor valor posible. Supondremos que tenemos una
            cantidad ilimitada de monedas(o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay
            decimales.La ejecución podría ser algo como:

            int precio;
            int pagado;
            int cambio;
            
            do
            {
                Console.WriteLine("Teclea el precio");
                precio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Teclea cuanto pagas");
                pagado = Convert.ToInt32(Console.ReadLine());
                cambio = pagado - precio;

                Console.Write("Tu cambio es de {0}, toma pardillo: ", cambio);
               
                while (cambio >= 100)
                {
                    cambio -= 100;
                    Console.Write(" 100 ");
                }

                while (cambio >= 50)
                {
                    cambio -= 50;
                    Console.Write(" 50 ");
                }

                while (cambio >= 20)
                {
                    cambio -= 20;
                    Console.Write(" 20 ");
                }

                while (cambio >= 10)
                {
                    cambio -= 10;
                    Console.Write(" 10 ");
                }

                while (cambio >= 5)
                {
                    cambio -= 5;
                    Console.Write(" 5 ");
                }

                while (cambio >= 2)
                {
                    cambio -= 2;
                    Console.Write(" 2 ");
                }

                while (cambio >= 1)
                {
                    cambio -= 1;
                    Console.Write(" 1 ");
                }
                Console.WriteLine();
            }
            while (precio != 0 && pagado != 0);
            */




            /* (2.7.1) Crea un programa que pregunte al usuario su edad y su año de nacimiento.
             Si la edad que introduce no es un número válido, mostrará un mensaje de aviso.
             Lo mismo ocurrirá si el año de nacimiento no es un número válido. 

             int edad = 1;
             int fecha = 0;
             do
             {
                 try
                 {
                     Console.WriteLine("introduce tu edad : ");
                     edad = Convert.ToInt32(Console.ReadLine());
                 }
                 catch (Exception)
                 {
                     Console.WriteLine("Edad no valida");
                 }

                 try
                 {
                     Console.WriteLine("introduce tu año de nacimiento : ");
                     fecha = Convert.ToInt32(Console.ReadLine());
                     edad = 0;
                 }
                 catch (Exception)
                 {
                     Console.WriteLine("año no valido");
                 }


             } while (edad != 0);
             Console.WriteLine("Fin del programa");


             */

            /* (3.1.4.1) Crea un programa que use tres variables x, y, z. Sus valores iniciales serán
                 15, -10, 214.Deberás incrementar el valor de estas variables en 12, usando el
                 formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el
                 resultado obtenido por el programa. 

             int x = 15;
             int y = -10;
             int z = 214;
             int i = 12;

             Console.WriteLine(x + i);
             Console.WriteLine(y + i);
             Console.WriteLine(z + i);

             */


            /* (3.2.1.1) Crea un programa que muestre el resultado de dividir 3 entre 4 usando
                números enteros y luego usando números de coma flotante. 

            int i1 = 3, i2 = 4;
            float calculo;

            calculo = i1 / i2;

            Console.WriteLine(calculo);


            float n1 = 3, n2 = 4;
            float resultado;

            resultado = n1 / n2;

            Console.WriteLine(resultado);

           */

            /*(3.2.2.2) Calcula el área de un círculo, dado su radio, que será un número entero
            (área = pi * radio al cuadrado)

            int radio;
            float area;

            Console.WriteLine("Introduce el radio para calcular el area del circulo");
            radio = Convert.ToInt32(Console.ReadLine());

            area = radio * radio * 3.14f;

            Console.WriteLine("El Area del circulo es: {0}", area);

            */



            /*(3.2.3.1) Calcula el volumen de una esfera, dado su radio, que será un número de
            doble precisión(volumen = pi * radio al cubo *4 / 3. */

            double radio;
            double volumen;

            Console.WriteLine("Introduce el radio para calcular el volumen de la esfera");
            radio = Convert.ToDouble(Console.ReadLine());

            volumen = radio * radio * radio * 3.14f * 4 / 3 ;

            Console.WriteLine("El volumen de la esfera es: {0}", volumen);






        }

    }
}
