using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection.Metadata.Ecma335;

class KodePaket
{
    private Dictionary<string, string> tabelKodePaket = new Dictionary<string, string>()
    {
        {"Basic", "P201"},
        {"Standard", "P202"},
        {"Premium", "P203"},
        {"Unlimited", "P204"},
        {"Gaming", "P205"},
        {"Streaming", "P206"},
        {"Family", "P207"},
        {"Business", "P208"},
        {"Student", "P209"},
        {"Traveler", "P2010"}
    };

    public string getKodePaket (string namaPaket)
    {
        return tabelKodePaket[namaPaket];
    }
}