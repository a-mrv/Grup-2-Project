using NoteApp.Abstractions;
using NoteApp.Services;

NoteService _services = new();




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
            _services.SaveNote(note);
            break;
        case "2":
            string savedNote = _services.GetNote();
            _services.SaveNote(savedNote);
            break;
        case "3":
            return;
        default:
            Console.WriteLine("Geçersiz seçim!");
            break;
    }
}

