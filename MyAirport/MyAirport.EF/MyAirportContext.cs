using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace glhm.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }
        //commentaire
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyAirport;Integrated Security=True");
        }
    }
}
