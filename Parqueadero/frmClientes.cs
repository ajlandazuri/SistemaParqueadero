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
    public partial class frmClientes : Form
    {
        frmEditar editar = new frmEditar();

        public frmClientes()
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
                comando.CommandText = ("SELECT * FROM clientes;");
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
            editar.txtDueño.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            editar.txtPlaca.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            editar.txtCedula.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            editar.txtCelular.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        

            editar.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAdministrador frm = new frmAdministrador();
            frm.Show();
        }

        private void frmClientes_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String placa= dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string sql = "DELETE FROM clientes WHERE placa ='" + placa + "'";
            MySqlConnection conexionBD = Conexion.getConexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente Eliminado");
                conexionBD.Close();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al eliminar : "+ex.Message);
            }
        }

        private void clienteBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
