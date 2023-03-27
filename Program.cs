Console.WriteLine("Crea un nuovo evento");

Console.Write("Inserire il nome dell'evento: ");
string inputTitolo = Console.ReadLine();

Console.Write("Inserire la data in cui si terrà l'evento (dd/MM/yyyy): ");
DateTime inputData = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inserire il numero di posti presenti nel luogo in cui si svolgerà l'evento: ");
int inputCapacita = Convert.ToInt32(Console.ReadLine());

Console.Write("Quanti posti desideri prenotare? ");
int inputPrenotazioni = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Numero di posti prenotati: {inputPrenotazioni} ");

int postiDisponibili = Math.Max(0, inputCapacita - inputPrenotazioni);
Console.WriteLine($"Numero di posti disponibili: {postiDisponibili}");


bool continua = true;

while (continua)
{
    Console.Write("Vuoi disdire delle prenotazioni (sì/no)? ");
    string risposta = Console.ReadLine().ToLower();

    if (risposta == "no")
    {
        continua = false;
        Console.WriteLine($"Numero di posti disponibili: {postiDisponibili}");
    }
    else if (risposta == "sì" || risposta == "si")
    {
        Console.Write("Quante prenotazioni desideri disdire? ");
        int prenotazioniDaCancellare = Convert.ToInt32(Console.ReadLine());
        postiDisponibili = Math.Max(0, postiDisponibili + prenotazioniDaCancellare);
        Console.WriteLine($"Numero di posti disponibili: {postiDisponibili}");
    }
    else
    {
        Console.WriteLine("Risposta non valida.");
    }
}

Console.WriteLine("La tua prenotazione è andata a buon fine. Il programma è terminato.");


Evento nuovoEvento = new Evento(inputTitolo, inputData, inputCapacita);
Console.WriteLine(nuovoEvento);
Console.WriteLine($"Numero di posti rimasti disponibili: {postiDisponibili}");
