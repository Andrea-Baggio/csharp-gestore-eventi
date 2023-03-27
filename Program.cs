public class Evento
{
    public string _titolo;
    public DateTime _data;
    public int _capienzaMassima;
    public int PostiPrenotati { get; private set; }

    public Evento(string titolo, DateTime data, int capienzaMassima)
    {
        Titolo = titolo;
        Data = data;
        CapienzaMassima = capienzaMassima;
        PostiPrenotati = 0;
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
        private set
        {
            if (value <= 0)
            {
                Console.WriteLine("La capienza massima deve essere un numero positivo.");
            }
            _capienzaMassima = value;
        }
    }

    public void PrenotaPosti(int prenotazione)
    {
        if (Data < DateTime.Now || PostiPrenotati == CapienzaMassima)
        {
            Console.WriteLine("Impossibile prenotare i posti richiesti.");
        }
        PostiPrenotati += prenotazione;
    }

    public void DisdiciPosti(int disdicimento)
    {
        if (Data < DateTime.Now || PostiPrenotati <= 0)
        {
            Console.WriteLine("Impossibile disdire i posti richiesti.");
        }
        PostiPrenotati -= disdicimento;
    }

    public override string ToString()
    {
        return $"Evento: {Data.ToString("dd/MM/yyyy")} - {Titolo}";
    }
}
