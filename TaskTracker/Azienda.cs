using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class azienda
{
    public string nomeAzienda { get; set; }
    public string posizione { get; set; }

    public azienda()
    {
        nomeAzienda = "";
        posizione = "";
    }

    public int assesPosition(string filepath, string username)
    {
        var json = File.ReadAllText(filepath);
        Dictionary<string, userData> data = JsonConvert.DeserializeObject<Dictionary<string,userData>>(json);
        foreach (var user in data)
        {
            if (user.Key == username)
            {
                if (user.Value.az.posizione == "Dipendente")
                {
                    return 1;
                }
                else if (user.Value.az.posizione == "Capo Reparto")
                {
                    return 2;
                }
                else if (user.Value.az.posizione == "Dirigente")
                {
                    return 3;
                }
            }
        }
        return -1;
    }
}
