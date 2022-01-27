using System;

namespace TareaAdicional1
{
    class Program
    {
        public static int numero = 0;
        public static string resultado = ""; // 2+3*5-7
        public static char operacion = ' ';
        static void Main(string[] args)
        {
            bool repetir = true;
            
            do
            {
                do
                {
                    PedirNumero();
                    repetir = PedirOperacion();
                } while (operacion != '=' && operacion != 's');

                CalcularResultado('*', '/');
                CalcularResultado('+', '-');

                Console.WriteLine("El resultado es: " + resultado);
                resultado = "";
                Console.WriteLine();
            
            } while (repetir);
            Console.WriteLine("FIN DE PROGRAMA");
        }

        public static void PedirNumero()
        {
            bool incorrecto = true;
            do
            {
                try
                {
                    Console.Write("Dame un número: ");
                    numero = Convert.ToInt32(Console.ReadLine());
                    incorrecto = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("--> Número incorrecto");
                }
            } while (incorrecto);

            if (operacion == '/' && numero == 0)
            {
                Console.WriteLine("--> No se puede dividir por 0");
                PedirNumero();
            }
            else
            {
                resultado += numero;
            }
        }

        public static bool PedirOperacion()
        {
            bool incorrecta = true;
            do
            {
                try
                {
                    Console.Write("Dame una operacion: ");
                    operacion = Convert.ToChar(Console.ReadLine());
                    switch (operacion)
                    {
                        case '+': case '-': case '*': case '/': case '=': case 's': incorrecta = false; break;
                        default: Console.WriteLine("--> Operacion incorrecta"); break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("--> Operacion incorrecta");
                }
            } while (incorrecta);

            if (operacion != '=' && operacion != 's') resultado += operacion;

            if (operacion == 's') return false;
            else return true;
        }
    
        public static void CalcularResultado(char oper1, char oper2)
        {
            while (resultado.Contains(oper1) || resultado.Contains(oper2))
            {
                int posicion;

                if (resultado.IndexOf(oper1) == -1)
                {
                    posicion = resultado.IndexOf(oper2);
                    operacion = oper2;
                }
                else
                {
                    posicion = resultado.IndexOf(oper1);
                    operacion = oper1;
                }

                int anterior = CalcularAnterior(posicion);
                posicion++;
                int posterior = CalcularPosterior(posicion);

                Remplazar(anterior, posterior);
            }
        }

        public static int CalcularAnterior(int posicion)
        {
            string anterior = "";
            
            for (int i = posicion - 1; i >= 0; i--)
            {
                if (anterior == "")
                {
                    switch (resultado[i])
                    {
                        case '*': case '/': case '+': case '-':
                            anterior = resultado.Substring(i + 1, posicion - i - 1); break;
                    }
                }
            }

            if (anterior == "")
                anterior = resultado.Substring(0, posicion);

            return Convert.ToInt32(anterior);
        }

        public static int CalcularPosterior(int posicion)
        {
            string posterior = "";

            for (int i = posicion; i < resultado.Length; i++)
            {
                if (posterior == "")
                {
                    switch (resultado[i])
                    {
                        case '*': case '/': case '+': case '-':
                            posterior = resultado.Substring(posicion, i - posicion); break;
                    }
                }
            }

            if (posterior == "")
                posterior = resultado.Substring(posicion, resultado.Length - posicion);

            return Convert.ToInt32(posterior);
        }

        public static void Remplazar(int anterior, int posterior)
        {
            string cadena = "" + anterior + operacion + posterior;
            string remplazar = "";

            switch (operacion)
            {
                case '*': remplazar += anterior * posterior; break;
                case '/': remplazar += anterior / posterior; break;
                case '+': remplazar += anterior + posterior; break;
                case '-': remplazar += anterior - posterior; break;
            }

            resultado = resultado.Replace(cadena, remplazar);
        }
    }
}