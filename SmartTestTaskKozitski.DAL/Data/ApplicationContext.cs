using Microsoft.EntityFrameworkCore;
using SmartTestTaskKozitski.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<ProcessEquipmentType> ProcessEquipmentTypes { get; set; }

        public DbSet<ProductionFacility> ProductionFacilities { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProcessEquipmentType>(pe =>
            {
                pe.HasKey(p => p.Specifications.Code);

                pe.OwnsOne(p => p.Specifications, s =>
                {
                    s.Property(sp => sp.Code).HasColumnName("Code");
                    s.Property(sp => sp.Name).HasColumnName("Name");
                    s.Property(sp => sp.Area).HasColumnName("Area");
                });
            });

            modelBuilder.Entity<ProductionFacility>(pf =>
            {
                pf.HasKey(p => p.Specifications.Code);

                pf.OwnsOne(p => p.Specifications, s =>
                {
                    s.Property(sp => sp.Code).HasColumnName("Code");
                    s.Property(sp => sp.Name).HasColumnName("Name");
                    s.Property(sp => sp.Area).HasColumnName("Area");
                });
            });

            modelBuilder.Entity<Contract>(c =>
            {
                c.HasKey(c => c.Id);

                c.HasOne(c => c.ProductionFacility)
                    .WithOne()
                    .HasForeignKey<Contract>(c => c.ProductionFacilityCode);

                c.HasOne(c => c.ProcessEquipmentType)
                    .WithOne()
                    .HasForeignKey<Contract>(c => c.ProcessEquipmentTypeCode);
            });
        }
    }
}
