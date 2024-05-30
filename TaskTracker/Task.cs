using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class task : userData
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

    //funzione di aggiunta di una task
    public void addTask(string filepath, task newTask, string username)
    {
        //caricamento degli utenti su un dictionary
        Dictionary<string, userData> users = loadUsers(filepath);

        foreach (var user in users)
        {
            if (user.Key == username)
            {
                user.Value.tasks.Add(newTask);
            }
        }
        saveUser(filepath, users);
    }

    //funzione di cancellamento di tutte le task completate di un utente
    public void removeTask(string filepath, string username)
    {
        //caricamento degli utenti su un dictionary
        Dictionary<string, userData> users = loadUsers(filepath);
        foreach (var user in users)
        {
            if (user.Key == username)
            {
                foreach (var task in user.Value.tasks)
                {
                    if (task.completamento == true)
                    {
                        task.remov
                    }
                }
            }
        }
    }
}
