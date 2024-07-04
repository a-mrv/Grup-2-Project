using GPTClone.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Application.Services
{
    public interface IPromptService
    {

        void Add(PromptAddDto promptAddDto);
        List<PromptGetAllDto>GetAll();

        List<PromptGetByIdDto> GetAll(Guid Id);
        void Delete(Guid Id);


    }
}
