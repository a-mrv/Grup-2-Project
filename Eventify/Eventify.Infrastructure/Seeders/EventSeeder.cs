﻿using Eventify.Domain.Entities;
using Eventify.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify.Infrastructure.Seeders
{
    public static class EventSeeder
    {
        public static void SeedEvent(ModelBuilder modelBuilder)
        {
            var eventId = Guid.NewGuid();

            modelBuilder.Entity<Event>().HasData(new Event()
            {
                Id = eventId,
                CreatedAt = DateTime.UtcNow,
                Title = "Event 1",
                Description = "Event 1 Description",
                Date = DateTime.UtcNow.AddDays(1),
                Type = EventType.InRealLife
            });

            modelBuilder.Entity<Event>().OwnsOne(e => e.Location).HasData(new
            {
                EventId = eventId,
                City = "City 1",
                Street = "Street 1",
                No = "12",
                District = "District 1",
                Note = "Near by Stadium",
                PostalCode = "12345"
            });
        }
    }
}
