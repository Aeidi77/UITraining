using static UITraining.Models.GeneralStatus;

namespace UITraining.Models.DTO
{
    public class SupplierDTO
    {
        public int Id { get; set; }
        public string NameSupplier { get; set; }
        public string SupplierAddres { get; set; }
        public GeneralStatusData SupplierStatus { get; set; }
    }
}
