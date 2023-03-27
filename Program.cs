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


int postiDisponibili = Math.Max(0, inputCapacita - inputPrenotazioni);
Console.WriteLine($"Numero di posti disponibili: {postiDisponibili}");





Evento nuovoEvento = new Evento(inputTitolo, inputData, inputCapacita);
Console.WriteLine(nuovoEvento);