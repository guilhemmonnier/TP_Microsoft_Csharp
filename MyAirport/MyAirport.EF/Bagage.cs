using System;

namespace glhm.MyAirport.EF
{
    public class Bagage
    {
        
        public int BagageID { get; set; }
        
       
       

        public string CodeIata { get; set; }
        public DateTime DateCreation { get; set; }
        public String Classe { get; set; }
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
