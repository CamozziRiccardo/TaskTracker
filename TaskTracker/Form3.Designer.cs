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
            listView1.Location = new Point(418, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(370, 426);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Arial Narrow", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 174);
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
            label3.Location = new Point(12, 213);
            label3.Name = "label3";
            label3.Size = new Size(0, 29);
            label3.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(verticalLine);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel verticalLine;
        private ListView listView1;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}