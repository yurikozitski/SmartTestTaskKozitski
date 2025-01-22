namespace SmartTestTaskKozitski.BLL.DTOs
{
    public class GetContractsDto
    {
        public string ProductionFacilityName { get; set; } = null!;

        public string ProcessEquipmentTypeName { get; set; } = null!;

        public int Quantity { get; set; }
    }
}
