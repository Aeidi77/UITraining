using static UITraining.Models.GeneralStatus;
using UITraining.Models.DB;

namespace UITraining.Models.DTO
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public GeneralStatusData ProductStatus { get; set; }
        public string SupplierName { get; set; }
        public int IdSupplier { get; set; }
       
    }
}
