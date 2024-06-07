using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteApp.Abstractions
{
    public interface INoteService
    {
        void SaveNote(string text);
        string GetNote(string text);
    }
}
