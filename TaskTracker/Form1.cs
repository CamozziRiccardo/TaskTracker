using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;
/*
namespace TaskTracker
{
    #region strutture
    public struct task
    {
        public string nomeTask;
        public string argomentoTask;
        public bool completion;
        public DateTime dataScadenza;
    }
    public struct Azienda
    {
        public string nomeAzienda;
        public string posizione;
    }
    public struct userData
    {
        public string name;
        public string password;
        public Azienda azienda;
        public List<task> tasks;
    }
    #endregion

    public partial class Form1 : Form
    {
        public userData userSample;
        userManagement json;
        bool ar;
        string filePath;

        public Form1()
        {
            InitializeComponent();
            userSample = new userData();

            json = new userManagement();
            filePath = "task.json";
        }

        #region accesso/registrazione
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
            Form2 f2 = new Form2();
            f2.ar = true;
            f2.inizialization();
            f2.datiInviati += form2_datiInviati;
            ar = true;
            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ar = false;
            f2.inizialization();
            f2.datiInviati += form2_datiInviati;
            ar = false;
            f2.Show();
        }
        #endregion

        #region salvataggio dati
        //Controllo dell'utente
        private void form2_datiInviati(object sender, invioDati e) 
        {
            userSample = e.user;
            if (!ar && json.createUser(userSample.name, userSample.password, userSample.azienda, filePath))
            {
                MessageBox.Show("Utente creato con successo, ora esegui l'accesso");
            }
            else if (!ar && !json.createUser(userSample.name, userSample.password, userSample.azienda, filePath))
            {
                MessageBox.Show("Utente già esistente, esegui l'accesso invece della registrazione");
            }
            else if (ar && json.verifyUser(userSample.name, userSample.password, userSample.azienda.nomeAzienda, filePath))
            {
                MessageBox.Show("Accesso eseguito con successo");
                if (json.assesPosition(filePath, userSample.name) == -1) MessageBox.Show("Posizione dell'utente non valida, si prega di rifare la registrazione e creare un nuovo utente");
                else 
                { 
                    Form3 f3 = new Form3(json.assesPosition(filePath, userSample.name), userSample.name);
                    f3.Show();
                }
            }
            else if (ar && !json.verifyUser(userSample.name, userSample.password, userSample.azienda.nomeAzienda, filePath))
            {
                MessageBox.Show("Azienda, password o utente errati");
            }
        }
        #endregion
    }
}
*/