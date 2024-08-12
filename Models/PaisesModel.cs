using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Semana2_Tarea1.Config;

namespace Semana2_Tarea1.Models
{
    class PaisesModel
    {
        private ConexionBDD conexionBDD = new ConexionBDD();

        //lector sqldatareader

        SqlDataReader lector;
        DataTable listaPaises = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Paises() 
        {
            cmd.Connection = conexionBDD.AbrirConexion();
            cmd.CommandText = "select * from paises";
            lector = cmd.ExecuteReader();
            listaPaises.Load(lector);
            conexionBDD.CerrarConexion();
            return listaPaises;
        }
    }
}
