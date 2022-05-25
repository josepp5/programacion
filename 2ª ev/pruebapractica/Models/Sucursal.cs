using System;
using System.Collections.Generic;
using System.Text;

namespace practica4.Models
{
    public class Sucursal
    {
        
        public int codigo_sucursal;
        public string ciudad_sucursal;
        public string codigoPostal;
        public string ubicacion;
        

        public Sucursal(int codigo_sucursal, string ciudad_sucursal, string codigoPostal, string ubicacion)
        {
            this.ciudad_sucursal = ciudad_sucursal;
            this.codigo_sucursal = codigo_sucursal;
            this.ubicacion = ubicacion;
            this.codigoPostal = codigoPostal;
        }
        public Sucursal()
        {

        }

        public string MostrarSucursal() // devuelve un string que se inserta en el item de la tabla correspondiente
        {
            return string.Format("        {0}       |       {1}      |       {2}     |      {3}", codigoPostal, ciudad_sucursal, ubicacion, codigo_sucursal);
        }

        public int GetCodigo_sucursal()
        {
            return codigo_sucursal;
        }
        public void SetCodigo_sucursal(int codigo_sucursal)
        {
            this.codigo_sucursal = codigo_sucursal;
        }
        public string GetCiudad_sucursal()
        {
            return ciudad_sucursal;
        }
        public void SetCiudad_sucursal(string ciudad_sucursal)
        {
            this.ciudad_sucursal = ciudad_sucursal;
        }
        public string GetUbicacion()
        {
            return ubicacion;
        }
        public void SetUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        public string GetCodigoPostal()
        {
            return codigoPostal;
        }
        public void SetCodigoPostal(string codigoPostal)
        {
            this.codigoPostal = codigoPostal;
        }
    }
}
