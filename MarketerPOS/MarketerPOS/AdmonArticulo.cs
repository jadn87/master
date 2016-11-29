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
    public partial class AdmonArticulo : Form
    {

        ContextDB ut;

        public AdmonArticulo()
        {
            InitializeComponent();
        }

        
        private void AdmonArticulo_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lAUNDRY_COLDataSet.articulos' Puede moverla o quitarla según sea necesario.
            //this.articulosTableAdapter.Fill(this.lAUNDRY_COLDataSet.articulos);

            ut = new ContextDB();
            List<Articulo> articles = ut.getArticles();

            foreach (var item in articles)	
			{
                listAdmonArticulos_dgv.Rows.Add(item.EAN, item.DESCRIPCION, item.VALOR);
			 
			}

            
        }

        
    }
}
