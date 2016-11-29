using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Parametro
    {
        public string nombre;
        public string valor;


        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string VALOR
        {
            get { return valor; }
            set { valor = value; }
        }

    }
}
