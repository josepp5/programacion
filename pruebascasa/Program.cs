using System;

namespace pruebascasa
{
    class Program
    {
        static void Main(string[] args)
        {

            // Ejercicio de suma con numeros introducidos por el usuario

            /*
            int numeroUno;
            int numeroDos;
            int calculo;


            Console.WriteLine("introduce el primer numero");
            numeroUno = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("introduce el segundo numero");
            numeroDos = Convert.ToInt32(Console.ReadLine());

            calculo = numeroUno + numeroDos;
            Console.WriteLine("La suma de {0} y {1} es igual a {2}", numeroUno , numeroDos, calculo
                ); 
            */

            /* Ejercicio pasar a millas 1.8.1
             
       
            int metros = Convert.ToInt32(Console.ReadLine());
            int resultado = metros * 1056;
            Console.WriteLine(resultado);

            Console.WriteLine("La conversion es: {0}", resultado); */


            // ejercicio sumar tres numero tecleados por el usuario 1.9.3
            /*
            int numerouno;
            int numerodos;
            int numerotres;
           

            Console.WriteLine("introduce el primer numero");
            numerouno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("introduce el segundo numero");
            numerodos = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("introduce el tercer numero");
            numerotres = Convert.ToInt32(Console.ReadLine());

            int resultado = numerouno + numerodos + numerotres;

            Console.WriteLine("La suma de {0} , {1} y {2} es {3} ", numerouno , numerodos , numerotres , resultado);
             */

            /* ejercicio  ReadLine pasar a millas la cifra intrducida 1.9.4
            Console.WriteLine("Introduce el numero en millas nauticas que quieres convertir a metros");
            
            int millas = Convert.ToInt32(Console.ReadLine());
            int resultado = millas * 1056;

            Console.WriteLine("la conversion es {0} metros", resultado);

            */

            //Ejercicio 1.11.1

            /*
            Console.WriteLine("introduce un numero");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("introduce otro numero");
            int b = Convert.ToInt32(Console.ReadLine());

            int operaciona = (a + b) * (a - b);
            int operacionb = a * b - b * b;

            Console.WriteLine(operaciona);
            Console.WriteLine(operacionb);

            Console.WriteLine("El resultado de ({0} + {1})* ({0} - {1}) es {2}" , a , b , operaciona);
            Console.WriteLine("El resultado de {0} + {1} * {0} - {1} es {2}", a, b, operaciona);

            */








            //Ejercicio crear tabla de multiplicar 1.11.3

            /*
            
            Console.WriteLine("Introduce el numero para ver su tabla de multiplicar");
            int numerouno = Convert.ToInt32(Console.ReadLine());
            
            
            int calculo = numerouno * 1;
            Console.Write(" {0} por 1 es {1}", numerouno, calculo);
           
            calculo = numerouno * 3;
            Console.Write(" {0} por 3 es {1}", numerouno, calculo);

            calculo = numerouno * 4;
            Console.Write(" {0} por 4 es {1}", numerouno, calculo);

            calculo = numerouno * 5;
            Console.Write(" {0} por 5 es {1}", numerouno, calculo);

            calculo = numerouno * 6;
            Console.Write(" {0} por 6 es {1}", numerouno, calculo);

            calculo = numerouno * 7;
            Console.Write(" {0} por 7 es {1}", numerouno, calculo);

            calculo = numerouno * 8;
            Console.Write(" {0} por 8 es {1}", numerouno, calculo);

            calculo = numerouno * 9;
            Console.Write(" {0} por 9 es {1}", numerouno, calculo);

            calculo = numerouno * 10;
            Console.Write(" {0} por 10 es {1}", numerouno, calculo);

            
            */

            //ejercicio tabla sin {0} etc 1.11.3

            /*   
            int numerouno;
            Console.WriteLine("introduce el numero");
            numerouno = Convert.ToInt32(Console.ReadLine());

            int calculo = numerouno * 2;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 2 es ");
            Console.Write(calculo);
        

            calculo = numerouno * 3;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 3 es ");
            Console.Write(calculo);
            
            calculo = numerouno * 4;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 4 es ");
            Console.Write(calculo);
            
            calculo = numerouno * 5;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 5 es ");
            Console.Write(calculo);

            calculo = numerouno * 6;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 6 es ");
            Console.Write(calculo);

            calculo = numerouno * 7;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 7 es ");
            Console.Write(calculo);

            calculo = numerouno * 8;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 8 es ");
            Console.Write(calculo);

            calculo = numerouno * 9;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 9 es ");
            Console.Write(calculo);

            calculo = numerouno * 10;
            Console.Write(" El resultado de ");
            Console.Write(numerouno);
            Console.Write(" por 10 es ");
            Console.Write(calculo);

                */


            //ejercicio  convertir grados celsius 1.11.4
              /*
                        int celsius;
                        Console.WriteLine("introduce los grados celsius");
                        celsius = Convert.ToInt32(Console.ReadLine());

                        int kelvin = celsius + 273;
                        int faren = celsius * 18 / 10 + 32;

                        Console.Write(" la conversion kelvin es ");
                        Console.Write(kelvin);
                        Console.Write(" y ");
                        Console.Write(" la conversion faren.. es ");
                        Console.Write(faren);

                 */       


        }
    }
}
