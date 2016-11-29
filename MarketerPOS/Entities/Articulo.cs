using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Articulo
    {
        public string ean;
        public string descripcion;
        public decimal valor;

        public Articulo() 
        { }

        public string EAN
        {
            get { return ean; }
            set { ean = value; }
        }

        public string DESCRIPCION
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public decimal VALOR
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
