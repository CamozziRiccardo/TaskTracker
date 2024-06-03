using Newtonsoft.Json;
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
    public partial class Form2 : Form
    {
        public bool ar { get; set; }
        public event EventHandler<invioDati> datiInviati;
        public userData user;

        public Form2()
        {
            InitializeComponent();
            user = new userData();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            inizialization();
        }

        public void inizialization()
        {
            if (ar)
            {
                label4.Hide();
                label5.Hide();
                comboBox3.Hide();
                comboBox1.Hide();
                label6.Show();
                comboBox2.Show();
                chargeCombobBox(2);
                label1.Text = "Esegui l'accesso";
                button2.Text = "Accedi";
            }
            else
            {
                label1.Text = "Registrazione";
                button2.Text = "Registrati";
                label4.Show();
                label5.Show();
                comboBox3.Show();
                comboBox1.Show();
                chargeCombobBox(1);
                label6.Hide();
                comboBox2.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ar)
            {
                user.nome = textBox1.Text;
                user.password = textBox2.Text;
                user.az.nomeAzienda = comboBox2.Text;
                OnDatiInviati(user);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox2.Text = "";
            }
            else
            {
                user.nome = textBox1.Text;
                user.password = textBox2.Text;
                user.az.nomeAzienda = comboBox3.Text;
                user.az.posizione = comboBox1.Text;
                OnDatiInviati(user);
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox3.Text = "";
                comboBox1.Text = "";
            }
        }

        protected virtual void OnDatiInviati(userData data)
        {
            datiInviati?.Invoke(this, new invioDati(data));
        }

        public void chargeCombobBox(int n)
        {
            switch (n)
            {
                case 1:
                    comboBox3.Items.Clear();
                    break;

                case 2:
                    comboBox2.Items.Clear();
                    break;
            }
            string json = File.ReadAllText("task.json");

            Dictionary<string, userData> users = JsonConvert.DeserializeObject<Dictionary<string, userData>>(json);

            HashSet<string> uniqueCompanyNames = new HashSet<string>();

            foreach (var user in users)
            {
                if (user.Value.az.nomeAzienda != null)
                {
                    if (!uniqueCompanyNames.Contains(user.Value.az.nomeAzienda))
                    {
                        uniqueCompanyNames.Add(user.Value.az.nomeAzienda);
                        switch (n)
                        {
                            case 1:
                                comboBox3.Items.Add(user.Value.az.nomeAzienda);
                                break;

                            case 2:
                                comboBox2.Items.Add(user.Value.az.nomeAzienda);
                                break;
                        }
                    }
                }
            }
        }
    }
}