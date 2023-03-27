public class ProgrammaEventi
{
    public string Titolo;
    public List<Evento> ListaEventi = new();

    public ProgrammaEventi(string titolo, List<Evento> list)
    {
        Titolo = titolo;
        ListaEventi = list;
    }
    public void AggiungiEvento(Evento evento) => ListaEventi.Add(evento);

    public List<Evento> ListaEventiData(DateTime data)
    {
        List<Evento> eventiData = new List<Evento>();
        foreach (Evento evento in ListaEventi)
        {
            if (evento.Data == data)
            {
                eventiData.Add(evento);
            }
        }
        return eventiData;
    }
}