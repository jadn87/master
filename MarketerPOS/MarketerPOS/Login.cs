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
    public partial class Login : Form
    {
        public string usuario, password;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'lAUNDRY_COLDataSet.usuarios' Puede moverla o quitarla según sea necesario.
            this.usuariosTableAdapter.Fill(this.marketerPOSDataSet.usuarios);

        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {

            usuario = textUsuario.Text;
            password = textPassw.Text;

            if (usuario.Equals(""))
            {
                MessageBox.Show("Usuario Requerido");
                return;
            }
            if (password.Equals(""))
            {
                MessageBox.Show("Password Requerido");
                return;
            }
            try
            {
                Convert.ToInt16(usuario);
            }
            catch { 
                MessageBox.Show("El usuario debe ser numérico.");
                return;
            }
            

            int row = bindingSource1.Find("id", usuario);

            if (row >= 0)
            {
                bindingSource1.Position = row;
                if (password.Equals( ((DataRowView)bindingSource1.Current).Row["password"]) )
                {                    
                    InputClothing ic = new InputClothing();
                    this.Hide();
                    ic.ShowDialog();
                    this.Show();
                    limpiarVarLogin();
                }
                else {
                    MessageBox.Show("Password Incorrecto");
                    textPassw.Text = "";
                    textPassw.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
                limpiarVarLogin();
                textUsuario.Focus();
            }
        }


        public void limpiarVarLogin()
        {
            textUsuario.Text = "";
            textPassw.Text = "";
        }

    }
}
