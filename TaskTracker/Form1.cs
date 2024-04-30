using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.IO;
using System.Text.Json;
using System.Net;
using System.Threading.Tasks;

namespace TaskTracker
{
    #region strutture
    public struct JsonData
    {
        public string nomeTask;
        public string argomentoTask;
        public DateTime dataScadenza;
    }

    public struct userData
    {
        public int id;
        public string name;
        public string password;
    }
    #endregion

    public partial class Form1 : Form
    {
        DatabaseManager s;
        public userData userSample;
        Form2 f2;
        bool ar;

        public Form1()
        {
            InitializeComponent();
            userSample = new userData();
            s = new DatabaseManager("localhost:21", "interfacciatmdb", "0rcoDdinci!", "my_interfacciatmdb");
            f2 = new Form2();
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
            f2.ar = true;
            f2.datiInviati += form2_datiInviati;
            ar = true;
            f2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            f2.ar = false;
            f2.datiInviati += form2_datiInviati;
            ar = false;
            f2.Show();
        }

        #region comunicazione con database
        private void form2_datiInviati(object sender, invioDati e)
        {
            userSample = e.user;
            if (ar && s.CreaUtente(userSample.name, userSample.password, "{\"test\": \"test\"}"))
            {
                MessageBox.Show("Utente creato con successo");
            }
            else if (s.VerificaEsistenzaUtente(1, userSample.password))
            {
                MessageBox.Show("Utente verificato con successo");
            }
            else
            {
                MessageBox.Show("Utente non valido, reinserire i dati");
            }
            f2.Hide();
        }
        #endregion

        #endregion
    }
}