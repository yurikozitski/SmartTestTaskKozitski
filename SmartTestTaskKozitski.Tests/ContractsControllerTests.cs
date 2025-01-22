using Microsoft.AspNetCore.Mvc;
using SmartTestTaskKozitski.BLL.DTOs;
using SmartTestTaskKozitski.BLL.Services;
using SmartTestTaskKozitski.DAL.Data;
using SmartTestTaskKozitski.DAL.Repositories;
using SmartTestTaskKozitski.Tests.Helpers;
using SmartTestTaskKozitski.WebApi.Controllers;

namespace SmartTestTaskKozitski.Tests
{
    public class ContractsControllerTests
    {

        [Fact]
        public async Task GetAllAsync_ReturnsOkResult()
        {
            //Arrange
            using var context = new ApplicationContext(UnitTestHelper.GetUnitTestDbOptions());
            var contractRepository = new ContractRepository(context);
            var contractService = new ContractService(
                default!, 
                contractRepository, 
                UnitTestHelper.CreateMapperProfile());
            var contractController = new ContractsController(contractService);

            //Act
            var result = await contractController.GetAllAsync();

            //Assert
            Assert.IsType<OkObjectResult>(result.Result);
        }

        [Fact]
        public async Task GetAllAsync_ReturnsNotEmptyCollection()
        {
            //Arrange
            using var context = new ApplicationContext(UnitTestHelper.GetUnitTestDbOptions());
            var contractRepository = new ContractRepository(context);
            var contractService = new ContractService(
                default!,
                contractRepository,
                UnitTestHelper.CreateMapperProfile());
            var contractController = new ContractsController(contractService);

            //Act
            var result = await contractController.GetAllAsync();

            //Assert
            var okResult = result.Result as OkObjectResult;
            var contracts = okResult!.Value as IEnumerable<GetContractsDto>;

            Assert.NotEmpty(contracts!);
        }

        [Fact]
        public async Task GetAllAsync_ReturnsCollectionOfValidContracts()
        {
            //Arrange
            using var context = new ApplicationContext(UnitTestHelper.GetUnitTestDbOptions());
            var contractRepository = new ContractRepository(context);
            var contractService = new ContractService(
                default!,
                contractRepository,
                UnitTestHelper.CreateMapperProfile());
            var contractController = new ContractsController(contractService);

            //Act
            var result = await contractController.GetAllAsync();

            //Assert
            var okResult = result.Result as OkObjectResult;
            var contracts = okResult!.Value as IEnumerable<GetContractsDto>;

            Assert.All(contracts!, contract =>
            {
                Assert.False(string.IsNullOrEmpty(contract.ProductionFacilityName));
                Assert.False(string.IsNullOrEmpty(contract.ProcessEquipmentTypeName));
                Assert.InRange(contract.Quantity, 1, 100_000);
            });
        }

        [Fact]
        public async Task CreateAsync_ValidData_Produces201CodeResult()
        {
            //Arrange
            using var context = new ApplicationContext(UnitTestHelper.GetUnitTestDbOptions());

            var contractRepository = new ContractRepository(context);
            var facilityRepository = new ProductionFacilityRepository(context);
            var processEquipmentTypeRepository = new ProcessEquipmentTypeRepository(context);

            var contractValidator = new ContractValidator(
                facilityRepository,
                contractRepository,
                processEquipmentTypeRepository);

            var contractService = new ContractService(
                contractValidator,
                contractRepository,
                UnitTestHelper.CreateMapperProfile());

            var contractController = new ContractsController(contractService);

            var addContractDto = new AddContractDto()
            {
                FacilityCode = 2001L,
                ProcessEquipmentTypeCode = 1003L,
                Quantity = 10,
            };

            //Act
            var result = await contractController.CreateAsync(addContractDto);

            //Assert
            Assert.Equal(201, ((StatusCodeResult)result).StatusCode);
        }

        [Fact]
        public async Task CreateAsync_ValidData_CreatesContract()
        {
            //Arrange
            using var context = new ApplicationContext(UnitTestHelper.GetUnitTestDbOptions());

            var contractRepository = new ContractRepository(context);
            var facilityRepository = new ProductionFacilityRepository(context);
            var processEquipmentTypeRepository = new ProcessEquipmentTypeRepository(context);

            var contractValidator = new ContractValidator(
                facilityRepository,
                contractRepository,
                processEquipmentTypeRepository);

            var contractService = new ContractService(
                contractValidator,
                contractRepository,
                UnitTestHelper.CreateMapperProfile());

            var contractController = new ContractsController(contractService);

            var addContractDto = new AddContractDto()
            {
                FacilityCode = 2001L,
                ProcessEquipmentTypeCode = 1003L,
                Quantity = 10,
            };

            int contractsCountBefore = context.Contracts.Count();

            //Act
            _ = await contractController.CreateAsync(addContractDto);

            //Assert
            int contractsCountAfter = context.Contracts.Count();

            Assert.Equal(contractsCountBefore + 1, contractsCountAfter);
        }

        [Theory]
        [MemberData(nameof(AddContractDtoSInValid))]
        public async Task CreateAsync_InValidData_Produces400CodeResult(AddContractDto addContractDto)
        {
            //Arrange
            using var context = new ApplicationContext(UnitTestHelper.GetUnitTestDbOptions());

            var contractRepository = new ContractRepository(context);
            var facilityRepository = new ProductionFacilityRepository(context);
            var processEquipmentTypeRepository = new ProcessEquipmentTypeRepository(context);

            var contractValidator = new ContractValidator(
                facilityRepository,
                contractRepository,
                processEquipmentTypeRepository);

            var contractService = new ContractService(
                contractValidator,
                contractRepository,
                UnitTestHelper.CreateMapperProfile());

            var contractController = new ContractsController(contractService);

            //Act
            var result = await contractController.CreateAsync(addContractDto);

            //Assert
            Assert.Equal(400, ((BadRequestObjectResult)result).StatusCode);
        }

        public static IEnumerable<object[]> AddContractDtoSInValid =>
            new List<object[]>()
            {
                new object[]
                {
                    new AddContractDto()
                    {
                        FacilityCode = 2001L,
                        ProcessEquipmentTypeCode = 1003L,
                        Quantity = 1000,
                    },
                },
                new object[]
                {
                    new AddContractDto()
                    {
                        FacilityCode = 20001L,
                        ProcessEquipmentTypeCode = 1003L,
                        Quantity = 10,
                    },
                },
                new object[]
                {
                    new AddContractDto()
                    {
                        FacilityCode = 2001L,
                        ProcessEquipmentTypeCode = 1001L,
                        Quantity = 39,
                    },
                },
            };
    }
}
