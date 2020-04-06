using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;




namespace glhm.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }

         public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });

         public MyAirportContext(DbContextOptions options) : base (options)
         {

         }

        /*protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UseLoggerFactory(loggerFactory);
            //options.UseSqlServer(ConfigurationManager.ConnectionStrings["MyAirportDatabase"].ConnectionString);
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyAirport;Integrated Security=True");
        }*/

        

    }


}
