

namespace Examen2Solucion
{
    public class Cliente : Persona
    {
        public int codigo;

        public Cliente(string nombre, string apellido, string telefono1, string telefono2, string direccion, string email, string poblacion, string provincia) : base(nombre, apellido, telefono1, telefono2, direccion, email, poblacion, provincia)
        {
            codigo = random.Next(1000, 10000);
        }

        public new string ToString()
        {
            return base.ToString() + " - Código: " + codigo;
        }

        public new string GetDetalles()
        {
            return base.GetDetalles() + " - Código: " + codigo;
        }     
    }
}
