using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlessiaLIONETTO.GestioneImpiegati
{
    internal class Skill
    {
        public string Codice { get; set; }
        public string Descrizione { get; set; }

        public Skill(string cod,string descrizione)
        {
            Codice = cod;
            Descrizione = descrizione;
        }
    }
}
