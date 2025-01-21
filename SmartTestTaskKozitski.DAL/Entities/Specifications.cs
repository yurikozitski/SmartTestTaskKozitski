using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartTestTaskKozitski.DAL.Entities
{
    [Owned]
    public class Specifications
    {
        public long Code { get; set; }

        public string Name { get; set; } = null!;

        public int Area { get; set; }
    }
}
