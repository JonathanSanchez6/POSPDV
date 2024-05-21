using POSPDV.Forms;

namespace POSPDV
{
    public partial class MainMenu : Form
    {

        //Fields
        private Button? currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        //Constructor
        public MainMenu()
        {
            InitializeComponent();
            random = new Random();

        }
        //Metodos
        private Color SelectTemaColorColor()
        {
            int index = random.Next(TemaColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(TemaColor.ColorList.Count);
            }
            tempIndex = index;
            string color = TemaColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectTemaColorColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    panelMenu.BackColor = color;
                    panelLog.BackColor = TemaColor.ChangeColorBrightness(color, -0.3);
                    panelTit.BackColor = TemaColor.ChangeColorBrightness(color, -0.3);
                    TemaColor.PrimaryColor = color;
                    TemaColor.SecondaryColor = TemaColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childform, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.None;
            this.panelDesktop.Controls.Add(childform);
            this.panelDesktop.Tag = childform;
            childform.BringToFront();
            childform.Show();
            lblTit.Text = childform.Text.Replace("Form", "");
        }
        private void CloseActiveChildForm(Form childform, object Sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
        }

        private void btnCerrarSs_Click(object sender, EventArgs e)
        {
            LogicaFormulario.CerrarSesion(this);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnRepVen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnRepCom_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnConUsua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnConPermi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormProductos(), sender);
        }

        private void btnInicio_Click()
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTit.Text = "HOME";
            panelTit.BackColor = Color.FromArgb(0, 150, 136);
            panelLog.BackColor = Color.DarkGoldenrod;
            panelTit.BackColor = Color.DarkGoldenrod;
            currentButton = null;
            btnInicio.Visible = false;
        }

    }
}