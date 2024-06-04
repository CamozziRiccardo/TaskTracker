using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TaskTracker
{
    public partial class Form3 : Form
    {
        string filepath;
        userData activeUser;
        public Form3(int posizione, userData activeUser)
        {
            InitializeComponent();
            filepath = "task.json";
            this.activeUser = activeUser;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = activeUser.az.posizione + " dell'azienda " + activeUser.az.nomeAzienda;
            label3.Text = "user: " + activeUser.nome;
            if (activeUser.az.posizione == "Dipendente")
            {
                listView2.Hide();
                label5.Hide();
                button2.Hide();
            }
            else
            {
                activeUser.loadEmplyees(filepath, activeUser.nome, listView1);
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0)
                activeUser.loadTasks(filepath, activeUser, listView2);
            else
                MessageBox.Show("No item selected");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}

