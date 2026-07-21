using Microsoft.AspNetCore.Mvc;
using InventoryApi.Models;

namespace InventoryApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new()
        {
            new Product { Id = 1, Name = "Gaming Laptop", Category = "Electronics", Price = 1299.99m, Stock = 15 },
            new Product { Id = 2, Name = "Ergonomic Chair", Category = "Furniture", Price = 249.50m, Stock = 30 },
            new Product { Id = 3, Name = "Mechanical Keyboard", Category = "Electronics", Price = 89.99m, Stock = 50 }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll() => Ok(Products);

        [HttpGet("{id:int}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            return product == null ? NotFound(new { Message = $"Product with ID {id} not found." }) : Ok(product);
        }

        [HttpPost]
        public ActionResult<Product> Create([FromBody] Product newProduct)
        {
            newProduct.Id = Products.Max(p => p.Id) + 1;
            Products.Add(newProduct);
            return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] Product updatedProduct)
        {
            var existing = Products.FirstOrDefault(p => p.Id == id);
            if (existing == null) return NotFound();
            existing.Name = updatedProduct.Name;
            existing.Category = updatedProduct.Category;
            existing.Price = updatedProduct.Price;
            existing.Stock = updatedProduct.Stock;
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null) return NotFound();
            Products.Remove(product);
            return NoContent();
        }
    }
}
