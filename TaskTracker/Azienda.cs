using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class azienda
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
}
