using GM.MyAirport.EF;
using System;
using System.Collections.Generic;

namespace MyAirport.EF
{
    /// <summary>
    /// Objet vol
    /// </summary>
    public class Vol
    {
        /// <summary>
        /// ID du vol
        /// </summary>
        public int VolId { get; set; }
        /// <summary>
        /// Compagnie assurant le vol
        /// </summary>
        public string Cie { get; set; } 
        /// <summary>
        /// Destination du vol
        /// </summary>
        public string? Des { get; set; }
        /// <summary>
        /// Date de départ du vol
        /// </summary>
        public DateTime Dhc { get; set; }
        /// <summary>
        /// Immatriculation du vol
        /// </summary>
        public string? Imm { get; set; }
        /// <summary>
        /// Ligne du vol
        /// </summary>
        public string Lig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Pkg { get; set; }
        /// <summary>
        /// Nombre de personnes sur le vol
        /// </summary>
        public int? Pax { get; set; }
        /// <summary>
        /// Référence à la classe bagage
        /// </summary>
        public IEnumerable<Bagage> Bagages { get; set; }

        /// <summary>
        /// Création d'un vol vide
        /// </summary>
        public Vol() { }

        /// <summary>
        /// Création d'un vol
        /// </summary>
        /// <param name="cie"></param>
        /// <param name="lig"></param>
        /// <param name="dhc"></param>
        public Vol(string cie, string lig, DateTime dhc)
        {
            Cie = cie;
            Lig = lig;
            Dhc = dhc;
            Bagages = new List<Bagage>(); 
        }
    }
}
