using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parqueadero
{
    class Modelo
    {

        public int registro(Cliente cliente)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO clientes (dueño, cedula, celular, placa, targeta) VALUES(@dueño, @cedula, @celular, @placa, @targeta)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@dueño", cliente.Dueño);
            comando.Parameters.AddWithValue("@cedula", cliente.Cedula);
            comando.Parameters.AddWithValue("@celular", cliente.Celular);
            comando.Parameters.AddWithValue("@placa", cliente.Placa);
            comando.Parameters.AddWithValue("@targeta", cliente.Targeta);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool existeUsuario(string cliente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id FROM clientes WHERE cedula LIKE @cedula";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@cedula", cliente);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool existePlaca(string cliente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id FROM clientes WHERE placa LIKE @placa";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@placa", cliente);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool existePlacaRegistro(string cliente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id FROM horaentrada WHERE placa LIKE @placa";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@placa", cliente);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool actualizar(Cliente datos)
        {
            bool bandera = false;

            string SQL = "UPDATE clientes SET dueño='" + datos.Dueño + "', cedula='" + datos.Cedula + "', celular='" + datos.Celular + "', placa='" + datos.Placa + "', targeta='" + datos.Targeta + "' WHERE dueño='" + datos.Dueño + "'";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(SQL, conexion);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }

            return bandera;
        }


        public bool restar(Cliente datos)
        {
            bool bandera = false;

            string SQL = "UPDATE clientes SET targeta='" + datos.Targeta + "' WHERE placa='" + datos.Placa + "'";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlCommand comando = new MySqlCommand(SQL, conexion);
                comando.ExecuteNonQuery();
                bandera = true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
                bandera = false;
            }

            return bandera;
        }


        public Cliente porUsuario(string cliente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT dueño, cedula, celular, placa, targeta FROM clientes WHERE cedula LIKE @cedula";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@cedula", cliente);

            reader = comando.ExecuteReader();

            Cliente usr = null;

            while (reader.Read())
            {
                usr = new Cliente();
                usr.Dueño = reader["dueño"].ToString();
                usr.Cedula = reader["cedula"].ToString();
                usr.Celular = reader["celular"].ToString();
                usr.Placa = reader["placa"].ToString();
                usr.Targeta = int.Parse(reader["targeta"].ToString());

            }
            return usr;
        }

        public Cliente tarjeta(string cliente)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT dueño, cedula, celular, placa, targeta FROM clientes WHERE placa LIKE @placa";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@placa", cliente);

            reader = comando.ExecuteReader();

            Cliente usr = null;

            while (reader.Read())
            {
                usr = new Cliente();
                usr.Dueño = reader["dueño"].ToString();
                usr.Cedula = reader["cedula"].ToString();
                usr.Celular = reader["celular"].ToString();
                usr.Placa = reader["placa"].ToString();
                usr.Targeta = int.Parse(reader["targeta"].ToString());

            }
            return usr;
        }

    }
}
