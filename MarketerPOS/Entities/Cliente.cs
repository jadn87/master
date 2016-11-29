using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Cliente
    {
        public decimal id;
        public string nombre;
        public string apellido;
        public decimal cedula;
        public string direccion;
        public string telefono;
        public string email;

        public Cliente()
        { }


        public decimal ID 
        {
            get { return id; }
            set { id = value; }
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
        public decimal CEDULA
        {
            get { return cedula; }
            set { cedula = value; }
        }
        public string DIRECCION
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string TELEFONO
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string EMAIL
        {
            get { return email; }
            set { email = value; }
        }

    }
}
