using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Entities
{
    public class ProcessEquipmentType : BaseEntity
    {
        public Specifications Specifications { get; set; } = null!;
    }
}
