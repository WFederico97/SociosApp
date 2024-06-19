using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SociosApp.Classes
{
    internal class DataAccess
    {
        private string connString = " Data Source=FEDE_NOTE;Initial Catalog = socios_app; Integrated Security = True";
        private SqlConnection conn;
        private SqlCommand cmd;
        public DataAccess()
        {
            conn = new SqlConnection(connString);

        }
        private void Connect()  //Metodo generico para abrir la conexion
        {
            conn.Open();
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
        }
        public void Disconnect()    //Metodo generico para cerrar la conexion
        {
            conn.Close();
        }

        public DataTable ConsultarCombos(string table)
        {
            DataTable dataTable = new DataTable(); //Creamos un objeto dataTable de tipo DataTable
            Connect();
            cmd.CommandText = "SELECT * FROM " + table; //Consulta sql 
            dataTable.Load(cmd.ExecuteReader()); //Cargo el dataTable con los datos de la consulta
            Disconnect();
            return dataTable;
        }
        public DataTable ConsultarBd(string sqlQuery) 
        {
            DataTable dataTable = new DataTable(); //Creamos un objeto dataTable de tipo DataTable
            Connect();
            cmd.CommandText = sqlQuery; //Consulta sql 
            dataTable.Load(cmd.ExecuteReader()); //Cargo el dataTable con los datos de la consulta
            Disconnect();
            return dataTable;
        }
        public int ActualizarBd(string consultaSql)
        {
            Connect();
            cmd.CommandText = consultaSql;
            int affectedRows = cmd.ExecuteNonQuery();
            Disconnect();
            return affectedRows;
        }
        public int ActualizarBd(string consultaSql, List<Parameters> parameters)
        {
            Connect();
            cmd.CommandText = consultaSql;
            foreach (Parameters parameter in parameters)
            {
                cmd.Parameters.AddWithValue(parameter.nombre, parameter.valor);
            }
            int affectedRows = cmd.ExecuteNonQuery();
            Disconnect();
            return affectedRows;
        }



    }
}
