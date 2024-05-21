namespace POSPDV.Forms
{
    partial class FormCliente
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
            panel2 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnNuevo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 385);
            panel2.Name = "panel2";
            panel2.Size = new Size(1052, 50);
            panel2.TabIndex = 51;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Left;
            btnCancelar.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.icons8_cancel_30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(670, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 40);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left;
            btnGuardar.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Image = Properties.Resources.icons8_save_30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(576, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Left;
            btnNuevo.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Image = Properties.Resources.icons8_new_file_30;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(483, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(156, 43);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 52;
            label1.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(102, 23);
            textBox1.TabIndex = 53;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoMuebles5;
            pictureBox1.Location = new Point(803, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 54;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(219, 64);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(102, 23);
            textBox2.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 55;
            label2.Text = "Nombre";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(219, 151);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(102, 23);
            textBox3.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 159);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 59;
            label3.Text = "Dirección";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(219, 122);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(102, 23);
            textBox4.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 130);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 57;
            label4.Text = "Telefono";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(219, 180);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(102, 23);
            textBox5.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 188);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 62;
            label5.Text = "Correo";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(219, 209);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(102, 23);
            textBox6.TabIndex = 65;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 217);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 64;
            label6.Text = "RFC";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(219, 93);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(102, 23);
            textBox8.TabIndex = 69;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(156, 101);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 68;
            label8.Text = "Apellido";
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 435);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Name = "FormCliente";
            Text = "Cliente";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox8;
        private Label label8;
    }
}