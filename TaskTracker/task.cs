using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class task
{
    private string nomeTask { get; set; }
    private string descrizioneTask { get; set; }
    private bool completamento { get; set; }
    public DateTime dataScadenza { get; set; }

    public task(string nT, string dT, string dS)
    {
        nomeTask = nT;
        descrizioneTask = dT;
        completamento = false;
        dataScadenza = DateTime.Parse(dS);
    }

    //funzione che carica le task di un utente su una listview
    public void loadTasks(string filepath, userData user, ListView lV)
    {
        lV.Items.Clear();
        foreach (task t in user.tasks) 
            lV.Items.Add(t.nomeTask);
    }
}
