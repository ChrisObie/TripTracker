using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripTracker.Models;

namespace TripTracker.BackService.Data
{
    public class TripContext : DbContext
    {
        public DbSet<Trip> Trips { get; set; }


       // protected override void OnModelCreating(ModelBuilder modelBuilder)
       // {
       //     modelBuilder.Entity<Trip>().HasKey(t => t.TheId)
       // }

    }
}
