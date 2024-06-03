using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class azienda : userData
{
    protected string _nomeAzienda { get; set; }
    protected string _posizione { get; set; }

    public string nomeAzienda
    {
        get => _nomeAzienda;
        set => _nomeAzienda = value;
    }

    public string posizione
    {
        get => _posizione;
        set => _posizione = value;
    }

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
