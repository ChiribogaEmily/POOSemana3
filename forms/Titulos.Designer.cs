namespace semana3tarea1.forms
{
    partial class Titulos
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
            comboBox2 = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 201);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(338, 23);
            comboBox2.TabIndex = 48;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 413);
            label8.Name = "label8";
            label8.Size = new Size(111, 15);
            label8.TabIndex = 46;
            label8.Text = "Publicador (pub_id)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 355);
            label7.Name = "label7";
            label7.Size = new Size(149, 15);
            label7.TabIndex = 44;
            label7.Text = "Fecha publicado (pubdate)";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(11, 318);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(335, 23);
            textBox5.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 300);
            label6.Name = "label6";
            label6.Size = new Size(150, 15);
            label6.TabIndex = 42;
            label6.Text = "Ventas en el año (ytd_sales)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 257);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 23);
            textBox4.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 239);
            label5.Name = "label5";
            label5.Size = new Size(92, 15);
            label5.TabIndex = 40;
            label5.Text = "Regalía (royalty)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 183);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 39;
            label4.Text = "Avance (advance)";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 146);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 23);
            textBox2.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 37;
            label3.Text = "Precio (price)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 90);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(334, 23);
            comboBox1.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 35;
            label2.Text = "Titulo (title)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 32);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 34;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 72);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 33;
            label1.Text = "Tipo (type)";
            // 
            // button2
            // 
            button2.Location = new Point(138, 489);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 32;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(138, 460);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 31;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(10, 373);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 23);
            dateTimePicker1.TabIndex = 49;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(10, 431);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(334, 23);
            comboBox3.TabIndex = 50;
            // 
            // Titulos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(359, 527);
            Controls.Add(comboBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
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
            Name = "Titulos";
            Text = "Titulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox2;
        private Label label8;
        private Label label7;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox4;
        private Label label5;
        private Label label4;
        private TextBox textBox2;
        private Label label3;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
    }
}