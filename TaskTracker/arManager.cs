using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker
{
    internal class arManager
    {
        public bool createUser(string username, string password, Azienda az, string filepath)
        {
            try
            {
                Dictionary<string, userData> users = loadUsers(filepath);
                if (users.ContainsKey(username))
                {
                    return false;
                }

                userData nuovoUtente = new userData
                {
                    name = username,
                    password = password,
                    azienda = az,
                    tasks = new List<task>()
                };

                users.Add(username, nuovoUtente);

                saveUser(filepath, users);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool verifyUser(string username, string password, string azienda, string filepath)
        {
            Dictionary<string, userData> users = loadUsers(filepath);

            if (users.ContainsKey(username) && users[username].password == password && users[username].azienda.nomeAzienda == azienda)
            {
                return true;
            }

            return false;
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

        public int assesPosition(string filePath, string username)
        {
            var json = File.ReadAllText(filePath);
            Dictionary<string, userData> users = JsonConvert.DeserializeObject<Dictionary<string, userData>>(json);
            foreach (var user in users)
            {
                if (user.Key == username)
                {
                    if (user.Value.azienda.posizione == "Dipendente")
                    {
                        return 1;
                    }
                    else if (user.Value.azienda.posizione == "Capo Reparto")
                    {
                        return 2;
                    }
                    else if (user.Value.azienda.posizione == "Dirigente")
                    {
                        return 3;
                    }
                }
            }
            return -1;
        }
    }
}
