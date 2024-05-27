namespace TaskTracker
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 35);
            label1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(104, 29);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(203, 44);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 76);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(203, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(185, 27);
            textBox2.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(12, 171);
            button2.Name = "button2";
            button2.Size = new Size(376, 27);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 106);
            label4.Name = "label4";
            label4.Size = new Size(141, 29);
            label4.TabIndex = 11;
            label4.Text = "Nome Azienda";
            label4.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Dipendente", "Capo reparto", "Dirigente" });
            comboBox1.Location = new Point(203, 137);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(185, 28);
            comboBox1.TabIndex = 12;
            comboBox1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(203, 106);
            label5.Name = "label5";
            label5.Size = new Size(155, 29);
            label5.TabIndex = 13;
            label5.Text = "Seleziona Ruolo";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(131, 106);
            label6.Name = "label6";
            label6.Size = new Size(141, 29);
            label6.TabIndex = 15;
            label6.Text = "Nome Azienda";
            label6.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 137);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(185, 28);
            comboBox2.TabIndex = 16;
            comboBox2.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(12, 137);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(185, 28);
            comboBox3.TabIndex = 17;
            comboBox3.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 215);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Label label6;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
    }
}