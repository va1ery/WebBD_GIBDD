using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD_GIBDD.Models
{
    public class BrandAuto
    {
        public long ID { get; set; }
        public string CompanyManufacturer { get; set; }
        public string CountryManufacturer { get; set; }
        public string Name { get; set; }
        public DateTime StartProduction { get; set; }
        public DateTime EndProduction { get; set; }
        public string Specifications { get; set; }
        public string Description { get; set; }
    }
}
