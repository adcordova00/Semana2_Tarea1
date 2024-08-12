using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Semana2_Tarea1.Models; 

namespace Semana2_Tarea1.Controllers
{
    class PaisesController
    {
        private PaisesModel paisesModel = new PaisesModel();

        public DataTable Paises() { 
            DataTable listaPaises = new DataTable();
            listaPaises = paisesModel.Paises();
            return listaPaises;
        } 
    }
}
