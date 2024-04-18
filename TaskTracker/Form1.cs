using System;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace TaskTracker
{
    public partial class Form1 : Form
    {
        string target;
        public Form1()
        {
            InitializeComponent();
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
            target = "C:\\Users\\erdod\\OneDrive\\Desktop\\TaskTracker\\TaskTracker\\logIn.html";
            try
            {
                Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            target = "C:\\Users\\erdod\\OneDrive\\Desktop\\TaskTracker\\TaskTracker\\logIn.html";
            try
            {
                Process.Start(target);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }
        }
    }
}