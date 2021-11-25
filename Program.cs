// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//Entità:
//L’impiegato deve essere inteso come una derivazione di Persona.

//Persona ha le seguenti caratteristiche:
//Nome
//Cognome
//Codice Fiscale

//L’impiegato ha anche le seguenti caratteristiche:
//Settore (Vendite, Amministrazione. Sviluppo)
//Calcolo stipendio mensile (metodo)
//Lista di skills

//Il Tecnico è un impiegato ma ha anche:
//Paga Oraria
//Ore Lavorate
//Calcolo stipendio; lo stipendio mensile del tecnico è dato
//da: Ore Lavorate * Paga Oraria

//Lo Stagista è un impiegato ma ha anche:
//Durata dello stage (in mesi. Esempio: 3)
//Calcolo stipendio: lo stipendio mensile dello stagista è 600 €.

//Il manager è un impiegato ma ha anche:
//Ore di straordinario (nel mese)
//Stipendio di base (mensile)
//Calcolo stipendio: lo stipendio mensile del manager è dato
//da: Stipendio Base + (Ore di straordinario * 10).

//La Skill ha come caratteristiche:

//Codice
//Descrizione

//(Esempio: Codice: “S1”, Descrizione: “Leadership”)

//Suggerimento:

//Inizializzare una lista di skills.

//Inizializzare una lista di impiegati, con almeno un elemento
//per ogni sottoclasse di impiegato e ognuno con almeno una skill
//nella propria lista di skills.