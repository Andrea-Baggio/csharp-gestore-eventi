Console.WriteLine("Crea un nuovo evento");

Console.Write("Inserire il nome dell'evento: ");
string inputTitolo = Console.ReadLine();

Console.Write("Inserire la data in cui si terrà l'evento (dd/MM/yyyy): ");
DateTime inputData = Convert.ToDateTime(Console.ReadLine());

Console.Write("Inserire il numero di posti presenti nel luogo in cui si svolgerà l'evento: ");
int inputCapacita = Convert.ToInt32(Console.ReadLine());


Evento mioEvento = new Evento(inputTitolo, inputData, inputCapacita);
Console.WriteLine(mioEvento);


