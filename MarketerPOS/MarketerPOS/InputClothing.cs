using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MarketerPOS
{
    public partial class InputClothing : Form
    {
        public InputClothing()
        {
            InitializeComponent();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Principal frmppal = new Principal();
            frmppal.MdiParent = this;
            frmppal.Show();
        }

        private void devolucionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdmonArticulo frmArticulo = new AdmonArticulo();
            frmArticulo.MdiParent = this;
            frmArticulo.Show();
        }
    }
}
