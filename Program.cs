public class Evento
{
    public Evento(string titolo, DateTime data, int capienzaMassima, int postiPrenotati)
    {
        Titolo = titolo;
        Data = data;
        CapienzaMassima = capienzaMassima;
        PostiPrenotati = postiPrenotati;
    }

    string Titolo { get; set; }
    DateTime Data { get; set; }
    int CapienzaMassima { get;}
    int PostiPrenotati { get;}
}