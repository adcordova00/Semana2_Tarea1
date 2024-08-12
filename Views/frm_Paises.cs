using Semana2_Tarea1.Controllers;
using Semana2_Tarea1.Models;

namespace Semana2_Tarea1
{
    public partial class frm_paises : Form
    {
        PaisesController paisesController = new PaisesController();
        string IdPais = null;
        public frm_paises()
        {
            InitializeComponent();
        }

        private void frm_paises_Load(object sender, EventArgs e)
        {
            CargaLista();
        }

        public void CargaLista()
        {
            lst_paises.DataSource = paisesController.Paises();
            lst_paises.DisplayMember = "Detalle";
            lst_paises.ValueMember = "IdPais";
        }

        private void seleccionar_pais()
        {
            IdPais = lst_paises.SelectedValue.ToString();
            txt_nombre_pais.Text = lst_paises.GetItemText(lst_paises.SelectedItem);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            if (lst_paises.SelectedItems != null)
            {
                seleccionar_pais();
            }
            else
            {
                MessageBox.Show("Seleccionar un pais de la lista");
            }
        }

        private void lst_paises_DoubleClick(object sender, EventArgs e)
        {
            seleccionar_pais();
        }

        private void btn_grabar_Click(object sender, EventArgs e)
        {
            PaisesModel pais = new PaisesModel()
            {
                Detalle = txt_nombre_pais.Text
            };
            string respuesta = paisesController.insertar(pais);
            Console.WriteLine(respuesta);
            if (respuesta == "OK") {
                MessageBox.Show("Se guardo con exito");
                CargaLista();
            }
            else
            {
                MessageBox.Show("Error al guardar");
            }
            
        }
    }
}
