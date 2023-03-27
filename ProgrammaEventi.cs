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

    public static void StampaLista(List<Evento> ListaEventi)
    {
        foreach (var evento in ListaEventi)
        {
            Console.WriteLine(evento);
        }
    }
    public void ContaElementi()
    {
        int numElementi = ListaEventi.Count();
        Console.WriteLine($"Questa lista contiene { numElementi } elementi");
    }

    public void SvuotaLista() => ListaEventi.Clear();

    public void StampaElementi(List<Evento> ListaEventi)
    {
        foreach (var evento in ListaEventi)
        {
            Console.WriteLine($"Il nome del programma è: {AppDomain.CurrentDomain.FriendlyName}");
            Console.WriteLine($"Data: { evento.Data} - Titolo: {evento.Titolo}");
        }
    }
}