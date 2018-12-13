using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Autolavado
{
    class TablaUsuario : Conexion
    {
        string c;
        string b;
        public string q;
        public string g;
        public string h;
        public string z;
        string consulta;

        Conexion ClaseConectar = new Conexion();
        public DataTable mostrarTablaUsuario()
        {
            consulta = "SELECT*FROM Empleado;";
            MySqlDataAdapter adp = new MySqlDataAdapter(consulta, conectar());
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;
        }
        public void InsertarEmp(Usuario u)
        {
            MySqlConnection con = conectar();

            string consulta = "INSERT INTO Empleado" +
                "(id_empleado,nombre,apellidos)" +
                "VALUES('" + u.getCod() + "','" + u.getNombreEmp() + "','"
                + u.getApellido() + "');";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro almacenado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cerrarConexion();
        }
        public void ActualizarEmp(Usuario u, int id)
        {
            MySqlConnection con = conectar();

            string consulta = "UPDATE Empleado " +
                " SET nombre ='" + u.getNombreEmp() + "'," +
                " apellidos='" + u.getApellido() + "' " +
                " WHERE id_empleado=" + id;
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro", "Registro actualizado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cerrarConexion();
        }

        public void EliminarEmp(int id)
        {
            MySqlConnection con = conectar();

            string consulta = "DELETE FROM Empleado " +
                "WHERE id_empleado=" + id;
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Eliminado", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cerrarConexion();
        }
        public string datomax()
        {
            string dato;
            MySqlConnection con = conectar();
            consulta = "SELECT MAX(id_empleado) FROM Empleado";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataAdapter ad = new MySqlDataAdapter(comando);
            //MySqlDataReader resultado;
            abrirConexion();
            //resultado = comando.ExecuteReader();
            DataTable tabla = new DataTable();
            ad.Fill(tabla);
            dato = tabla.Rows[0][0].ToString();

            cerrarConexion();
            return dato;
        }
        public DataTable mostrarInventario()
        {
            consulta = "SELECT*FROM Producto;";
            MySqlDataAdapter adp = new MySqlDataAdapter(consulta, conectar());
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;
        }
        public string datomaxp()
        {
            string s;
            MySqlConnection con = conectar();
            consulta = "SELECT MAX(idProducto) FROM Producto";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataAdapter ad = new MySqlDataAdapter(comando);
            abrirConexion();
            DataTable tabla = new DataTable();
            ad.Fill(tabla);
            s = tabla.Rows[0][0].ToString();
            cerrarConexion();
            return s;
        }
        public void InsertarPro(Usuario u)
        {
            MySqlConnection con = conectar();
            string consulta = "INSERT INTO producto" +
                "(idProducto,nombre,cantidad,precio)" +
                "VALUES('" + u.getcodi() + "','" + u.getNombreEmp() + "','"
                + u.getCantidad() + "','" + u.getPrecio() + "');";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro almacenado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cerrarConexion();
        }
        public void EliminarPro(int id)
        {
            MySqlConnection con = conectar();
            MySqlCommand consulta = new MySqlCommand("DELETE FROM PRODUCTO WHERE idProducto=" + id, con);
            MySqlDataReader ejecución;
            abrirConexion();
            ejecución = consulta.ExecuteReader();
            MessageBox.Show("Eliminado", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cerrarConexion();
        }
        public void ActualizarProductos(Usuario u,int id)
        {
            MySqlConnection con = conectar();
            string consulta = "UPDATE producto " +
                " SET nombre ='" + u.getNombreEmp() + "'," +
                " cantidad='" + u.getCantidad() + "'," +
                " precio='"+u.getPrecio()+"' WHERE idProducto=" + id;
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro actualizado correctamente","Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cerrarConexion();

        }
        public void InsertarPlac(Usuario u)
        {
            MySqlConnection con = conectar();
            string consulta = "INSERT INTO carro" +
                "(placa,tipo,nombre,apellidos,fecha_N)" +
                "VALUES('" + u.getPlaca()+ "','" + u.getTipo()+ "','"
                +u.getNombreEmp() + "','" + u.getApellido()+ "','"+ u.getfecha()+"');";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro almacenado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cerrarConexion();
        }
        public void ActualizarPlac(Usuario u, string g)
        {
            try
            {
                MySqlConnection con = conectar();
                string consulta = "UPDATE carro " +
                    " SET tipo ='" + u.getTipo() + "'," +
                    " nombre='" + u.getNombreEmp() + "'," +
                    " fecha_N='" + u.getfecha() + "' WHERE placa ='" + g + "'";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataReader resultado;
                abrirConexion();
                resultado = comando.ExecuteReader();
                MessageBox.Show("Registro actualizado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cerrarConexion();
            }catch(MySqlException r)
            {
                MessageBox.Show(r.Message);
            }
        }
        public void EliminarPlac(string g)
        {
            MySqlConnection con = conectar();
            MySqlCommand consulta = new MySqlCommand("DELETE FROM carro WHERE placa = '"+g+"'", con);
            MySqlDataReader ejecución;
            abrirConexion();
            ejecución = consulta.ExecuteReader();
            MessageBox.Show("Eliminado", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cerrarConexion();
        }
        public DataTable VerPlacas()
        {
            consulta = "SELECT*FROM carro;";
            MySqlDataAdapter adp = new MySqlDataAdapter(consulta, conectar());
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;
        }
        public DataTable MostrarAdm()
        {
            consulta = "SELECT * FROM encargado";
            MySqlDataAdapter adp = new MySqlDataAdapter(consulta, conectar());
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;
        }
        public void InsertarTicket(Usuario u)
        {
            c = "";
            if (g != "")
            {
                c=c+g;
            }
            if (h != "")
            {
                c = c+"," + h;
            }
            if (z != "")
            {
                c = c +"," + z;
            }
            if (q != "")
            {
                c = c + "," + q;
            }
            b = DateTime.Now.ToString("yyyy-MM-dd");
            try
            {
                MySqlConnection con = conectar();
                string consulta = "INSERT INTO ticket" +
                    "(placa_i,emple_no,tipo,total,fecha_t)" +
                    "VALUES('" + u.getPlaca() + "','" + u.getNombreEmp() +"','"+c+"','"+u.getPrecio()+"','"+b+"');";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataReader resultado;
                abrirConexion();
                resultado = comando.ExecuteReader();
                MessageBox.Show("Compra realizada con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cerrarConexion();
            }
            catch (MySqlException r)
            {
                MessageBox.Show(r.ToString());
            }
        }
        public DataTable MostrarTickets()
        {
            consulta = "SELECT * FROM Ticket";
            MySqlDataAdapter adp = new MySqlDataAdapter(consulta, conectar());
            DataTable tabla = new DataTable();
            adp.Fill(tabla);
            return tabla;
        }
        public void InsertarAdm(Usuario u)
        {
            MySqlConnection c = conectar();
            consulta = "INSERT INTO encargado"+"(usuario,contraseña,Nombre,Apellidos)"+
            "VALUES('" + u.getNombreEnc() + "','" + u.getContraseña() + "','" + u.getNombreEmp() + "','" + u.getApellido() + "');";
            MySqlCommand comando = new MySqlCommand(consulta, c);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro realizado con exito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cerrarConexion();
        }
        public void EliminarAdm(string d)
        {
            MySqlConnection con = conectar();
            MySqlCommand consulta = new MySqlCommand("DELETE FROM encargado WHERE usuario ='"+ d +"'", con);
            MySqlDataReader ejecución;
            abrirConexion();
            ejecución = consulta.ExecuteReader();
            MessageBox.Show("Eliminado", "Registro eliminado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            cerrarConexion();
        }
        public void ActualizaAdnm(Usuario u, string i)
        {
            MySqlConnection con = conectar();
            string consulta = "UPDATE encargado " +
                " SET contraseña ='" + u.getContraseña() + "'," +
                " Nombre = '"+u.getNombreEmp()+"',"+
                " Apellidos ='" + u.getApellido() + "' WHERE usuario ='"+i+"'";
            MySqlCommand comando = new MySqlCommand(consulta, con);
            MySqlDataReader resultado;
            abrirConexion();
            resultado = comando.ExecuteReader();
            MessageBox.Show("Registro actualizado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cerrarConexion();
        }
    }
}
