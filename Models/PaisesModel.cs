using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Semana2_Tarea1.Config;
using System.Collections;

namespace Semana2_Tarea1.Models
{
    class PaisesModel
    {
        public int IdPais { get; set; }
        public string Detalle { get; set; }

        private ConexionBDD conexionBDD = new ConexionBDD();

        //lector sqldatareader

        List<PaisesModel> listaPaises = new List<PaisesModel>();
        SqlCommand cmd = new SqlCommand();

        public List<PaisesModel> Paises() 
        {
            string cadena = "select * from paises";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, conexionBDD.AbrirConexion());
            DataTable data = new DataTable();
            adapter.Fill(data);

            foreach (DataRow fila in data.Rows) 
            {
                PaisesModel paises = new PaisesModel {
                    IdPais = Convert.ToInt32(fila["IdPais"]),
                    Detalle = fila["Detalle"].ToString()
                };
                listaPaises.Add(paises);
            }
            conexionBDD.CerrarConexion();
            return listaPaises;

        }

        public string insertar(PaisesModel pais) {
            try
            {
                cmd.Connection = conexionBDD.AbrirConexion();
                cmd.CommandText = "insert into Paises(Detalle) values('" + pais.Detalle + "')";
                cmd.ExecuteNonQuery();
                return "OK";
            }
            catch (Exception ex) {
                return ex.Message;
            }
            finally
            {
                conexionBDD.CerrarConexion();
            }
            
           
        }
    }
}
