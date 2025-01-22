using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SmartTestTaskKozitski.BLL.Mapping;
using SmartTestTaskKozitski.DAL.Data;
using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.Tests.Helpers
{
    internal static class UnitTestHelper
    {
        public static DbContextOptions<ApplicationContext> GetUnitTestDbOptions()
        {
            var options = new DbContextOptionsBuilder<ApplicationContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

            using (var context = new ApplicationContext(options))
            {
                SeedData(context);
            }

            return options;
        }

        public static IMapper CreateMapperProfile()
        {
            var myProfile = new AutomapperProfile();
            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(myProfile));

            return new Mapper(configuration);
        }

        private static void SeedData(ApplicationContext context)
        {
            var processEquipmentTypes = new[]
            {
                new ProcessEquipmentType
                {
                    Id = new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"),
                    Specifications = new Specifications { Code = 1001L, Name = "TypeA", Area = 50 }
                },
                new ProcessEquipmentType
                {
                    Id = new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"),
                    Specifications = new Specifications { Code = 1002L, Name = "TypeB", Area = 75 }
                },
                new ProcessEquipmentType
                {
                    Id = new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"),
                    Specifications = new Specifications { Code = 1003L, Name = "TypeC", Area = 100 }
                },
                new ProcessEquipmentType
                {
                    Id = new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"),
                    Specifications = new Specifications { Code = 1004L, Name = "TypeD", Area = 125 }
                },
                new ProcessEquipmentType
                {
                    Id = new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"),
                    Specifications = new Specifications { Code = 1005L, Name = "TypeE", Area = 150 }
                }
            };

            context.ProcessEquipmentTypes.AddRange(processEquipmentTypes);

            var productionFacilities = new[]
            {
                new ProductionFacility
                {
                    Id = new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"),
                    Specifications = new Specifications { Code = 2001L, Name = "FacilityA", Area = 2000 }
                },
                new ProductionFacility
                {
                    Id = new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"),
                    Specifications = new Specifications { Code = 2002L, Name = "FacilityB", Area = 3000 }
                },
                new ProductionFacility
                {
                    Id = new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"),
                    Specifications = new Specifications { Code = 2003L, Name = "FacilityC", Area = 4000 }
                },
                new ProductionFacility
                {
                    Id = new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"),
                    Specifications = new Specifications { Code = 2004L, Name = "FacilityD", Area = 5000 }
                },
                new ProductionFacility
                {
                    Id = new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"),
                    Specifications = new Specifications { Code = 2005L, Name = "FacilityE", Area = 6000 }
                }
            };

            context.ProductionFacilities.AddRange(productionFacilities);

            var contracts = new[]
            {
                new Contract
                {
                    Id = new Guid("1a2b3c4d-5e6f-7a8b-9c0d-1e2f3a4b5c6d"),
                    ProductionFacilityId = new Guid("b0fc118d-527d-41b1-9b1c-3a74bdc8dd2a"),
                    ProcessEquipmentTypeId = new Guid("d1e59328-7e39-4fe7-9b54-768cebbeb324"),
                    Quantity = 2
                },
                new Contract
                {
                    Id = new Guid("2a3b4c5d-6e7f-8a9b-0c1d-2e3f4a5b6c7d"),
                    ProductionFacilityId = new Guid("241a2aa6-0bf4-442a-9058-9db7c2355f96"),
                    ProcessEquipmentTypeId = new Guid("4cd6e57c-d7ae-42ef-9d6e-74a49dbd4223"),
                    Quantity = 2
                },
                new Contract
                {
                    Id = new Guid("3a4b5c6d-7e8f-9a0b-1c2d-3e4f5a6b7c8d"),
                    ProductionFacilityId = new Guid("3c663d1b-f9f9-47d6-a9ed-e3ab2a9b2895"),
                    ProcessEquipmentTypeId = new Guid("7e02cfa1-5ec5-4507-8c68-d471cbf6e9c5"),
                    Quantity = 3
                },
                new Contract
                {
                    Id = new Guid("4a5b6c7d-8e9f-0a1b-2c3d-4e5f6a7b8c9d"),
                    ProductionFacilityId = new Guid("2342040a-9c7a-4537-9bfc-6b1895cd711f"),
                    ProcessEquipmentTypeId = new Guid("f9215bfc-58cc-494e-a0db-8c42c7c88f64"),
                    Quantity = 1
                },
                new Contract
                {
                    Id = new Guid("5a6b7c8d-9e0f-1a2b-3c4d-5e6f7a8b9c0d"),
                    ProductionFacilityId = new Guid("e3c1a636-05cf-4b7f-8f16-7d4bd7416e67"),
                    ProcessEquipmentTypeId = new Guid("7a4de707-61a4-4d7f-94e5-4e1dd6f442d4"),
                    Quantity = 3
                }
            };

            context.Contracts.AddRange(contracts);
            context.SaveChanges();
        }
    }
}
