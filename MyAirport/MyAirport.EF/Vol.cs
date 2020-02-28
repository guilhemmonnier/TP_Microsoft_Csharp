﻿using System;
using System.Collections.Generic;
using System.Text;

namespace glhm.MyAirport.EF
{
    public class Vol
    {
        public int VolId { get; set; }
        public String Cie { get; set; }
        public string Lig { get; set; }
        public DateTime Dhc { get; set; }
        public string Pkg { get; set; }
        public string Imm { get; set; }
        public int Pax { get; set; }
        public string Des { get; set; }

        public List<Bagage> Bagages { get; } = new List<Bagage>();
    }
}
