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
            target = Path.Combine(Application.StartupPath, target);
            try
            {
                // Creare un nuovo form
                Form htmlForm = new Form();
                htmlForm.Text = "Log In";

                // Creare un controllo WebBrowser e impostarlo come contenuto del form
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Dock = DockStyle.Fill;
                webBrowser.Navigate(target);
                htmlForm.Controls.Add(webBrowser);

                // Visualizzare il form
                htmlForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'apertura del file HTML: " + ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            target = "C:\\Users\\erdod\\OneDrive\\Desktop\\TaskTracker\\TaskTracker\\logIn.html";
            target = Path.Combine(Application.StartupPath, target);
            try
            {
                // Creare un nuovo form
                Form htmlForm = new Form();
                htmlForm.Text = "Register";

                // Creare un controllo WebBrowser e impostarlo come contenuto del form
                WebBrowser webBrowser = new WebBrowser();
                webBrowser.Dock = DockStyle.Fill;
                webBrowser.Navigate(target);
                htmlForm.Controls.Add(webBrowser);

                // Visualizzare il form
                htmlForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore durante l'apertura del file HTML: " + ex.Message);
            }
        }
    }
}