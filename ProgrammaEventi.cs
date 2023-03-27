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

    //public Documento? CercaPerCodice(string codice) => ListaDocumenti.FirstOrDefault(documento => documento.Codice == codice);
}