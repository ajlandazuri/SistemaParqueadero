using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wasg, int wparm, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frm = new frmInicio();
            frm.Show();
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = true;

        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            txtContraseña.UseSystemPasswordChar = false;

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Length == 0 || txtContraseña.Text.Length == 0)
            {
                MessageBox.Show("Ingrese todos los campos");
            }
            else
            {
                if (txtUsuario.Text == "Admin" && txtContraseña.Text == "Admin")
                {
                    this.Hide();
                    frmAdministrador frm = new frmAdministrador();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos");
                }
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
