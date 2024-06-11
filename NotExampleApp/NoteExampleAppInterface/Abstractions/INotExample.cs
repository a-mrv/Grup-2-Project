using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteExampleAppInterface.Abstractions
{
    public interface INotExample
    {
        void Add(string note);

        IEnumerable<string> GetAll();
    }
}
