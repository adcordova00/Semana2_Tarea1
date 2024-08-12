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

        public List<PaisesModel> Paises() {
            List<PaisesModel> listaPaises = new List<PaisesModel>();
            listaPaises = paisesModel.Paises();
            return listaPaises;
        }
        public string insertar(PaisesModel pais)
        {
            string guardar_pais = paisesModel.insertar(pais);
            return guardar_pais;
        }
    }
}
