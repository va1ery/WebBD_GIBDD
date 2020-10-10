using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD_GIBDD.Models
{
    public class Position
    {
        public long ID { get; set; }
        public string NamePosition { get; set; }
        public int Salary { get; set; }
        public string Duties { get; set; }
        public string Requirements { get; set; }
    }
}
