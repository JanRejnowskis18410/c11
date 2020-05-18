using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DoctorDbContext()
        {

        }

        public DoctorDbContext(DbContextOptions options)
        : base (options)
        {

        }
    }
}
