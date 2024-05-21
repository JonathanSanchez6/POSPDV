using POSPDV;

public static class LogicaFormulario
{
    public static void BorrarCampos(Control control)
    {
        foreach (Control c in control.Controls)
        {
            if (c is TextBox)
            {
                ((TextBox)c).Text = "";
            }
            else if (c is ComboBox)
            {
                ((ComboBox)c).SelectedIndex = -1;
            }
            else if (c is CheckBox)
            {
                ((CheckBox)c).Checked = false;
            }
            else if (c is RadioButton)
            {
                ((RadioButton)c).Checked = false;
            }
            else if (c is DateTimePicker)
            {
                ((DateTimePicker)c).Value = DateTime.Now;
            }
            else if (c is RichTextBox)
            {
                ((RichTextBox)c).Text = "";
            }
            else if (c is GroupBox)
            {
                BorrarCampos(c); // Llamada recursiva para limpiar los controles dentro del GroupBox
            }
        }
    }

        // Método fuera de la clase LogicaFormulario
        public static void LimpiarCampos()
    {
    
    
    }
    /// <param name="formulario"></param>
    public static void GuardarRegistro(Form formulario)
    {
        MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public static void ActualizarFormulario(Form formulario)
    {
        formulario.Refresh(); // Actualiza el formulario
    }

    public static void CerrarSesion(Form formulario)
    {
        // Cierra el formulario actual
        formulario.Close();

        // Abre el formulario de inicio de sesión
        FormLogin loginForm = new FormLogin();
        loginForm.Show();
    }
}