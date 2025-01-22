using Microsoft.EntityFrameworkCore;

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
