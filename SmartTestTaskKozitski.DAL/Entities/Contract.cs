using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Entities
{
    public class Contract
    {
        public Guid Id { get; set; }

        public long ProductionFacilityCode { get; set; }

        public ProductionFacility ProductionFacility { get; set; } = null!;

        public long ProcessEquipmentTypeCode { get; set; }

        public ProcessEquipmentType ProcessEquipmentType { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
