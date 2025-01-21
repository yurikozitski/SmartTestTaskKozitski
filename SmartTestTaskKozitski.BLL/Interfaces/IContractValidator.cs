using SmartTestTaskKozitski.BLL.DTOs;
using System;
using System.Collections.Generic;
using SmartTestTaskKozitski.DAL.Entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.Interfaces
{
    public interface IContractValidator
    {
        Task<bool> IsValid(Contract contract);
    }
}
