namespace FinalRound
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            button2 = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            button4 = new Button();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(25, 205);
            button1.Name = "button1";
            button1.Size = new Size(195, 78);
            button1.TabIndex = 0;
            button1.Text = "Добавить спектакль";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(25, 160);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(195, 39);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 117);
            label1.Name = "label1";
            label1.Size = new Size(236, 32);
            label1.TabIndex = 2;
            label1.Text = "Название спектакля";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 117);
            label2.Name = "label2";
            label2.Size = new Size(202, 32);
            label2.TabIndex = 3;
            label2.Text = "Название школы";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 160);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 39);
            textBox2.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(266, 205);
            button2.Name = "button2";
            button2.Size = new Size(168, 78);
            button2.TabIndex = 5;
            button2.Text = "Добавить школу";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(25, 338);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(195, 40);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(266, 338);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(168, 40);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 295);
            label3.Name = "label3";
            label3.Size = new Size(127, 32);
            label3.TabIndex = 8;
            label3.Text = "Спектакль";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(310, 295);
            label4.Name = "label4";
            label4.Size = new Size(88, 32);
            label4.TabIndex = 9;
            label4.Text = "Школа";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 394);
            label5.Name = "label5";
            label5.Size = new Size(242, 32);
            label5.TabIndex = 10;
            label5.Text = "Количество билетов";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(25, 436);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(195, 39);
            textBox3.TabIndex = 11;
            // 
            // button3
            // 
            button3.Location = new Point(271, 403);
            button3.Name = "button3";
            button3.Size = new Size(163, 67);
            button3.TabIndex = 12;
            button3.Text = "Купить билеты";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(25, 496);
            button4.Name = "button4";
            button4.Size = new Size(409, 43);
            button4.TabIndex = 13;
            button4.Text = "Отсортировать";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 24);
            label6.Name = "label6";
            label6.Size = new Size(78, 32);
            label6.TabIndex = 14;
            label6.Text = "label6";
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ButtonHighlight;
            textBox4.Enabled = false;
            textBox4.Location = new Point(482, 74);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(540, 415);
            textBox4.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 71);
            label7.Name = "label7";
            label7.Size = new Size(78, 32);
            label7.TabIndex = 16;
            label7.Text = "label7";
            // 
            // button5
            // 
            button5.Location = new Point(482, 495);
            button5.Name = "button5";
            button5.Size = new Size(277, 44);
            button5.TabIndex = 17;
            button5.Text = "Перезапустить";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(765, 495);
            button6.Name = "button6";
            button6.Size = new Size(257, 44);
            button6.TabIndex = 18;
            button6.Text = "Закрыть";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 565);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "ц";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Button button2;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private Label label6;
        private TextBox textBox4;
        private Label label7;
        private Button button5;
        private Button button6;
    }
}