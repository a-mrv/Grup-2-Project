using GPTClone.Application.Dtos;
using GPTClone.Application.Services;
using GPTClone.Domain.Entities;
using GPTClone.Infrastructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Infrastructure.Services
{
    public class PromptService : IPromptService
    {
        private readonly GPTCloneDbContext _dbContext;

        public PromptService(GPTCloneDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(PromptAddDto promptAddDto)
        {
            _dbContext.Prompts.Add(new Prompt
            {
                Id = Guid.NewGuid(),
                CreatedAt = DateTimeOffset.UtcNow,
                Text = promptAddDto.Text,
                Response = promptAddDto.Response,
                CreatedBy = promptAddDto.CreatedBy,
            });
            _dbContext.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var prompt = _dbContext.Prompts
                .FirstOrDefault(x => x.Id == id);
            if (prompt is null)
                throw new Exception("Prompt not found");
            _dbContext.Prompts.Remove(prompt);
            _dbContext.SaveChanges();
        }

        public List<PromptGetAllDto> GetAll()
        {
            var prompts = _dbContext.Prompts
                .Select(x => new PromptGetAllDto
                {
                    Id = x.Id,
                    CreatedBy = x.CreatedBy,
                    Text = x.Text,
                    Response = x.Response
                })
             .ToList();

            return prompts;
        }

        public List<PromptGetByIdDto> GetAll(Guid id)
        {
            var prompt = _dbContext.Prompts
           .Select(x => new PromptGetByIdDto()
           {
               Id = x.Id,
               CreatedAt = x.CreatedAt,
               CreatedBy = x.CreatedBy,
               Text = x.Text,
               Response = x.Response
           })
           .FirstOrDefault(x => x.Id == id);

            return prompt;
        }
    }
}
