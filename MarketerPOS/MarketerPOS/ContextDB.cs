using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Entities;

namespace MarketerPOS
{
    public class ContextDB
    {
        public POSConnection connex;
        SqlDataReader dr;

        public void autocomplete(TextBox tb) {

            try
            {
                connex = new POSConnection();
                connex.openConnection();
                connex.cmd = new SqlCommand("select descripcion from articulos", connex.cnn);
                dr = connex.cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    tb.AutoCompleteCustomSource.Add(dr["descripcion"].ToString());
                }

                dr.Close();
                connex.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible autocompletar el texto. "+ex.ToString());
                connex.closeConnection();
            }
        }

        public string consultaEan(string tipoPrenda)
        {
            string ean = "";
            try
            {                
                connex = new POSConnection();
                connex.openConnection();
                connex.cmd = new SqlCommand("select ean from articulos where descripcion = @tipoPrenda;", connex.cnn);
                connex.cmd.Parameters.Add("@tipoPrenda", SqlDbType.VarChar);
                connex.cmd.Parameters["@tipoPrenda"].Value = tipoPrenda;
                dr = connex.cmd.ExecuteReader();

                if (dr.Read()) return ean = dr["ean"].ToString();
                

                dr.Close();
                connex.closeConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No fue posible autocompletar el texto. " + ex.ToString());
                connex.closeConnection();
            }

            return ean;
        }


        public String calculateVal(String cadena) {

            try
            {
                connex = new POSConnection();
                connex.openConnection();
                connex.cmd = new SqlCommand("select valor from articulos where descripcion = @desc; ", connex.cnn);
                connex.cmd.Parameters.Add("@desc", SqlDbType.VarChar);
                connex.cmd.Parameters["@desc"].Value = cadena.Trim();


                dr = connex.cmd.ExecuteReader();
                if (dr.Read())
                {
                    return dr["valor"].ToString();
                }

                dr.Close();
                connex.closeConnection();
            }
            catch (Exception)
            {
                
                throw;  
            }
            return "";
        }



        public Cliente  findClient(decimal id)
        {
            Cliente cliente = new Cliente();
            connex = new POSConnection();

            try
            {                
                connex.openConnection();
                String query = "select nombre, apellido, telefono, correo, direccion " ;
                query = query + "from clientes where cedula = @ID; ";
                connex.cmd = new SqlCommand(query, connex.cnn);
                connex.cmd.Parameters.Add("@ID", SqlDbType.Decimal);
                connex.cmd.Parameters["@ID"].Value = id;


                dr = connex.cmd.ExecuteReader();
                if (dr.Read())
                {
                    cliente.NOMBRE = dr["nombre"].ToString();
                    cliente.APELLIDO = dr["apellido"].ToString();
                    cliente.TELEFONO = dr["telefono"].ToString();
                    cliente.EMAIL = dr["correo"].ToString();
                    cliente.DIRECCION = dr["direccion"].ToString();
                }

                dr.Close();
                connex.closeConnection();
            }
            catch (Exception)
            {

                throw;
            }
            return cliente;
        }


        public List<Articulo> getArticles()
        {
            List<Articulo> listArticulo=null;
            try
            {
                connex = new POSConnection();
                connex.openConnection();
                connex.cmd = new SqlCommand("select ean,descripcion,valor from articulos", connex.cnn);                

                dr = connex.cmd.ExecuteReader();
                listArticulo = new List<Articulo>();
                while (dr.Read())
                {
                    Articulo art = new Articulo() { EAN = dr["ean"].ToString(), 
                                                    DESCRIPCION = dr["descripcion"].ToString(),
                                                    VALOR = Convert.ToDecimal(dr["valor"].ToString()) };
                    listArticulo.Add(art);
                }

                dr.Close();
                connex.closeConnection();

                return listArticulo;

            }
            catch (Exception)
            {

                throw;
            }
            
        }


        public List<Cliente> getClientes()
        {
            List<Cliente> listCliente = null;
            try
            {
                connex = new POSConnection();
                connex.openConnection();
                connex.cmd = new SqlCommand("select id,nombre,apellido,cedula,correo,direccion,telefono from clientes", connex.cnn);

                dr = connex.cmd.ExecuteReader();
                listCliente = new List<Cliente>();
                while (dr.Read())
                {
                    Cliente cli = new Cliente()
                    {
                        ID = Convert.ToDecimal(dr["id"].ToString()),
                        NOMBRE = dr["nombre"].ToString(),
                        APELLIDO = dr["apellido"].ToString(),
                        CEDULA = Convert.ToDecimal(dr["cedula"].ToString()),
                        EMAIL = dr["correo"].ToString(),
                        DIRECCION = dr["direccion"].ToString(),
                        TELEFONO = dr["telefono"].ToString()
                    };
                    listCliente.Add(cli);
                }

                dr.Close();
                connex.closeConnection();

                return listCliente;

            }
            catch (Exception)
            {

                throw;
            }

        }



        public decimal GetNextTicketNumberValue()
        {
            connex = new POSConnection();
            connex.openConnection();
            decimal nextVal=0;
            connex.cmd = new SqlCommand("SELECT NEXT VALUE FOR nextTicketNumber AS VALOR", connex.cnn);

            dr = connex.cmd.ExecuteReader();
            if (dr.Read()) nextVal = Convert.ToDecimal(dr["VALOR"].ToString());

            dr.Close();
            connex.closeConnection();

            return nextVal;
        }


        public void crearCliente(Cliente cliente)
        {
            try 
	        {	    
                connex = new POSConnection();
                connex.openConnection();
                string query = @"INSERT INTO Clientes(nombre,apellido,cedula,telefono,correo,direccion) 
                                            VALUES(@nom,@ape,@ced,@tel,@cor,@dir)";
                connex.cmd = new SqlCommand(query, connex.cnn);
//                connex.cmd.CommandType = CommandType.Text;
//                connex.cmd.CommandText = @"INSERT INTO Clientes(nombre,apellido,cedula,telefono,correo,direccion) 
//                                            VALUES(@nom,@ape,@ced,@tel,@cor,@dir)";

                connex.cmd.Parameters.AddWithValue("@nom", cliente.NOMBRE);
                connex.cmd.Parameters.AddWithValue("@ape", cliente.APELLIDO);
                connex.cmd.Parameters.AddWithValue("@ced", cliente.CEDULA);
                connex.cmd.Parameters.AddWithValue("@tel", cliente.TELEFONO);
                connex.cmd.Parameters.AddWithValue("@cor", cliente.EMAIL);
                connex.cmd.Parameters.AddWithValue("@dir", cliente.DIRECCION);
        
                int response = connex.cmd.ExecuteNonQuery();

                connex.closeConnection();
                //return response >= 1;
            }
            catch (SqlException e)
            {
                throw e;
            }

             
        }



        public void crearTicket(Ticket ticket)
        {
            try
            {
                connex = new POSConnection();
                connex.openConnection();

                string query = @"INSERT INTO Tickets(local,numTicket,fecRegistro,usuario,tipoDoc,estado,total,clienteId) 
                                            VALUES(@loc,@numtk,@fecReg,@usu,@tipDoc,@est,@tot,@cli)";
                connex.cmd = new SqlCommand(query, connex.cnn);
//                connex.cmd.CommandType = CommandType.Text;
//                connex.cmd.CommandText = @"INSERT INTO Tickets(local,numTicket,fecRegistro,usuario,tipoDoc,estado,total) 
//                                            VALUES(@loc,@numtk,@fecReg,@usu,@tipDoc,@est,@tot)";

                connex.cmd.Parameters.AddWithValue("@loc", ticket.LOCAL_ID);
                connex.cmd.Parameters.AddWithValue("@numtk", ticket.NUM_TICKET);
                connex.cmd.Parameters.AddWithValue("@fecReg", ticket.FEC_REGISTRO);
                connex.cmd.Parameters.AddWithValue("@usu", ticket.USUARIO);
                connex.cmd.Parameters.AddWithValue("@tipDoc", ticket.TIPO_DOC);
                connex.cmd.Parameters.AddWithValue("@est", ticket.ESTADO);
                connex.cmd.Parameters.AddWithValue("@tot", ticket.TOTAL);
                connex.cmd.Parameters.AddWithValue("@cli", ticket.CLIENTE_ID);

                int response = connex.cmd.ExecuteNonQuery();

                connex.closeConnection();

                //return response >= 1;
            }
            catch (SqlException e)
            {
                throw e;
            }

        }


        public void crearTicketItems(TicketItem item)
        {
            try
            {
                connex = new POSConnection();
                connex.openConnection();

                string query = @"INSERT INTO Ticketitems(local,numTicket,fecRegistro,cantidad,valUnitario,ean,descripcion,observacion) 
                                            VALUES(@loc,@numtk,@fecReg,@cant,@valunit,@ean,@desc,@obs)";
                connex.cmd = new SqlCommand(query, connex.cnn);

                connex.cmd.Parameters.AddWithValue("@loc", item.LOCAL_ID);
                connex.cmd.Parameters.AddWithValue("@numtk", item.NUM_TICKET);
                connex.cmd.Parameters.AddWithValue("@fecReg", item.FEC_REGISTRO);
                connex.cmd.Parameters.AddWithValue("@cant", item.CANTIDAD);
                connex.cmd.Parameters.AddWithValue("@valunit", item.VAL_UNITARIO);
                connex.cmd.Parameters.AddWithValue("@ean", item.EAN);
                connex.cmd.Parameters.AddWithValue("@desc", item.DESCRIPCION);
                connex.cmd.Parameters.AddWithValue("@obs", item.OBSERVACION);

                int response = connex.cmd.ExecuteNonQuery();

                connex.closeConnection();

                //return response >= 1;
            }
            catch (SqlException e)
            {
                throw e;
            }

        }


        public List<Ticket> getFacturasXCliente(String clienteId)
        {
            List<Ticket> listTicket = null;
            try
            {
                connex = new POSConnection();
                connex.openConnection();
                
                String query = "select local, numticket, fecregistro, usuario, tipodoc, estado, total from tickets ";
                query = query + "where clienteId = @cliente and estado = 'INGRESADO'; ";
                connex.cmd = new SqlCommand(query, connex.cnn);
                connex.cmd.Parameters.Add("@cliente", SqlDbType.Decimal);
                connex.cmd.Parameters["@cliente"].Value = clienteId;

                dr = connex.cmd.ExecuteReader();
                listTicket = new List<Ticket>();
                while (dr.Read())
                {
                    Ticket tk = new Ticket()
                    {
                        NUM_TICKET = Convert.ToDecimal(dr["numticket"].ToString()),
                        LOCAL_ID = Convert.ToInt32(dr["local"].ToString()),
                        FEC_REGISTRO = DateTime.Parse(dr["fecregistro"].ToString()),
                        USUARIO = Convert.ToDecimal(dr["usuario"].ToString()),
                        TIPO_DOC = dr["tipodoc"].ToString(),
                        ESTADO = dr["estado"].ToString(),
                        TOTAL = Convert.ToDecimal(dr["total"].ToString())
                    };
                    listTicket.Add(tk);
                }

                dr.Close();
                connex.closeConnection();

                return listTicket;

            }
            catch (Exception)
            {

                throw;
            }

        }



        public List<TicketItem> getDetalleFactura(String ticket)
        {
            List<TicketItem> listTicketItem = null;
            try
            {
                connex = new POSConnection();
                connex.openConnection();
                String query = "";

                query = "select it.local, it.numTicket, it.fecRegistro, it.cantidad,it.valUnitario,it.ean,it.descripcion,it.observacion from ticketitems it, tickets tk ";
                query = query + "where it.numTicket = @numticket and tk.numticket=it.numticket and it.local=tk.local and tk.estado='INGRESADO' ";
                connex.cmd = new SqlCommand(query, connex.cnn);
                connex.cmd.Parameters.Add("@numticket", SqlDbType.Decimal);
                connex.cmd.Parameters["@numticket"].Value = ticket;


                dr = connex.cmd.ExecuteReader();
                listTicketItem = new List<TicketItem>();
                while (dr.Read())
                {
                    TicketItem tk = new TicketItem()
                    {
                        NUM_TICKET = Convert.ToDecimal(dr["numticket"].ToString()),
                        LOCAL_ID = Convert.ToInt32(dr["local"].ToString()),
                        FEC_REGISTRO = DateTime.Parse(dr["fecregistro"].ToString()),
                        CANTIDAD = Convert.ToInt16(dr["cantidad"].ToString()),
                        VAL_UNITARIO = Convert.ToDecimal(dr["valUnitario"].ToString()),
                        EAN = dr["ean"].ToString(),
                        DESCRIPCION = dr["descripcion"].ToString(),
                        OBSERVACION = dr["observacion"].ToString()
                    };
                    listTicketItem.Add(tk);
                }

                dr.Close();
                connex.closeConnection();

                return listTicketItem;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public Boolean descargueTicket(String numfactura, String estado)
        {
            try
            {
                connex = new POSConnection();
                connex.openConnection();
                string query = @"UPDATE Tickets set estado = @estado, fecEntrega = getdate() where numTicket = @numFactura";
                connex.cmd = new SqlCommand(query, connex.cnn);

                connex.cmd.Parameters.AddWithValue("@estado", estado);
                connex.cmd.Parameters.AddWithValue("@numFactura", numfactura);

                int response = connex.cmd.ExecuteNonQuery();

                connex.closeConnection();
                return response >= 0;
            }
            catch (SqlException e)
            {
                throw e;
            }


        }


        public Boolean devolucionTicket(String numfactura, String estado, string nota)
        {
            try
            {
                connex = new POSConnection();
                connex.openConnection();
                string query = @"UPDATE Tickets set estado = @estado, fecDevolucion = getdate(), notaPedido = @nota where numTicket = @numFactura";
                connex.cmd = new SqlCommand(query, connex.cnn);

                connex.cmd.Parameters.AddWithValue("@estado", estado);
                connex.cmd.Parameters.AddWithValue("@numFactura", numfactura);
                connex.cmd.Parameters.AddWithValue("@nota", nota);


                int response = connex.cmd.ExecuteNonQuery();

                connex.closeConnection();
                return response >= 0;
            }
            catch (SqlException e)
            {
                throw e;
                
            }


        }



    }
}
