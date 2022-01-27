using System;

namespace TareaAdicional1
{
    class Program
    {
        static int numero = 0;
        static string resultado = "";
        static char operacion = ' ';// "" != " "
        static bool incorrecto, incorrecta;
        static bool repetir = true;

        static int posicion;
        static string anterior = "";
        static string posterior = "";
        static string cadena, remplazar;

        static void PedirNumero()
        {
            incorrecto = true;
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

            resultado += numero;
            incorrecta = true;
        }

        static void PedirOperacion()
        {
            try
            {
                Console.Write("Dame una operacion: ");
                operacion = Convert.ToChar(Console.ReadLine());
                switch (operacion)
                {
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case '=':
                    case 's':
                        incorrecta = false; break;
                    default:
                        Console.WriteLine("--> Operacion incorrecta"); break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("--> Operacion incorrecta");
            }
        }

        static void MostrarResultado()
        {
            Console.WriteLine("El resultado es: " + resultado);
            resultado = "";
            Console.WriteLine();
        }

        static void Comprobar()
        {
            if (operacion != '=' && operacion != 's')
                resultado += operacion;
            if (operacion == 's')
                repetir = false;
        }
            

        static void Prioritarios1()
        {
            if (resultado.IndexOf('*') == -1)
            {
                posicion = resultado.IndexOf('/');
                operacion = '/';
            }
            else
            {
                posicion = resultado.IndexOf('*');
                operacion = '*';
            }

            for (int i = posicion - 1; i >= 0; i--)
            {
                if (anterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                        case '/':
                        case '*':
                            anterior = resultado.Substring(i + 1, posicion - i - 1); break;
                    }
                }
            }

            if (anterior == "")
                anterior = resultado.Substring(0, posicion);
            posicion++;

            for (int i = posicion; i < resultado.Length; i++)
            {
                if (posterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                        case '*':
                        case '/':
                            posterior = resultado.Substring(posicion, i - posicion); break;
                    }
                }
            }

            if (posterior == "")
                posterior = resultado.Substring(posicion, resultado.Length - posicion);

            cadena = anterior + operacion + posterior;

            if (operacion == '*')
                remplazar = "" + (Convert.ToInt32(anterior) * Convert.ToInt32(posterior));
            else
                remplazar = "" + (Convert.ToInt32(anterior) / Convert.ToInt32(posterior));

            resultado = resultado.Replace(cadena, remplazar);
            anterior = posterior = "";
        }

        static void Prioritarios2()
        {
            if (resultado.IndexOf('+') == -1)
            {
                posicion = resultado.IndexOf('-');
                operacion = '-';
            }
            else
            {
                posicion = resultado.IndexOf('+');
                operacion = '+';
            }

            for (int i = posicion - 1; i >= 0; i--)
            {
                if (anterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                            anterior = resultado.Substring(i + 1, posicion - i - 1); break;
                    }
                }
            }

            if (anterior == "")
                anterior = resultado.Substring(0, posicion);
            posicion++;

            for (int i = posicion; i < resultado.Length; i++)
            {
                if (posterior == "")
                {
                    switch (resultado[i])
                    {
                        case '+':
                        case '-':
                            posterior = resultado.Substring(posicion, i - posicion); break;
                    }
                }
            }

            if (posterior == "")
                posterior = resultado.Substring(posicion, resultado.Length - posicion);

            cadena = anterior + operacion + posterior;

            if (operacion == '+')
                remplazar = "" + (Convert.ToInt32(anterior) + Convert.ToInt32(posterior));
            else
                remplazar = "" + (Convert.ToInt32(anterior) - Convert.ToInt32(posterior));

            resultado = resultado.Replace(cadena, remplazar);
            anterior = posterior = "";
        }

        static void Main(string[] args)
        {                       
            do
            {
                // Lógica ya vista para pedir número y operación de forma que comprobemos
                // que cumple con los parámetros establecidos
                do
                {
                    PedirNumero();                
                    do
                    {
                        PedirOperacion();
                    } while (incorrecta);
                    Comprobar();

                } while (operacion != '=' && operacion != 's');
                               
                while (resultado.Contains('*') || resultado.Contains('/'))
                {
                    Prioritarios1();
                }

                while (resultado.Contains('+') || resultado.Contains('-'))
                {
                    Prioritarios2();
                }

                MostrarResultado();
            
            } while (repetir);
            Console.WriteLine("FIN DE PROGRAMA");
        }
    }
}
