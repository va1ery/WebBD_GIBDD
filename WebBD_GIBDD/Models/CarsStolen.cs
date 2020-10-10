using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD_GIBDD.Models
{
    public class CarsStolen
    {
        public long ID { get; set; }
        public DateTime DateStolen { get; set; }
        public DateTime DateAppeal { get; set; }
        public string Circumstances { get; set; }
        public Boolean MarkFind { get; set; }
        public DateTime DateFind { get; set; }
        public DbSet<Staff> StaffID { get; set; }
        public DbSet<Auto> AutoID { get; set; }
        public DbSet<Driver> DriverID { get; set; }

    }
}
