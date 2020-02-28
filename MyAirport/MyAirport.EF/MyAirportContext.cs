using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;




namespace glhm.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }

        public static readonly ILoggerFactory MyLoggerFactory= LoggerFactory.Create(builder => { builder.AddConsole(); });
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseLoggerFactory(MyLoggerFactory);
            options.UseSqlServer(ConfigurationManager.ConnectionStrings["MyAirportDatabase"].ConnectionString);
            //options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyAirport;Integrated Security=True");
        }

        /*public MyAirportContext(DbContextOptions<TContext>)
        {

        }*/
       

    }


}
