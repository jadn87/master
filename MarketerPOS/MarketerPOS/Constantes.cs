using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MarketerPOS
{
    class Constantes
    {
        public const String SpeedOfLight = "";
    }

    class estadoTicket
    {
        public const String Ingresado = "INGRESADO";
        public const String Devolucion = "DEVOLUCION";
        public const String Entregado = "ENTREGADO";
    }

    class filtroDescargueTicket
    {
        public const String Filtro_NumTicket = "Número de Ticket";
        public const String Filtro_Cedula = "Cédula";
    }

    class tipoTransaccion
    {
        public const String Venta = "VENTA";
        public const String Devolucion = "DEVOLUCION";
    }

    class movimientoPrendas
    {
        public const String Represadas = "PRENDAS REPRESADAS";
        public const String Entregadas = "PRENDAS ENTREGADAS";
        public const String Devueltas = "PRENDAS DEVUELTAS";
        public const String Novedad = "PRENDAS CON NOVEDADES";
    }


    class cartera
    {
        public const String PorCobrar = "Facturas Pendiente de Cobro";
        public const String Recaudado = "Facturas Cobradas";
    }
}
