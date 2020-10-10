using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace BD_GIBDD.Models
{
    public class Auto
    {
        public long ID { get; set; }
        public int RegNum { get; set; }
        public string NumberCarBody { get; set; }
        public int EngineNumber { get; set; }
        public DateTime DateSheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public string COLOR { get; set; }
        public string TechInspection { get; set; }
        public DateTime DateTechInspection { get; set; }
        public string Description { get; set; }
        public DbSet<BrandAuto> BrandAutoID { get; set; }
        public DbSet<Staff> StaffID { get; set; }
        public DbSet<Driver> DriverID { get; set; }

    }
}
