using SmartTestTaskKozitski.BLL.DTOs;
using SmartTestTaskKozitski.BLL.Interfaces;
using System;
using System.Collections.Generic;
using SmartTestTaskKozitski.DAL.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmartTestTaskKozitski.DAL.Interfaces;
using SmartTestTaskKozitski.BLL.Exceptions;

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
            ProductionFacility? facility = default;
            IEnumerable<Contract>? facilityContracts = default;
            ProcessEquipmentType? equipmentType = default;

            long contractFacilityCode = contract.ProductionFacility.Specifications.Code;
            long contractProcessEquipmentTypeCode = contract.ProcessEquipmentType.Specifications.Code;

            try
            {
                facility = await this.facilityRepository.GetByCodeAsync(contractFacilityCode);
                facilityContracts = await this.contractRepository.GetByFacilityCodeAsync(contractFacilityCode);
                equipmentType = await this.processEquipmentTypeRepository.GetByCodeAsync(contractProcessEquipmentTypeCode);
            }
            catch (InvalidOperationException)
            {
                throw new InvalidCodeException(contractFacilityCode, contractProcessEquipmentTypeCode);
            }

            int facilityArea = facility!.Specifications.Area;
            int usedFacilityArea = facilityContracts!.Sum(x => x.Quantity * x.ProcessEquipmentType.Specifications.Area);

            int contractArea = contract.Quantity * equipmentType!.Specifications.Area;
            int freeArea = facilityArea - usedFacilityArea;

            return contractArea <= freeArea;
        }
    }
}
