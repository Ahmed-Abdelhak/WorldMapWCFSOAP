using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorldMap.POCOS
{
    public class CountryPOCO
    {
        public CountryPOCO()
        {
            this.Cities = new HashSet<City>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}