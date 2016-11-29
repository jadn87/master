using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Configuration;

namespace MarketerPOS
{
    public class POSConnection
    {
        public SqlConnection cnn;
        public SqlCommand cmd;


        public POSConnection() 
        { 
        }

        public void openConnection() {
            try 
            {
                cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["MarketerPOSConnectionString"].ConnectionString);
                cnn.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Problemas al conectar con la Base de Datos. " + ex.ToString());
            }
        }

        public void closeConnection() {

            try {
                this.cnn.Close(); 
            }
            catch (Exception ex) {
                MessageBox.Show("Ocurrio error cerrando sesion de la Base de Datos. " + ex.ToString());
            }
        }

    }
}
