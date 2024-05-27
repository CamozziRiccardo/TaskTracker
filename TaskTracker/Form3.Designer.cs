namespace TaskTracker
{
    partial class Form3
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
            verticalLine = new Panel();
            listView1 = new ListView();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            listView2 = new ListView();
            label5 = new Label();
            groupBox1 = new GroupBox();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label9 = new Label();
            button3 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // verticalLine
            // 
            verticalLine.BackColor = Color.Black;
            verticalLine.Location = new Point(400, 0);
            verticalLine.Name = "verticalLine";
            verticalLine.Size = new Size(1, 500);
            verticalLine.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            listView1.Location = new Point(418, 38);
            listView1.Name = "listView1";
            listView1.Size = new Size(370, 400);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 12);
            label2.Name = "label2";
            label2.Size = new Size(0, 29);
            label2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(400, 211);
            label1.Name = "label1";
            label1.Size = new Size(0, 29);
            label1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 51);
            label3.Name = "label3";
            label3.Size = new Size(0, 29);
            label3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(12, 83);
            button1.Name = "button1";
            button1.Size = new Size(189, 54);
            button1.TabIndex = 7;
            button1.Text = "Aggiungi una task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(207, 83);
            button2.Name = "button2";
            button2.Size = new Size(187, 54);
            button2.TabIndex = 8;
            button2.Text = "Cancella le Task completate";
            button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(418, 6);
            label4.Name = "label4";
            label4.Size = new Size(270, 29);
            label4.TabIndex = 9;
            label4.Text = "Lista delle task da completare";
            // 
            // listView2
            // 
            listView2.CheckBoxes = true;
            listView2.GridLines = true;
            listView2.LabelWrap = false;
            listView2.Location = new Point(12, 172);
            listView2.Name = "listView2";
            listView2.Size = new Size(370, 266);
            listView2.TabIndex = 10;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.List;
            listView2.DoubleClick += listView2_DoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 140);
            label5.Name = "label5";
            label5.Size = new Size(149, 29);
            label5.TabIndex = 11;
            label5.Text = "Lista dipendenti";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(12, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(370, 263);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 0;
            label6.Text = "Inserisci nome Task";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(182, 23);
            label7.Name = "label7";
            label7.Size = new Size(173, 20);
            label7.TabIndex = 1;
            label7.Text = "Inserisci Descrizione Task";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 2;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(182, 46);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(182, 211);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 76);
            label8.Name = "label8";
            label8.Size = new Size(153, 20);
            label8.TabIndex = 4;
            label8.Text = "Inserisci scadenzaTask";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 27);
            textBox2.TabIndex = 5;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 96);
            label9.Name = "label9";
            label9.Size = new Size(107, 20);
            label9.TabIndex = 6;
            label9.Text = "(gg/mm/aaaa)";
            // 
            // button3
            // 
            button3.Location = new Point(27, 178);
            button3.Name = "button3";
            button3.Size = new Size(132, 45);
            button3.TabIndex = 7;
            button3.Text = "Invio";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(label5);
            Controls.Add(listView2);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(verticalLine);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel verticalLine;
        private ListView listView1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
        private Button button2;
        private Label label4;
        private ListView listView2;
        private Label label5;
        private GroupBox groupBox1;
        private Label label7;
        private Label label6;
        private TextBox textBox1;
        private Button button3;
        private Label label9;
        private TextBox textBox2;
        private Label label8;
        private RichTextBox richTextBox1;
    }
}