using Microsoft.Extensions.DependencyInjection;
using SmartTestTaskKozitski.BLL.Interfaces;
using SmartTestTaskKozitski.BLL.Services;
using SmartTestTaskKozitski.DAL.Interfaces;
using SmartTestTaskKozitski.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IContractRepository, ContractRepository>();
            services.AddScoped<IProcessEquipmentTypeRepository, ProcessEquipmentTypeRepository>();            
            services.AddScoped<IProductionFacilityRepository, ProductionFacilityRepository>();            
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IContractService, ContractService>();
            services.AddScoped<IContractValidator, ContractValidator>();
        }
    }
}
