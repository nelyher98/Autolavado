using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autolavado
{
    class Conexion
    {
        MySqlConnection con;
        string cadenaconex;
        public MySqlConnection conectar()
        {
            string servidor = "localhost;";
            string bd = "Autolavado;";
            string user = "root;";
            string pasw = ";";
            cadenaconex = "server=" + servidor + " Database=" + bd + " uid=" + user + " pwd=" + pasw;
            con = new MySqlConnection(cadenaconex);
            return con;
        }
        public void abrirConexion()
        {
            con.Open();
        }
        public void cerrarConexion()
        {
            con.Close();
        }
        public MySqlConnection getconexion() {
            return con;
        }
     }
}
