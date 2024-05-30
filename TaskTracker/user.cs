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
            {
                return false;
            }

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
        {
            return true;
        }

        return false;
    }

    //funzione che mi ritorna i dati di un utente specifico
    public userData getUserData(string filepath, string username)
    {
        Dictionary<string, userData> users = loadUsers(filepath);
        foreach (var user in users)
        {
            if (user.Value.nome == username)
            {
                return user.Value;
            }
        }
        return new userData();
    }

    //funzione che salav i dati degli utenti sul json
    protected void saveUser(string filepath, Dictionary<string, userData> users)
    {
        var json = JsonConvert.SerializeObject(users, Formatting.Indented);
        File.WriteAllText(filepath, json);
    }

    //funzione che carica gli utenti presenti sul json in un dictionary
    protected Dictionary<string, userData> loadUsers(string filepath)
    {
        var json = File.ReadAllText(filepath);
        if (string.IsNullOrEmpty(json))
        {
            return new Dictionary<string, userData>();
        }
        return JsonConvert.DeserializeObject<Dictionary<string, userData>>(json);
    }
}
