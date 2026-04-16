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
    public partial class frmRegistrar : Form
    {
        public frmRegistrar()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.Black);

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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPlaca_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDueño_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            Modelo a = new Modelo();
            cliente.Cedula = txtCedula.Text;
            cliente.Dueño = txtDueño.Text;
            cliente.Celular = txtCelular.Text;
            cliente.Placa = txtPlaca.Text;
           

            if (btn5.Checked == true)
            {


                cliente.Targeta = 5;


                try
                {

                    Modelo verificar = new Modelo();
                    if (verificar.existePlaca(cliente.Placa))
                    {
                        MessageBox.Show("Vehiculo ya registrado");
                    }
                    else
                    {
                        Control control = new Control();
                        string respuesta = control.ctrlRegistro(cliente);
                        string respuesta2 = control.ctrlRegistro(cliente);

                        if (respuesta.Length > 0)
                        {
                            MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Vehiculo registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCedula.Text = "";
                            txtCelular.Text = "";
                            txtDueño.Text = "";
                            txtPlaca.Text = "";
                            btn5.Checked = false;
                            btn10.Checked = false;
                            btn15.Checked = false;

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (btn10.Checked == true)
                {
                    cliente.Targeta = 15;
                    try
                    {
                        Modelo verificar = new Modelo();
                        if (verificar.existePlaca(cliente.Placa))
                        {
                            MessageBox.Show("Vehiculo ya registrado");
                        }
                        else
                        {
                            Control control = new Control();
                            string respuesta = control.ctrlRegistro(cliente);
                            string respuesta2 = control.ctrlRegistro(cliente);

                            if (respuesta.Length > 0)
                            {
                                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Vehiculo registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCedula.Text = "";
                                txtCelular.Text = "";
                                txtDueño.Text = "";
                                txtPlaca.Text = "";
                                btn5.Checked = false;
                                btn10.Checked = false;
                                btn15.Checked = false;

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    if (btn15.Checked == true)
                    {
                        cliente.Targeta = 60;
                        try
                        {
                            Modelo verificar = new Modelo();
                            if (verificar.existePlaca(cliente.Placa))
                            {
                                MessageBox.Show("Vehiculo ya registrado");
                            }
                            else { 
                                Control control = new Control();
                            string respuesta = control.ctrlRegistro(cliente);
                            string respuesta2 = control.ctrlRegistro(cliente);

                            if (respuesta.Length > 0)
                            {
                                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Vehiculo registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCedula.Text = "";
                                txtCelular.Text = "";
                                txtDueño.Text = "";
                                txtPlaca.Text = "";
                                btn5.Checked = false;
                                btn10.Checked = false;
                                btn15.Checked = false;

                            }
                        }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione una targeta");
                    }
                }
            }




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
