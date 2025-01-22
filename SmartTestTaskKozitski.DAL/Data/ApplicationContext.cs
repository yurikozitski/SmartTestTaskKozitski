using Microsoft.EntityFrameworkCore;
using SmartTestTaskKozitski.DAL.Entities;

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
            Guid TypeAId = new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324");
            Guid TypeBId = new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223");
            Guid TypeCId = new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5");
            Guid TypeDId = new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64");
            Guid TypeEId = new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4");

            Guid FacilityAId = new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a");
            Guid FacilityBId = new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96");
            Guid FacilityCId = new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895");
            Guid FacilityDId = new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f");
            Guid FacilityEId = new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67");

            modelBuilder.Entity<ProcessEquipmentType>(pe =>
            {
                pe.HasKey(p => p.Id);

                pe.OwnsOne(p => p.Specifications, s =>
                {
                    s.Property(sp => sp.Code).HasColumnName("Code");
                    s.Property(sp => sp.Name).HasColumnName("Name");
                    s.Property(sp => sp.Area).HasColumnName("Area");
                    s.HasIndex(sp => sp.Code).IsUnique();

                    s.HasData(
                        new { ProcessEquipmentTypeId = TypeAId, Code = 1001L, Name = "TypeA", Area = 50 },
                        new { ProcessEquipmentTypeId = TypeBId, Code = 1002L, Name = "TypeB", Area = 75 },
                        new { ProcessEquipmentTypeId = TypeCId, Code = 1003L, Name = "TypeC", Area = 100 },
                        new { ProcessEquipmentTypeId = TypeDId, Code = 1004L, Name = "TypeD", Area = 125 },
                        new { ProcessEquipmentTypeId = TypeEId, Code = 1005L, Name = "TypeE", Area = 150 }
                    );
                });

                pe.HasData(
                    new { Id = TypeAId },
                    new { Id = TypeBId },
                    new { Id = TypeCId },
                    new { Id = TypeDId },
                    new { Id = TypeEId }
                );
            });

            modelBuilder.Entity<ProductionFacility>(pf =>
            {
                pf.HasKey(p => p.Id);

                pf.OwnsOne(p => p.Specifications, s =>
                {
                    s.Property(sp => sp.Code).HasColumnName("Code");
                    s.Property(sp => sp.Name).HasColumnName("Name");
                    s.Property(sp => sp.Area).HasColumnName("Area");
                    s.HasIndex(sp => sp.Code).IsUnique();

                    s.HasData(
                        new { ProductionFacilityId = FacilityAId, Code = 2001L, Name = "FacilityA", Area = 2000 },
                        new { ProductionFacilityId = FacilityBId, Code = 2002L, Name = "FacilityB", Area = 3000 },
                        new { ProductionFacilityId = FacilityCId, Code = 2003L, Name = "FacilityC", Area = 4000 },
                        new { ProductionFacilityId = FacilityDId, Code = 2004L, Name = "FacilityD", Area = 5000 },
                        new { ProductionFacilityId = FacilityEId, Code = 2005L, Name = "FacilityE", Area = 6000 }
                    );
                });

                pf.HasData(
                    new { Id = FacilityAId },
                    new { Id = FacilityBId },
                    new { Id = FacilityCId },
                    new { Id = FacilityDId },
                    new { Id = FacilityEId }
                );
            });

            modelBuilder.Entity<Contract>(c =>
            {
                c.HasKey(c => c.Id);

                c.HasOne(c => c.ProductionFacility)
                    .WithMany()
                    .HasForeignKey(c => c.ProductionFacilityId)
                    .OnDelete(DeleteBehavior.Restrict);

                c.HasOne(c => c.ProcessEquipmentType)
                    .WithMany()
                    .HasForeignKey(c => c.ProcessEquipmentTypeId)
                    .OnDelete(DeleteBehavior.Restrict);

                c.HasData(
                    new { Id = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"), ProductionFacilityId = FacilityAId, ProcessEquipmentTypeId = TypeAId, Quantity = 2 },
                    new { Id = new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"), ProductionFacilityId = FacilityBId, ProcessEquipmentTypeId = TypeBId, Quantity = 2 },
                    new { Id = new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"), ProductionFacilityId = FacilityCId, ProcessEquipmentTypeId = TypeCId, Quantity = 3 },
                    new { Id = new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"), ProductionFacilityId = FacilityDId, ProcessEquipmentTypeId = TypeDId, Quantity = 1 },
                    new { Id = new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"), ProductionFacilityId = FacilityEId, ProcessEquipmentTypeId = TypeEId, Quantity = 3 }
                );
            });
        }
    }
}
