using Eventify.Application.Dtos;
using Eventify.Domain.Entities;
using Eventify.Domain.Enums;
using Eventify.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Application.Services
{
    public interface IEventService
    {
        public void Add(EventAddDto eventAddDto);
        public List<EventGetAllDto> GetAll();
        public EventGetByIdDto GetById(Guid id);
        public void Update(Guid Id,EventUpDateDto eventUpDateDto);
    }
}
