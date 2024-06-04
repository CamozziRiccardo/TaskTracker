using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class task
{
    private string _nomeTask;
    private string _descrizioneTask;
    private bool _completamento;
    private DateTime _dataScadenza;

    public string nomeTask
    {
        get => _nomeTask;
        set => _nomeTask = value;
    }

    public string descrizioneTask
    {
        get => _descrizioneTask;
        set => _descrizioneTask = value;
    }

    public bool completamento
    {
        get => _completamento;
        set => _completamento = value;
    }

    public DateTime dataScadenza
    {
        get => _dataScadenza;
        set => _dataScadenza = value;
    }

    public task(string nT, string dT, string dS)
    {
        nomeTask = nT;
        descrizioneTask = dT;
        completamento = false;
        dataScadenza = DateTime.Parse(dS);
    }
}
