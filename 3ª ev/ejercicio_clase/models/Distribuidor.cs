

namespace Examen2Solucion
{
    public class Distribuidor : Persona
    {
        private string indentificador;
        
        public Distribuidor(string nombre, string apellido, string telefono1, string telefono2, string direccion, string email, string poblacion, string provincia) : base(nombre, apellido, telefono1, telefono2, direccion, email, poblacion, provincia)
        {
            string alfa = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ0123456789";
            indentificador = "";

            for (int i = 0; i < 10; i++)
                indentificador += alfa[random.Next(0, alfa.Length)];
        }

        public new string ToString()
        {
            return base.ToString() + " - Identificador: " + indentificador;
        }

        public new string GetDetalles()
        {
            return base.GetDetalles() + " - Identificador: " + indentificador;              
        }

        
    }
}
