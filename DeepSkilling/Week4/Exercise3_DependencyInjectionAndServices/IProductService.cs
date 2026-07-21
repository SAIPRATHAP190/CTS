using InventoryApi.Models;

namespace InventoryApi.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts();
        Product? GetProductById(int id);
        Product AddProduct(Product product);
        bool DeleteProduct(int id);
    }
}
