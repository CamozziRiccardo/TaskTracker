using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    internal class jsonManager
    {
        public bool createUser(string username, string password, Azienda az, string filepath)
        {
            try
            {
                //prendi tutti gli utenti dal file json
                Dictionary<string, userData> users = loadUsers(filepath);
                if (users.ContainsKey(username))
                {
                    return false;
                }

                //creazione del nuovo utente da inserire nel json
                userData nuovoUtente = new userData
                {
                    name = username,
                    password = password,
                    azienda = az,
                    task = new task()
                };

                //aggiungo il nuovo utente al dizionario
                users.Add(username, nuovoUtente);

                //salvo i dati sul json
                saveUser(filepath, users);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool verifyUser(string username, string password, string filepath)
        {
            try
            {
                //prendi tutti gli utenti dal file json
                Dictionary<string, userData> users = loadUsers(filepath);

                //controllo se l'utente esiste già e se la password è corretta per l'accesso
                if (users.ContainsKey(username) && users[username].password == password)
                {
                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }

        public Dictionary<string, userData> loadUsers(string filePath)
        {
            var json = File.ReadAllText(filePath);
            if (string.IsNullOrEmpty(json))
            {
                return new Dictionary<string, userData>();
            }
            return JsonConvert.DeserializeObject<Dictionary<string, userData>>(json);
        }

        public void saveUser(string filePath, Dictionary<string, userData> users)
        {
            var json = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
