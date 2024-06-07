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
        void INoteService.SaveNote(string text)
        {
            throw new NotImplementedException();
        }
    }
}
