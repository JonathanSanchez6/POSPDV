namespace POSPDV
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Obtener el nombre de usuario y la contraseña ingresados por el usuario
            string username = txtUsuario.Text;
            string password = txtContraseña.Text;

            // Aquí deberías implementar la lógica para validar las credenciales.
            // Por ahora, simplemente comprobaremos si el nombre de usuario es "admin" y la contraseña es "admin".

            if (username == "admin" && password == "admin")
            {
                // Si las credenciales son válidas, cerrar el formulario de inicio de sesión y mostrar el formulario principal
                this.Hide(); // Ocultar el formulario de inicio de sesión
                // Aquí deberías mostrar el formulario principal de tu aplicación.
                // Por ejemplo:
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
            }
            else
            {
                // Si las credenciales no son válidas, mostrar un mensaje de error
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtelo de nuevo.", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}