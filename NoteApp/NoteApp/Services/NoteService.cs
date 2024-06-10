using NoteApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Services
{
    public class NoteService : INoteService
    {

        public void SaveNote(string text)
        {
            File.AppendAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\NoteApp\\NoteApp\\text.txt", text);
            Console.WriteLine("Not kaydedildi.");
        }
        public string GetNote()
        {
            Console.WriteLine("Kaydedilmiş Not:");
            return File.ReadAllText("C:\\Users\\MERVE\\Documents\\GitHub\\Grup-2-Project\\NoteApp\\NoteApp\\text.txt");
        }
    }
}
