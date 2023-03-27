public class Evento
{
    public string _titolo;
    public DateTime _data;
    public int _capienzaMassima;
    public int? PostiPrenotati { get; }

    public Evento(string titolo, DateTime data, int capienzaMassima)
    {
        Titolo = titolo;
        Data = data;
        CapienzaMassima = capienzaMassima;
    }

    public string Titolo
    {
        get { return _titolo; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Il titolo non può essere vuoto.");
            }
            _titolo = value;
        }
    }
    public DateTime Data
    {
        get { return _data; }
        set
        {
            if (value > DateTime.Now)
            {
                Console.WriteLine("La data deve essere futura.");
            }
            _data = value;
        }
    }
    public int CapienzaMassima
    {
        get { return _capienzaMassima; }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("La capienza massima deve essere un numero positivo.");
            }
            _capienzaMassima = value;
        }
    }
}
