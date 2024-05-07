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
            // listViewPersonalizzata
            // 
            listView1.Location = new Point(418, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(370, 426);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.CheckBoxes = true;
            listView1.GridLines = true;
            
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listView1);
            Controls.Add(verticalLine);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel verticalLine;
        private ListView listView1;
    }
}