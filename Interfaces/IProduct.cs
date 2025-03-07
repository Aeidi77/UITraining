using UITraining.Models.DB;
using UITraining.Models.DTO;

namespace UITraining.Interfaces
{
    public interface IProduct
    {
        public List<ProductDTO> Getlistproduct();
        public Product GetProductById(int id);
        public bool EditProduct(ProductDTO product);
        public bool DeleteProduct(int id);
        public bool AddProduct(ProductDTO product);

    }
}
