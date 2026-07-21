using InventoryApi.Models;

namespace InventoryApi.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new();

        public IEnumerable<Product> GetAllProducts() => _products;

        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public Product AddProduct(Product product)
        {
            product.Id = _products.Count > 0 ? _products.Max(p => p.Id) + 1 : 1;
            _products.Add(product);
            return product;
        }

        public bool DeleteProduct(int id)
        {
            var p = GetProductById(id);
            if (p == null) return false;
            _products.Remove(p);
            return true;
        }
    }
}
