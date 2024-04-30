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

        #region inserimento dati
        private void Form2_Load(object sender, EventArgs e)
        {
            if (ar)
            {
                label1.Text = "Esegui l'accesso";
                button2.Text = "Accedi";
            }
            else
            {
                label1.Text = "boh";
                button2.Text = "Registrati";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user.name = textBox1.Text;
            user.password = textBox2.Text;
            OnDatiInviati(user);
            textBox1.Text = "";
            textBox2.Text = "";
        }

        protected virtual void OnDatiInviati(userData data)
        {
            datiInviati?.Invoke(this, new invioDati(data));
        }
        #endregion
    }
}
