using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace TaskTracker
{
    public partial class Form1 : Form
    {
        MySQL s;

        public Form1()
        {
            InitializeComponent();
            s = new MySQL();
        }

        public void hover1(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Blue;
        }

        public void deHover1(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Black;
        }

        public void hover2(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Blue;
        }

        public void deHover2(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Black;
        }

        private void label2_Click(object sender, EventArgs e)
        {

            s.passData();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        public class JsonData
        {
            public string String1 { get; set; }
            public string String2 { get; set; }
            public DateTime Data { get; set; }
        }
    }
}