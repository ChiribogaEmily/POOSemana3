namespace semana3tarea1.forms
{
    partial class Descuentos
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
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 10;
            label2.Text = "Tienda (store_id)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(185, 15);
            label1.TabIndex = 8;
            label1.Text = "Tipo de descuento (discounttype)";
            // 
            // button2
            // 
            button2.Location = new Point(143, 480);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(143, 451);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 106);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(334, 23);
            comboBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 23);
            textBox2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 148);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 12;
            label3.Text = "Tipo de descuento (discounttype)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 214);
            label4.Name = "label4";
            label4.Size = new Size(146, 15);
            label4.TabIndex = 14;
            label4.Text = "Cantidad minima (lowqty)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 278);
            label5.Name = "label5";
            label5.Size = new Size(152, 15);
            label5.TabIndex = 16;
            label5.Text = "Cantidad maxima (highqty)";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(11, 354);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(335, 23);
            textBox5.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 336);
            label6.Name = "label6";
            label6.Size = new Size(120, 15);
            label6.TabIndex = 18;
            label6.Text = "Descuento (discount)";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(11, 232);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(335, 23);
            numericUpDown1.TabIndex = 20;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(11, 296);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(335, 23);
            numericUpDown2.TabIndex = 21;
            // 
            // Descuentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(359, 527);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Descuentos";
            Text = "Descuentos";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}