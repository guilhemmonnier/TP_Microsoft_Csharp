﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System.Configuration;



namespace glhm.MyAirport.EF
{
    public class Program
    {
        public static readonly ILoggerFactory MyLoggerFactory= LoggerFactory.Create(builder => { builder.AddConsole(); });

       

        static void Main(string[] args)
        {
            System.Console.WriteLine("MyAirport project bonjour!!");
            var connectionString = ConfigurationManager.ConnectionStrings["MyAirportDatabase"].ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<MyAirportContext>()
           .UseLoggerFactory(MyLoggerFactory)
           .UseSqlServer(connectionString);

            using (var db = new MyAirportContext(optionsBuilder.Options))
            {
                // Create
                Console.WriteLine("Création du vol LH1232");
                Vol v1 = new Vol
                {
                    Cie = "LH",
                    Des = "BKK",
                    Dhc = Convert.ToDateTime("14/01/2020 16:45"),
                    Imm = "RZ62",
                    Lig = "1232",
                    Pkg = "R52",
                    Pax = 238
                };
                db.Add(v1);

                Console.WriteLine("Creation vol SQ333");
                Vol v2 = new Vol
                {
                    Cie = "SK",
                    Des = "CDG",
                    Dhc = Convert.ToDateTime("14/01/2020 18:20"),
                    Imm = "TG43",
                    Lig = "333",
                    Pkg = "R51",
                    Pax = 423
                };
                db.Add(v2);

                Console.WriteLine("creation du bagage 012387364501");
                Bagage b1 = new Bagage
                {
                    Classe = "Y",
                    CodeIata = "012387364501",
                    DateCreation = Convert.ToDateTime("14/01/2020 12:52"),
                    Destination = "BEG"
                };
                db.Add(b1);

                db.SaveChanges();
                Console.ReadLine();

                // Read
                Console.WriteLine("Voici la liste des vols disponibles");
                var vol = db.Vols
                    .OrderBy(v => v.Cie);
                foreach (var v in vol)
                {
                    Console.WriteLine($"Le vol {v.Cie}{v.Lig} N° {v.VolId} a destination de {v.Des} part à {v.Dhc} heure");
                }
                Console.ReadLine();

                // Update
                Console.WriteLine($"Le bagage {b1.BagageID} est modifié pour être rattaché au vol {v1.VolId} => {v1.Cie}{v1.Lig}");
                b1.VolId = v1.VolId;
                db.SaveChanges();
                Console.ReadLine();

                // Delete vol et bagages du vol
                Console.WriteLine($"Suppression du vol {v1.VolId} => {v1.Cie}{v1.Lig}");
                db.Remove(v1);
                db.SaveChanges();
                Console.ReadLine();
    


            }
        }
    }
}
