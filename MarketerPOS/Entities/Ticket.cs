using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class Ticket
    {
        public int localid;
        public decimal numTicket;
        public DateTime fecRegistro;
        public decimal usuario;
        public string tipoDoc;
        public string estado;
        public decimal total;
        public decimal clienteId;

        public Ticket()
        { }


        public int LOCAL_ID 
        {
            get { return localid; }
            set { localid = value; }
        }
        public decimal NUM_TICKET
        {
            get { return numTicket; }
            set { numTicket = value; }
        }
        public DateTime FEC_REGISTRO
        {
            get { return fecRegistro; }
            set { fecRegistro = value; }
        }
        public decimal USUARIO
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public string TIPO_DOC
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }
        public string ESTADO
        {
            get { return estado; }
            set { estado = value; }
        }
        public decimal TOTAL
        {
            get { return total; }
            set { total = value; }
        }
        public decimal CLIENTE_ID
        {
            get { return clienteId ; }
            set { clienteId = value; }
        }

    }
}
