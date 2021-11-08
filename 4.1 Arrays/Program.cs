using System;

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

            /* pag 114 (4.1.1.2) Un programa que pida al usuario 5 números reales(pista: necesitarás un
            array de "float") y luego los muestre en el orden contrario al que se introdujeron.
            

            float[] num = new float[5];
          
            Console.WriteLine("Introduce un numero");
            num[0] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero");
            num[1] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero mas");
            num[2] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero mas");
            num[3] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce otro numero mas");
            num[4] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("numeros : {0}, {1}, {2}, {3}, {4}", num[4], num[3], num[2], num[1], num[0]);
            */


            /* (4.1.2.1) Un programa que almacene en una tabla el número de días que tiene 
            cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique 
            un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que 
            tiene ese mes. */

            

            int[] mes = new int[12];

            Console.WriteLine("Escribe el numero del mes para saber cuantos dias tiene");
            mes[0] = Convert.ToInt32(Console.ReadLine());

            mes[0] = 31;
            mes[1] = 28;
            mes[2] = 31;
            mes[3] = 30;
            mes[4] = 31;
            mes[5] = 30;
            mes[6] = 31;
            mes[7] = 31;
            mes[8] = 30;
            mes[9] = 31;
            mes[10] = 30;
            mes[11] = 31;

            

            Console.WriteLine(mes[]);






        }
    }
}
