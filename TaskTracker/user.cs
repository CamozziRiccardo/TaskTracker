using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class userData
{
    public string nome { get; set; }
    public string password { get; set; }
    public azienda az { get; set; }
    public List<task> tasks { get; set; }

    public userData()
    {
        nome = "";
        password = "";
        az = new azienda();
        tasks = new List<task>();
    }

    public userData(string nome, string password, azienda az, List<task> tasks)
    {
        this.nome = nome;
        this.password = password;
        this.az = az;
        this.tasks = tasks;
    }

    //funzione di aggiunta di un utente
    public bool writeUser(string username, string password, azienda az, string filepath)
    {
        try
        {
            //creo un dictionary richiamando la funzione di caricamento degli utenti
            Dictionary<string, userData> users = loadUsers(filepath);

            //verifico che l'utente non esista
            if (users.ContainsKey(username))
                return false;

            //creo un nuovo oggetto userData dai parametri della funzione
            userData newUser = new userData(username, password, az, new List<task>());

            //aggiungo il nuovo oggetto al dictionary
            users.Add(username, newUser);

            //richiamo la funzione che salva sul json i dati degli utenti
            saveUser(filepath, users);

            //ritorno true per mostrare che è stato aggiunto il nuovo utente
            return true;
        }
        catch
        {
            return false;
        }
    }

    //funzione che verifica l'esistenza dell'utente per la registrazione
    public bool verifyUser(string username, string password, string azienda, string filepath)
    {
        Dictionary<string, userData> users = loadUsers(filepath);

        if (users.ContainsKey(username) && users[username].password == password && users[username].az.nomeAzienda == azienda)
            return true;

        return false;
    }

    //funzione che mi ritorna i dati di un utente specifico
    public userData getUserData(string filepath, string username)
    {
        Dictionary<string, userData> users = loadUsers(filepath);
        foreach (var user in users)
            if (user.Value.nome == username)
                return user.Value;
        return new userData();
    }

    //funzione che salbva i dati degli utenti sul json
    protected void saveUser(string filepath, Dictionary<string, userData> users)
    {
        var json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(filepath, json);
    }

    //funzione che carica gli utenti presenti sul json in un dictionary
    protected Dictionary<string, userData> loadUsers(string filepath)
    {
        if (string.IsNullOrEmpty(File.ReadAllText(filepath)))
            return new Dictionary<string, userData>();
        var json = File.ReadAllText(filepath);
        return JsonConvert.DeserializeObject<Dictionary<string, userData>>(json);
    }

    //funzione di aggiunta di una task
    public void addTask(string filepath, task newTask, string username)
    {
        //caricamento degli utenti su un dictionary
        Dictionary<string, userData> users = loadUsers(filepath);

        foreach (var user in users)
            if (user.Key == username)
                user.Value.tasks.Add(newTask);
        saveUser(filepath, users);
    }



    //funzione che carica le task di un utente su una listview
    public void loadTasks(string filepath, userData user, ListView lV)
    {
        lV.Items.Clear();
        foreach (task t in user.tasks)
            lV.Items.Add(t.nomeTask);
    }

    //funzione di cancellamento di una una lista di task specifiche
    public void removeTasks(string filepath, string username, List<task> toRemove)
    {
        //caricamento degli utenti su un dictionary
        Dictionary<string, userData> users = loadUsers(filepath);

        foreach (var user in users)
            if (user.Key == username)
                foreach (var task in user.Value.tasks)
                    foreach (var taskToRemove in toRemove)
                        if (task == taskToRemove)
                            user.Value.tasks.Remove(task);
        saveUser(filepath, users);

    }

    //funzione di cancellamento di tutte le task completate di un utente
    public void removeTask(string filepath, string username)
    {
        //caricamento degli utenti su un dictionary
        Dictionary<string, userData> users = loadUsers(filepath);
        foreach (var user in users)
            if (user.Key == username)
                foreach (var task in user.Value.tasks)
                    if (task.completamento == true)
                        user.Value.tasks.Remove(task);
        saveUser(filepath, users);
    }

    //funzione di riconoscimento della posizione di un utente all'interno dell'azienda
    public int assesPosition(string filepath, string username)
    {
        //caricamento degli utenti su un dictionary
        Dictionary<string, userData> data = loadUsers(filepath);
        foreach (var user in data)
            if (user.Key == username)
                if (user.Value.az.posizione == "Dipendente")
                    return 1;
                else if (user.Value.az.posizione == "Capo Reparto")
                    return 2;
                else if (user.Value.az.posizione == "Dirigente")
                    return 3;
        //se l'utente non dovesse possedere una posizione o ne possedesse una non riconosciuta ritorno -1
        return -1;
    }

    //funziona di caricamento degli utenti con posizioni meno importanti su una listview
    public void loadEmplyees(string filepath, string username, ListView lV)
    {
        //caricamento degli utenti su un dictionary
        Dictionary<string, userData> data = loadUsers(filepath);
        foreach (var user in data)
            if (user.Key == username)
                if (user.Key == "Capo Reparto")
                {
                    foreach (var item in data)
                        if (item.Value.az.nomeAzienda == user.Value.az.nomeAzienda && item.Value.az.posizione == "Dipendente")
                            lV.Items.Add(item.Value.nome);
                }
                else if (user.Key == "Dirigente")
                    foreach (var item in data)
                        if (item.Value.az.nomeAzienda == user.Value.az.nomeAzienda && item.Value.az.posizione == "Dipendente")
                            lV.Items.Add(item.Value.nome);
                        else if (item.Value.az.nomeAzienda == user.Value.az.nomeAzienda && item.Value.az.posizione == "Capo Reparto")
                            lV.Items.Add(item.Value.nome);
        return;
    }
}
