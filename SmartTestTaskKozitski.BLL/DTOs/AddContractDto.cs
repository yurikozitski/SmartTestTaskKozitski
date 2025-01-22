using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.BLL.DTOs
{
    public class AddContractDto
    {
        [Required]
        public long FacilityCode { get; set; }

        [Required]
        public long ProcessEquipmentTypeCode { get; set; }

        [Required]
        [Range(1, 100_000)]
        public int Quantity { get; set; }
    }
}
