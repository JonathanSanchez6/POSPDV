using System.Data;

namespace POSPDV.Forms
{
    public partial class FrmBuscar : Form
    {
        private string Query = "";
        private string consulta = "";
        private string campo = "";

        public void setQuery(string valor)
        {
            Query = valor.Trim();
        }
        private string getConsuslta()
        {
            if (Query.Length == 0)
                consulta = "SELECT 'SIN DATOS A BUSCAR' AS DESCRIPCTION";
            else if (textBox1.Text.Length == 0)
            {
                consulta = Query + "order by nombre asc";
            }
            else
            {
                consulta = Query + " where " + campo + "like %" + textBox1.Text + "%";
            }
            return Query;
        }
        public void setCampo(string valor)
        {
           // Campo = valor.Trim();
        }
        public FrmBuscar()
        {
            InitializeComponent();

        }

        private void mostrarResultados()
        {
            try
            {
                //Levantar conexion a BD

                //Enviar consulta
                string consultaBuscar = getConsuslta();
                //Llenar DataGridView
                //crear un metodo en capaDatos que reciba parametros SQL Comand
                DataSet dataSet = new DataSet();
                dGV_datos.DataSource = null;


            }
            catch (Exception ex)
            {
                Console.WriteLine("[frmBuscar]" + ex.Message);
                //Escribe el log
            }
        }

        private void FrmBuscar_Load(object sender, EventArgs e)
        {
            //Obtener query de la tabla
            //query= "select id, nombre, ubicación, precio from productos order by nombre asc"

            //mostrar resultados en dGV_datos

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {


            String cadena = textBox1.Text;
            if (cadena.Length == 0)
                cadena = Query;
            else
            {

            }
            Query = "";
            mostrarResultados();
        }

    }
}
