using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 


namespace Semana2_Tarea1.Config
{
    class ConexionBDD
    {
        private SqlConnection connection = new SqlConnection("Server=DESKTOP-KA0EPGU\\SQLEXPRESS; Database=Cuarto; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (connection.State == ConnectionState.Closed) 
                connection.Open();
                return connection;
        }
        public SqlConnection CerrarConexion()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
                return connection;
        }
    }
}
