using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class azienda : userData
{
    public string nomeAzienda { get; set; }
    public string posizione { get; set; }

    public azienda()
    {
        nomeAzienda = "";
        posizione = "";
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
}
