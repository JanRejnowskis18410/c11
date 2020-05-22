using Cwiczenia11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cwiczenia11.Configurations
{
    public class Prescription_MedicamentEfConfiguration : IEntityTypeConfiguration<Prescription_Medicament>
    {
        public void Configure(EntityTypeBuilder<Prescription_Medicament> builder)
        {
            builder.Property(e => e.Details)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasKey(e => new { e.IdPrescription, e.IdMedicament });

            builder.HasOne(e => e.Medicament)
                   .WithMany(m => m.Prescription_Medicaments)
                   .HasForeignKey(e => e.IdMedicament);

            builder.HasOne(e => e.Prescription)
                   .WithMany(p => p.Prescription_Medicaments)
                   .HasForeignKey(e => e.IdPrescription);
        }
    }
}
