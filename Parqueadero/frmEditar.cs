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
    public partial class frmEditar : Form
    {
        public frmEditar()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(100, Color.Black);

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
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmClientes frm = new frmClientes();
            frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
           

            Modelo a = new Modelo();
            if (btnO5.Checked == true)
            {

                try
                {
                   
                    cliente = a.tarjeta(txtPlaca.Text);
                    cliente.Cedula = txtCedula.Text;
                    cliente.Celular = txtCelular.Text;
                    cliente.Dueño = txtDueño.Text;
                    cliente.Placa = txtPlaca.Text;
                    cliente.Targeta = cliente.Targeta + 5;

                    Control control = new Control();
                    string respuesta = control.ctrlEditar(cliente);

                    if (respuesta.Length > 0)
                    {
                        MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Se realizaron los cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                if (btnO10.Checked == true)
                {
                    try
                    {
                        cliente = a.tarjeta(txtPlaca.Text);
                        cliente.Cedula = txtCedula.Text;
                        cliente.Celular = txtCelular.Text;
                        cliente.Dueño = txtDueño.Text;
                        cliente.Placa = txtPlaca.Text;
                        cliente.Targeta = cliente.Targeta + 15;

                        Control control = new Control();
                        string respuesta = control.ctrlEditar(cliente);

                        if (respuesta.Length > 0)
                        {
                            MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Se realizaron los cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    if (btnO15.Checked == true)
                    {
                        try
                        {

                            Control control = new Control();
                            cliente = a.tarjeta(txtPlaca.Text);
                            cliente.Cedula = txtCedula.Text;
                            cliente.Celular = txtCelular.Text;
                            cliente.Dueño = txtDueño.Text;
                            cliente.Placa = txtPlaca.Text;
                            cliente.Targeta = cliente.Targeta + 60;

                            string respuesta = control.ctrlEditar(cliente);

                            if (respuesta.Length > 0)
                            {
                                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Se realizaron los cambios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmEditar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleasedCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
