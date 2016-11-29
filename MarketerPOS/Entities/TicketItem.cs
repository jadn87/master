using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class TicketItem
    {
        public int localid;
        public decimal numTicket;
        public DateTime fecRegistro;
        public int cantidad;
        public decimal valUnitario;
        public string ean;
        public string descripcion;
        public string observacion;

        public TicketItem()
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
        public int CANTIDAD
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal VAL_UNITARIO
        {
            get { return valUnitario; }
            set { valUnitario = value; }
        }
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
        public string OBSERVACION
        {
            get { return observacion; }
            set { observacion = value; }
        }

    }
}
