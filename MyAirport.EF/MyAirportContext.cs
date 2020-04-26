using Microsoft.EntityFrameworkCore;
using MyAirport.EF;


namespace GM.MyAirport.EF
{
    /// <summary>
    /// Classe qui appelle les différentes méthodes de l'aéroport
    /// </summary>
    public class MyAirportContext : DbContext
    {
       //public static readonly ILoggerFactory MyAirportLoggerFactory = LoggerFactory.Create(builder => { builder.AddConsole(); });
        
        /// <summary>
        /// Référence à MyAirportContext
        /// </summary>
        /// <param name="options"></param>
        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options) { }

        /// <summary>
        /// Référence à la classe Vol
        /// </summary>
        public DbSet<Vol>? Vols { get; set; }

        /// <summary>
        /// Référence à la classe Bagage
        /// </summary>
        public DbSet<Bagage>? Bagages { get; set; }

       /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=MyAirportContext;Integrated Security=True");
            //optionsBuilder.UseLoggerFactory(MyAirportLoggerFactory);

        }*/

    }

}
