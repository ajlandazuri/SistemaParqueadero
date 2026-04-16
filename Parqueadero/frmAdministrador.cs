using MySql.Data.MySqlClient;
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
    public partial class frmAdministrador : Form
    {
        public frmAdministrador()
        {
            InitializeComponent();

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
         


        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wasg, int wparm, int lparam);
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.getConexion();
            try
            {
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand();

                comando.Connection = conexionBD;
                comando.CommandText = ("SELECT * FROM horaentrada;");
                MySqlDataAdapter adaptar = new MySqlDataAdapter();
                adaptar.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptar.Fill(tabla);
                dataGridView1.DataSource = tabla;
            }
            catch
            {
                throw;
            }
            conexionBD.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frm = new frmInicio();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmAdministrador_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
