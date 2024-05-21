namespace POSPDV
{
    partial class FormLogin

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            btnEntrar = new Button();
            panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnEntrar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(516, 345);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(192, 213);
            label3.Name = "label3";
            label3.Size = new Size(103, 16);
            label3.TabIndex = 5;
            label3.Text = "CONTRASEÑA :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(192, 166);
            label2.Name = "label2";
            label2.Size = new Size(73, 16);
            label2.TabIndex = 4;
            label2.Text = "USUARIO :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 46);
            label1.Name = "label1";
            label1.Size = new Size(281, 38);
            label1.TabIndex = 3;
            label1.Text = "INICIAR SECCION";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(301, 206);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(166, 23);
            txtContraseña.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(301, 159);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(166, 23);
            txtUsuario.TabIndex = 1;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrar.Location = new Point(321, 272);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(131, 70);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(516, 345);
            this.Controls.Add(panel1);
            this.Name = "FormLogin";
            this.SizeGripStyle = SizeGripStyle.Hide;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "FormLogin";
            this.WindowState = FormWindowState.Normal;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
        private Button btnEntrar;
    }
}