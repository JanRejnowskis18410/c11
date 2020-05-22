using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Configurations
{
    public class DoctorEfConfiguration : IEntityTypeConfiguration<Doctor>
    {
        public void Configure(EntityTypeBuilder<Doctor> builder)
        {
            builder.HasKey(e => e.IdDoctor);

            builder.Property(e => e.FirstName)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(e => e.LastName)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.Property(e => e.Email)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasMany(e => e.Prescriptions)
                  .WithOne(p => p.Doctor)
                  .HasForeignKey(p => p.IdDoctor);
        }
    }
}
