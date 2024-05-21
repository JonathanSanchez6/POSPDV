using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSPDV.Forms
{
    public partial class FormProductos : Form
    {
        public FormProductos()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LogicaFormulario.GuardarRegistro(this);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LogicaFormulario.BorrarCampos(this);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LogicaFormulario.BorrarCampos(this);
        }
    }
}
