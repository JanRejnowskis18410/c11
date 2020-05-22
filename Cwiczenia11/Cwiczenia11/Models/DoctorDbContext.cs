using Cwiczenia11.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Models
{
    public class DoctorDbContext : DbContext
    {
        public DbSet<Doctor> Doctor { get; set; }

        public DoctorDbContext()
        {

        }

        public DoctorDbContext(DbContextOptions options)
        : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new DoctorEfConfiguration());

            modelBuilder.ApplyConfiguration(new MedicamentEfConfiguration());

            modelBuilder.ApplyConfiguration(new PatientEfConfiguration());

            modelBuilder.ApplyConfiguration(new PrescriptionEfConfiguration());

            modelBuilder.ApplyConfiguration(new Prescription_MedicamentEfConfiguration());

            DumpSeedDatabase(modelBuilder);
        }

        protected void DumpSeedDatabase(ModelBuilder modelBuilder)
        {
            var patients = new List<Patient>();
            patients.Add(new Patient { IdPatient = 1, Birthdate = DateTime.Parse("1999-01-01"), FirstName = "Jan", LastName = "Kowalski" });
            modelBuilder.Entity<Patient>()
                        .HasData(patients);

            var doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Zygmunt", LastName = "Lekarz", Email = "zibi@gmail.com" });
            modelBuilder.Entity<Doctor>()
                        .HasData(doctors);

            modelBuilder.Entity<Medicament>()
                        .HasData(new Medicament { IdMedicament = 1, Name = "Xanax", Description = "Xanax działa uspokajająco, przeciwdrgawkowo i nasennie, wycisza i może powodować zobojętnienie.", Type = "Antydepresant" });

            modelBuilder.Entity<Prescription>()
                        .HasData(new Prescription { IdPrescription = 1, Date = DateTime.Parse("2020-01-01"), DueDate = DateTime.Parse("2020-01-03"), IdPatient = 1, IdDoctor = 1 });

            modelBuilder.Entity<Prescription_Medicament>()
                        .HasData(new Prescription_Medicament { IdPrescription = 1, IdMedicament = 1, Details = "Używać w razie napadów lęku" });
        }
    } 
}
