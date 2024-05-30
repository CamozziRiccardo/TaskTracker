using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
namespace TaskTracker
{
    public partial class Form3 : Form
    {
        userData user;
        userManagement uM;
        taskManager tM;
        string filepath;
        public Form3(int posizione, string username)
        {
            InitializeComponent();
            filepath = "task.json";
            tM = new taskManager();
            uM = new userManagement();
            user = uM.getUserData(filepath, username);
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = user.azienda.posizione + " dell'azienda " + user.azienda.nomeAzienda;
            label3.Text = "user: " + user.name;
            if (user.azienda.posizione == "Dipendente")
            {
                listView2.Hide();
                label5.Hide();
                button2.Hide();
            }
            else if (user.azienda.posizione == "Capo reparto")
            {
                foreach (userData user1 in uM.loadUsers(filepath).Values)
                {
                    if (user1.azienda.posizione == "dipendente" && user.azienda.nomeAzienda == user1.azienda.nomeAzienda) listView2.Items.Add($"{user1.azienda.posizione}: {user1.name}");
                }
            }
            else
            {
                foreach (userData user1 in uM.loadUsers(filepath).Values)
                {
                    if (user.azienda.nomeAzienda == user1.azienda.nomeAzienda) listView2.Items.Add($"{user1.azienda.posizione}: {user1.name}");
                }
            }
        }

        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedIndices.Count > 0) tM.loadTasks(filepath, user, listView2);
            else
                MessageBox.Show("No item selected");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            task t = new task
            {
                nomeTask = textBox1.Text,
                argomentoTask = richTextBox1.Text,
                completion = false,
                dataScadenza = DateTime.Parse(textBox1.Text),
            };
            groupBox1.Hide();

        }
    }
}
*/
