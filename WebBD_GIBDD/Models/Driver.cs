using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace BD_GIBDD.Models
{
    public class Driver
    {
        public long ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string PassportData { get; set; }
        public int DriversLicenseNum { get; set; }
        public DateTime DateIssueCertificate { get; set; }
        public DateTime EndDateCertificate { get; set; }
        public char CategoryCertificate { get; set; }
        public string Description { get; set; }
        public DbSet<Staff> StaffID { get; set; }


    }
}
