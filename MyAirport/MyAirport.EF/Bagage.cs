using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace glhm.MyAirport.EF
{
    /// <summary>
    /// Objet bagage
    /// </summary>
    public class Bagage
    {
        
        
        /// <summary>
        /// Clé primaire de l'objet bagage
        /// </summary>
        public int BagageID { get; set; }
        /// <summary>
        /// CodeIata du bagage
        /// </summary>
        public string CodeIata { get; set; }
        /// <summary>
        ///  Date a laquelle le bagage a été créer par la compagnie
        /// </summary>
        [Column("DateDeCreation")]
        public DateTime DateCreation { get; set; }
        public String? Classe { get; set; }
        public Boolean? Prioritaire { get; set; }
        public char? Sta { get; set; }
        public string? Ssur { get; set; }
        public string? Destination { get; set; }

        public string? Escale { get; set; }

        //Foreign Key
        public int? VolId { get; set; }
        public Vol Vol { get; set; }
    }
}
