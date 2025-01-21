using SmartTestTaskKozitski.BLL.DTOs;
using SmartTestTaskKozitski.BLL.Interfaces;
using System;
using System.Collections.Generic;
using SmartTestTaskKozitski.DAL.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTestTaskKozitski.DAL.Interfaces;

namespace SmartTestTaskKozitski.BLL.Services
{
    public class ContractValidator : IContractValidator
    {
        private readonly IProductionFacilityRepository facilityRepository;
        private readonly IContractRepository contractRepository;
        private readonly IProcessEquipmentTypeRepository processEquipmentTypeRepository;

        public ContractValidator(IProductionFacilityRepository _facilityRepository, 
            IContractRepository contractRepository,
            IProcessEquipmentTypeRepository _processEquipmentTypeRepository)
        {
            this.facilityRepository = _facilityRepository;
            this.contractRepository = contractRepository;
            this.processEquipmentTypeRepository = _processEquipmentTypeRepository;
        }

        public async Task<bool> IsValid(Contract contract)
        {
            var facility = await this.facilityRepository.GetByCodeAsync(contract.ProductionFacility.Specifications.Code);
            int facilityArea = facility.Specifications.Area;

            var facilityContracts = await this.contractRepository.GetByFacilityCodeAsync(contract.ProductionFacility.Specifications.Code);
            int usedFacilityArea = facilityContracts.Sum(x => x.Quantity * x.ProcessEquipmentType.Specifications.Area);

            var equipmentType = await this.processEquipmentTypeRepository.GetByCodeAsync(contract.ProcessEquipmentType.Specifications.Code);
            int contractArea = contract.Quantity * equipmentType.Specifications.Area;

            int freeArea = facilityArea - usedFacilityArea;

            return contractArea <= freeArea;
        }
    }
}
