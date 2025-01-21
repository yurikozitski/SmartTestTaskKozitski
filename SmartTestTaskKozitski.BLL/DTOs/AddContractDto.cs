using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.DTOs
{
    public class AddContractDto
    {
        public long FacilityCode { get; set; }

        public long ProcessEquipmentTypeCode { get; set; }

        public int Quantity { get; set; }
    }
}
