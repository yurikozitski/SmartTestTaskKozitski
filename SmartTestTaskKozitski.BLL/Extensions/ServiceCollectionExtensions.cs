using Microsoft.Extensions.DependencyInjection;
using SmartTestTaskKozitski.BLL.Interfaces;
using SmartTestTaskKozitski.BLL.Security;
using SmartTestTaskKozitski.BLL.Services;
using SmartTestTaskKozitski.DAL.Interfaces;
using SmartTestTaskKozitski.DAL.Repositories;

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

        public static void AddSecurity(this IServiceCollection services)
        {
            services.AddSingleton<IApiKeyValidator, ApiKeyValidator>();
        }
    }
}
