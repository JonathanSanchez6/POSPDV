namespace POSPDV.Forms
{
    partial class FormProductos
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
            pictureBox3 = new PictureBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox7 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            label9 = new Label();
            textBox3 = new TextBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnCancelar);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(btnNuevo);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 611);
            panel2.Name = "panel2";
            panel2.Size = new Size(1350, 50);
            panel2.TabIndex = 50;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Left;
            btnCancelar.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.Image = Properties.Resources.icons8_cancel_30;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(706, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 40);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left;
            btnGuardar.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.Image = Properties.Resources.icons8_save_30;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(612, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.MiddleRight;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Anchor = AnchorStyles.Left;
            btnNuevo.Font = new Font("Arial", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevo.Image = Properties.Resources.icons8_new_file_30;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(519, 5);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(90, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextAlign = ContentAlignment.MiddleRight;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Right;
            pictureBox3.Image = Properties.Resources.icons8_customer_1001;
            pictureBox3.Location = new Point(1084, 219);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 96);
            pictureBox3.TabIndex = 89;
            pictureBox3.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Left;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20" });
            comboBox1.Location = new Point(365, 327);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 87;
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Left;
            textBox5.Location = new Point(365, 240);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 85;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Left;
            pictureBox2.Image = Properties.Resources.icons8_search_502;
            pictureBox2.Location = new Point(475, 212);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(51, 51);
            pictureBox2.TabIndex = 84;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(256, 364);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 83;
            label6.Text = "Venta";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Location = new Point(256, 393);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 82;
            label7.Text = "Costo";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Location = new Point(256, 335);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 80;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Location = new Point(256, 306);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 79;
            label4.Text = "Descripcion";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Location = new Point(256, 277);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 78;
            label2.Text = "Nombre";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(256, 219);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 77;
            label1.Text = "ID";
            // 
            // textBox7
            // 
            textBox7.Anchor = AnchorStyles.Left;
            textBox7.Location = new Point(365, 385);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(161, 23);
            textBox7.TabIndex = 75;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Left;
            textBox4.Location = new Point(365, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 23);
            textBox4.TabIndex = 74;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Left;
            textBox2.Location = new Point(365, 269);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 23);
            textBox2.TabIndex = 73;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Left;
            textBox1.Location = new Point(365, 211);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 72;
            textBox1.Text = "Nuevo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logoMuebles1;
            pictureBox1.Location = new Point(581, 240);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 123);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 90;
            pictureBox1.TabStop = false;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.Location = new Point(256, 248);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 91;
            label9.Text = "ID Proveedor";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Left;
            textBox3.Location = new Point(365, 356);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 23);
            textBox3.TabIndex = 93;
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 661);
            Controls.Add(textBox3);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            Controls.Add(panel2);
            Controls.Add(textBox7);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Name = "FormProductos";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Productos";
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button btnCancelar;
        private Button btnGuardar;
        private Button btnNuevo;
        private PictureBox pictureBox3;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private TextBox textBox7;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private Label label9;
        private TextBox textBox3;
    }
}