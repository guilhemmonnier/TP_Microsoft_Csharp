using System;

namespace glhm.MyAirport.EF
{
    public class Bagage
    {
        
        public int BagageId { get; set; }
        
       
       

        public string Code_Iata { get; set; }
        public DateTime Date_Creation { get; set; }
        public char Classe { get; set; }
        public Boolean Prioritaire { get; set; }
        public char Sta { get; set; }
        public string Ssur { get; set; }
        public string Destination { get; set; }

        public string Escale { get; set; }

        //Foreign Key
        public int? VolId { get; set; }
        public Vol Vol { get; set; }
    }
}
