using System;

namespace POO_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche C1 = new Coche("1234", 2, "Audi");
        }
    }

    public class Coche
    {
        private string matricula;
        private int deposito;
        private string marca;
        public Coche(string matricula, int deposito, string marca)
        {
            this.matricula = matricula;
            this.deposito = deposito;
            this.marca = marca;
        }

        public Coche()
        {
            matricula = "1234 ABC";
            deposito = 0;
            marca = "None";
        }

     
          
        public string GetMatricula()
        {
            return matricula;
        }

        public string GetDeposito()
        {
            return matricula;
        }

        public string GetMarca()
        {
            return matricula;
        }

        public void SetMatricula(string matricula)
        {
            this.matricula = matricula;
        }

        public void SetDeposito(int deposito)
        {
            this.deposito = deposito;
        }

        public void SetMarca(string marca)
        {
            this.marca = marca;
        }
    }

    public class Persona
    {
        private int dni;
        private int edad;
        private string nombre;
        private Coche coche;

        public Persona()
        {
            dni = 1234;
            edad = 0;
            nombre = "Anon";
            coche = new Coche();

        }
       
        public Persona(int dni, int edad, string nombre, Coche coche)
        {
            this.dni = dni;
            this.edad = edad;
            this.nombre = nombre;
            this.coche = coche;
        }

        public void Mostrar()
        {
            Console.WriteLine(dni);
            Console.WriteLine(nombre);
            Console.WriteLine(edad);
        }

        public Coche GetCoche()
        {
            return coche;
        }

        public void SetCoche(Coche coche)
        {
            this.coche = coche;
        }

        public int GetDni()
        {
            return dni;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetNombre()
        {
            return nombre;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }
    }

}
