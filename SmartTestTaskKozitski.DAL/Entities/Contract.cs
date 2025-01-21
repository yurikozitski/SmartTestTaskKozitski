using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Entities
{
    public class Contract : BaseEntity
    {
        public Guid ProductionFacilityId { get; set; }

        public ProductionFacility ProductionFacility { get; set; } = null!;

        public Guid ProcessEquipmentTypeId { get; set; }

        public ProcessEquipmentType ProcessEquipmentType { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
