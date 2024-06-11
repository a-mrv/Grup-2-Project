using Domain;

List<string> nots = new();
string filePath = "C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\NotExampleApp\\NotExampleApp\\text.txt";
var services = new Services(filePath);

Console.WriteLine("NOT YAZMA SİSTEMİ");

while (true)
{
    Console.WriteLine("1. Not Kaydet");
    Console.WriteLine("2. Not Oku");
    Console.WriteLine("3. Çıkış");
    Console.Write("Seçiminiz: ");
    string choice = Console.ReadLine();


    switch (choice)
    {
        case "1":
            Console.Write("Kaydedilecek not: ");
            string note = Console.ReadLine();
            services.Add(note);
           // File.AppendAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\NotExampleApp\\NotExampleApp\\text.txt", not);
            //Console.WriteLine(not);
            break;

        case "2":

            Console.WriteLine("Kaydedilen not:");
            var savedNotes = services.GetAll();
            foreach (var savedNote in savedNotes)
            {
                Console.WriteLine(savedNote);
            }
            //foreach (var note in nots)
            //{
            //    Console.WriteLine(note);
            //}
            //var savedtext = File.ReadAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\NotExampleApp\\NotExampleApp\\text.txt");
            //Console.WriteLine(savedtext);

            break;

        case "3":
            return;

        default:

            Console.WriteLine("Geçersiz seçim!");
            break;
    }
   
}


