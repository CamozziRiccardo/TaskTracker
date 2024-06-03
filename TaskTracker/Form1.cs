using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace TaskTracker
{
    public partial class Form1 : Form
    {
        public userData userSample;
        string filePath;
        Form2 f2;
        bool ar;

        public Form1()
        {
            InitializeComponent();
            userSample = new userData();
            f2 = new Form2();
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
            f2.ar = true;
            f2.inizialization();
            f2.datiInviati += form2_datiInviati;
            ar = true;
            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f2.ar = false;
            f2.inizialization();
            f2.datiInviati += form2_datiInviati;
            ar = false;
            f2.Show();
        }

        private void form2_datiInviati(object sender, invioDati e) 
        {
            userSample = e.user;
            if (!ar && userSample.writeUser(userSample.nome, userSample.password, userSample.az, filePath))
            {
                MessageBox.Show("Utente creato con successo, ora esegui l'accesso");
                f2.Hide();
            }
            else if (!ar && !userSample.writeUser(userSample.nome, userSample.password, userSample.az, filePath))
            {
                MessageBox.Show("Utente già esistente, esegui l'accesso invece della registrazione");
            }
            else if (ar && userSample.verifyUser(userSample.nome, userSample.password, userSample.az.nomeAzienda, filePath))
            {
                MessageBox.Show("Accesso eseguito con successo");
                if (userSample.az.assesPosition(filePath, userSample.nome) == -1) MessageBox.Show("Posizione dell'utente non valida, si prega di rifare la registrazione e creare un nuovo utente");
                else 
                { 
                    Form3 f3 = new Form3(userSample.az.assesPosition(filePath, userSample.nome), userSample.nome);
                    f3.Show();
                }
            }
            else if (ar && !userSample.verifyUser(userSample.nome, userSample.password, userSample.az.nomeAzienda, filePath))
            {
                MessageBox.Show("Azienda, password o utente errati");
            }
        }
    }
}