using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios_POO.Models
{
    class Documento
    {
        protected int paginas;

        public int GetPaginas()
        {
            return paginas;
        }
        public void SetPaginas(int paginas)
        {
            this.paginas = paginas;
        }
    }
}
