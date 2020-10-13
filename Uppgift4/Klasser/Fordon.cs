using System;
using System.Collections.Generic;

namespace Klasser
{
    public abstract class Fordon
    {
        public string Model { get; set; }
        public string RegNr { get; set; }
        public int MilesTravelled { get; set; }
        public DateTime Registered { get; set; }
        //public List<Fordon> FordonLista { get; set; }
    }
}
