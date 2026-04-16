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
    public partial class frmEntrada : Form
    {
        public frmEntrada()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(200, Color.Black);

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleasedCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hand, int wasg, int wparm, int lparam);
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frm = new frmInicio();
            frm.Show();
        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicio frm = new frmInicio();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string horaentrada, fecharegistro, placa, cedula;
            placa = txtPlaca.Text;
            horaentrada = DateTime.Now.ToString("HH:mm:ss");
            fecharegistro = DateTime.Now.ToLongDateString();

            try
            {
                Modelo verificar = new Modelo();
                if (verificar.existePlaca(placa))
                {
                    if (verificar.existePlacaRegistro(placa))
                    {
                        MessageBox.Show("El carro se encuentra dentro del parqueadero");

                    }
                    else
                    {

                        MySqlConnection conexionHora = Conexion.getConexion();
                        conexionHora.Open();
                        MySqlCommand comando = new MySqlCommand();
                        comando.Connection = conexionHora;
                        comando.CommandText = ("insert into horaentrada(placa,horaentrada,fecharegistro)values('" + placa + "','" + horaentrada + "','" + fecharegistro + "');");
                        comando.ExecuteNonQuery();
                        conexionHora.Close();
                        MessageBox.Show("Hora de entrada Registrada");
                    }
                }
                else
                {
                    MessageBox.Show("Placa no registrada ");
                }



            }
            catch (Exception r)
            {
                MessageBox.Show("Algo salio mal vuelva a intentar");

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string horaentrada, fecharegistro, placa, cedula;
            placa = txtPlaca.Text;
            horaentrada = DateTime.Now.ToString("HH:mm:ss");
            fecharegistro = DateTime.Now.ToLongDateString();

            try
            {
                Modelo verificar = new Modelo();
                if (verificar.existePlaca(placa))
                {
                    if (verificar.existePlacaRegistro(placa))
                    {
                        MessageBox.Show("El carro se encuentra dentro del parqueadero");

                    }
                    else
                    {
                        Modelo a = new Modelo();
                        Cliente nuevo = a.tarjeta(placa);
                        int total = nuevo.Targeta;
                        if (total>0)
                        {

                            MySqlConnection conexionHora = Conexion.getConexion();
                            conexionHora.Open();
                            MySqlCommand comando = new MySqlCommand();
                            comando.Connection = conexionHora;
                            Modelo m = new Modelo();
                            comando.CommandText = ("insert into horaentrada(placa,horaentrada,fecharegistro)values('" + placa + "','" + horaentrada + "','" + fecharegistro + "');");
                            comando.ExecuteNonQuery();
                            conexionHora.Close();


                            nuevo.Targeta = nuevo.Targeta - 1;
                            a.restar(nuevo);
                            MessageBox.Show("Hora de entrada Registrada");
                        }
                        else {
                            MessageBox.Show("Tarjeta agotada tiene un total de : " + total+" entradas disponibles");
                        }       
                        
                    }
                }
                else
                {
                    MessageBox.Show("Placa no registrada ");
                }



            }
            catch (Exception r)
            {
                MessageBox.Show("Algo salio mal vuelva a intentar");

            }
        }
    }
}
