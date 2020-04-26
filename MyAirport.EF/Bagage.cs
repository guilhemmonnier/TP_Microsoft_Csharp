
using MyAirport.EF;
using System;
using System.Collections.Generic;
using System.Text;

namespace GM.MyAirport.EF
{
    /// <summary>
    /// Objet Bagage
    /// </summary>
    public class Bagage
    {
        /// <summary>
        /// ID du bagage (clef primaire)
        /// </summary>
        public int BagageId { get; set; }
        /// <summary>
        /// Vol associé au bagage
        /// </summary>
        public int? VolId { get; set; }
        /// <summary>
        /// CoddeIata du bagage unique à un instant t
        /// </summary>
        public string CodeIata { get; set; }
        /// <summary>
        /// Date à laquelle le bagage a été créé 
        /// </summary>
        public DateTime DateCreation { get; set; }

        /// <summary>
        /// Propriété de navigation
        /// </summary>
        public Vol? Vol { get; set; }

        /// <summary>
        /// Classe du passager 
        /// </summary>
        public string? Classe { get; set; }
        /// <summary>
        /// Définir la priorité des passsagers lors de l'embarquement
        /// Définir la priorité des passsagers lors de l'embarquement
        /// </summary>
        public bool? Prioritaire { get; set; }
        /// <summary>
        /// Statut du bagage
        /// </summary>
        public string? Sta { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string? Ssur { get; set; }
        /// <summary>
        /// Destination du vol
        /// </summary>
        public string? Destination { get; set; }
        /// <summary>
        /// Escale si elle existe
        /// </summary>
        public string? Escale { get; set; }

        /// <summary>
        /// Création d'un bagage vide afin de pouvoir initialiser les bagages à null lors de la création d'un vol
        /// </summary>
        public Bagage() { }

        /// <summary>
        /// Création d'un bagage
        /// </summary>
        public Bagage(string codeIata, DateTime dateCreation)
        {
            CodeIata = codeIata;
            DateCreation = dateCreation;
        }

    }
}
