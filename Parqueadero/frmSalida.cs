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
    public partial class frmSalida : Form
    {
        public frmSalida()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(200, Color.Black);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wasg, int wparm, int lparam);
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmInicio frm = new frmInicio();
            frm.Show();
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string horasalida, fecharegistro, placa, cedula;
            placa = txtPlaca.Text;
            horasalida = DateTime.Now.ToString("HH:mm:ss");
            fecharegistro = DateTime.Now.ToLongDateString();


            Modelo verificar = new Modelo();
            if (verificar.existePlaca(placa))
            {
                if (!verificar.existePlacaRegistro(placa))
                {
                    MessageBox.Show("El carro no se encuentra dentro del parqueadero");

                }
                else
                {

                    string sql = "DELETE FROM horaentrada WHERE placa='" + placa + "'";
                    MySqlConnection conexionHora1 = Conexion.getConexion();
                    conexionHora1.Open();

                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql, conexionHora1);
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Vehiculo retirado");

                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Vehiculo no encontrado");
                    }
                    finally
                    {
                        conexionHora1.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vehiculo no registrado");

            }
        }
    }
}
