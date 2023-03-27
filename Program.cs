using static System.Runtime.InteropServices.JavaScript.JSType;

public class Evento
{
    public Evento(string titolo, DateTime data, int capienzaMassima, int postiPrenotati)
    {
        Titolo = titolo;
        Data = data;
        CapienzaMassima = capienzaMassima;
        PostiPrenotati = postiPrenotati;
    }

    public string Titolo
    {
        get { return Titolo; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Il titolo non può essere vuoto.");
            }
            Titolo = value;
        }
    }
    public DateTime Data
    {
        get { return Data; }
        set
        {
            if (value < DateTime.Now)
            {
                Console.WriteLine("La data deve essere futura.");
            }
            Data = value;
        }
    }
    public int CapienzaMassima
    {
        get { return CapienzaMassima; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("La capienza massima deve essere un numero positivo.");
            }
            CapienzaMassima = value;
        }
    }
    public int PostiPrenotati { get;}
}