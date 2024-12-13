namespace semana3tarea1.forms
{
    partial class Autores
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox7 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 88);
            label2.Name = "label2";
            label2.Size = new Size(163, 15);
            label2.TabIndex = 16;
            label2.Text = "Apellido del autor (au_lname)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 41);
            label1.Name = "label1";
            label1.Size = new Size(200, 15);
            label1.TabIndex = 14;
            label1.Text = "Primer nombre del autor (au_fname)";
            // 
            // button2
            // 
            button2.Location = new Point(141, 499);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Cerrar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(141, 470);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 106);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 162);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(335, 23);
            textBox3.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 144);
            label3.Name = "label3";
            label3.Size = new Size(98, 15);
            label3.TabIndex = 18;
            label3.Text = "Teléfono (phone)";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 218);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 23);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 200);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 20;
            label4.Text = "Dirección (address)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 257);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 22;
            label5.Text = "Ciudad (city)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 313);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 24;
            label6.Text = "Estado (state)";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(13, 384);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(335, 23);
            textBox7.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 366);
            label7.Name = "label7";
            label7.Size = new Size(118, 15);
            label7.TabIndex = 26;
            label7.Text = "Dirección postal (zip)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 418);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 28;
            label8.Text = "Contrato (contract)";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(15, 436);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(332, 23);
            comboBox1.TabIndex = 29;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(13, 275);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(332, 23);
            comboBox2.TabIndex = 30;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(14, 331);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(332, 23);
            comboBox3.TabIndex = 31;
            // 
            // Autores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(359, 527);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Autores";
            Text = "Autores";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}