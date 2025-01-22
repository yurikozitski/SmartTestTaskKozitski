using AutoMapper;
using SmartTestTaskKozitski.BLL.DTOs;
using SmartTestTaskKozitski.BLL.Exceptions;
using SmartTestTaskKozitski.BLL.Interfaces;
using SmartTestTaskKozitski.DAL.Entities;
using SmartTestTaskKozitski.DAL.Interfaces;

namespace SmartTestTaskKozitski.BLL.Services
{
    public class ContractService : IContractService
    {
        private readonly IContractValidator contractValidator;
        private readonly IContractRepository contractRepository;
        private readonly IMapper mapper;

        public ContractService(IContractValidator _contractValidator,
            IContractRepository _contractRepository, 
            IMapper _mapper)
        {
            this.contractValidator = _contractValidator;
            this.contractRepository = _contractRepository;
            this.mapper = _mapper;
        }

        public async Task AddAsync(AddContractDto contractDto)
        {
            var contract = this.mapper.Map<AddContractDto, Contract>(contractDto);

            if (!await this.contractValidator.IsValid(contract))
            {
                throw new SpaceException("No free space to place this contract");
            }

            await this.contractRepository.AddAsync(contract);
        }

        public async Task<IEnumerable<GetContractsDto>> GetAllAsync(int take = 100, int skip = 0)
        {
            var contractEntities = await this.contractRepository.GetAllAsync(take, skip);
            return this.mapper.Map<IEnumerable<Contract>, IEnumerable<GetContractsDto>>(contractEntities);
        }
    }
}
