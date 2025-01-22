using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SmartTestTaskKozitski.BLL.DTOs;
using SmartTestTaskKozitski.BLL.Exceptions;
using SmartTestTaskKozitski.BLL.Interfaces;
using SmartTestTaskKozitski.DAL.Entities;

namespace SmartTestTaskKozitski.WebApi.Controllers
{
    [Route("api/contracts")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public class ContractsController : ControllerBase
    {
        private readonly IContractService contractService;

        public ContractsController(IContractService _contractService)
        {
            this.contractService = _contractService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<GetContractsDto>>> GetAllAsync()
        {
            var result = await this.contractService.GetAllAsync();
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> CreateAsync([FromBody] AddContractDto addContractDto)
        {
            try
            {
                await this.contractService.AddAsync(addContractDto);
            }
            catch (ContractException ex)
            {
                return BadRequest(ex.Message);
            }

            return StatusCode(StatusCodes.Status201Created);
        }
    }
}
