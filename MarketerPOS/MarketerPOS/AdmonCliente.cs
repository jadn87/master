using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities;

namespace MarketerPOS
{
    public partial class AdmonCliente : Form
    {

        ContextDB ut;

        public AdmonCliente()
        {
            InitializeComponent();
        }

        private void AdmonCliente_Load(object sender, EventArgs e)
        {
            ut = new ContextDB();
            List<Cliente> clients = ut.getClientes();

            foreach (var item in clients)
            {
                listAdmonClientes_dgv.Rows.Add(item.ID, item.NOMBRE, item.APELLIDO, item.CEDULA, item.EMAIL, item.DIRECCION, item.TELEFONO);

            }
        }

        
    }
}
