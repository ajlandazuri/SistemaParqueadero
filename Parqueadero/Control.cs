using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero
{
    class Control
    {

        public string ctrlRegistro(Cliente cliente)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";


            if (string.IsNullOrEmpty(cliente.Cedula) || string.IsNullOrEmpty(cliente.Placa) ||
                string.IsNullOrEmpty(cliente.Dueño) || string.IsNullOrEmpty(cliente.Dueño) ||
                string.IsNullOrEmpty(cliente.Celular))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (modelo.existeUsuario(cliente.Cedula) && modelo.existePlaca(cliente.Placa))
                {
                    respuesta = "El vehiculo ya esta registrado";
                }
                else
                {
                    modelo.registro(cliente);
                }
            }
            return respuesta;

        }
        public string ctrlEditar(Cliente cliente)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";


            if (string.IsNullOrEmpty(cliente.Dueño) || string.IsNullOrEmpty(cliente.Cedula) ||
                string.IsNullOrEmpty(cliente.Celular) || string.IsNullOrEmpty(cliente.Placa) )
                
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (modelo.actualizar(cliente) == true)
                {
                    respuesta = "Registro Actualizado";
                }

            }
            return respuesta;

        }

    }
}
