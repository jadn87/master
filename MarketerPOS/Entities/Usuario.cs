using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Usuario
    {
        public decimal id;
        public string password;
        public string nombre;
        public string apellido;
        public string telefono;


        public decimal ID
        {
            get { return id; }
            set { id = value; }
        }

        public string PASSWORD
        {
            get { return password; }
            set { password = value; }
        }

        public string NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string APELLIDO
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
