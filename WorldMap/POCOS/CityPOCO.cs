using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldMap.POCOS
{
    public class CityPOCO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fk_Country { get; set; }

        public virtual Country Country { get; set; }
    }
}