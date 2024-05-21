namespace POSPDV.Forms
{
    partial class FormProveedores
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label7 = new Label();
            textBox8 = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            btnCancelar = new Button();
            btnGuardar = new Button();
            btnNuevo = new Button();
            pictureBox1 = new PictureBox();
            textBox5 = new TextBox();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(201, 87);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(322, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(322, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(201, 116);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre empresa";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(322, 196);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 175);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(322, 167);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 233);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 4;
            label4.Text = "Correo electronico";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(201, 262);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 10;
            label7.Text = "Coomentarios";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(322, 225);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(201, 204);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 8;
            label8.Text = "Dirección";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnNuevo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 50);
            panel2.TabIndex = 51;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Left;
            btnCancelar.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.icons8_cancel_30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(509, 5);
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
            btnGuardar.Location = new Point(415, 5);
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
            btnNuevo.Location = new Point(322, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoMuebles6;
            pictureBox1.Location = new Point(530, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(322, 138);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 54;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(201, 146);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 53;
            label5.Text = "Nombre del contacto";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(322, 259);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(166, 66);
            richTextBox1.TabIndex = 55;
            richTextBox1.Text = "";
            // 
            // FormProveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormProveedores";
            Text = "Proveedores";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private Panel panel2;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private PictureBox pictureBox1;
        private TextBox textBox5;
        private Label label5;
        private RichTextBox richTextBox1;
    }
}