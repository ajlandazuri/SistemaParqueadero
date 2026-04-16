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
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wasg, int wparm, int lparam);

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegistrar frm = new frmRegistrar();
            frm.Show();

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEntrada frm = new frmEntrada();
            frm.Show();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSalida frm = new frmSalida(); 
            frm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void frmInicio_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
