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
        }
    }
}
