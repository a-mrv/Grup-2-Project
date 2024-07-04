using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Application.Services
{
    public interface IOpenAIService
    {
        string GetResponse(string text);
    }
}
