﻿using GM.MyAirport.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace My.Airport.EF
{
        class MyAirportContextFactory : IDesignTimeDbContextFactory<MyAirportContext>
        {
            public MyAirportContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<MyAirportContext>();
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MyAirportContext;Integrated Security=True");
                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder
                        .AddFilter("Microsoft", LogLevel.Debug)
                        .AddFilter("System", LogLevel.Warning);
                });
                optionsBuilder.UseLoggerFactory(loggerFactory);
                return new MyAirportContext(optionsBuilder.Options);
            }
        }
    
}
