using GPTClone.Application.Services;
using GPTClone.Infrastructure.Contexts;
using GPTClone.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPTClone.Infrastructure
{
  public static class ServiceRegistration
    {
        public static void AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddDbContext<GPTCloneDbContext>();

            services.AddScoped<IPromptService, PromptService>();
        }
    }
}
