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

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return Ok(Products);
        }

        // GET: api/products/1
        [HttpGet("{id:int}")]
        public ActionResult<Product> GetById(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { Message = $"Product with ID {id} was not found." });
            }
            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<Product> Create([FromBody] Product newProduct)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            newProduct.Id = Products.Max(p => p.Id) + 1;
            Products.Add(newProduct);

            return CreatedAtAction(nameof(GetById), new { id = newProduct.Id }, newProduct);
        }

        // PUT: api/products/1
        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody] Product updatedProduct)
        {
            var existingProduct = Products.FirstOrDefault(p => p.Id == id);
            if (existingProduct == null)
            {
                return NotFound(new { Message = $"Product with ID {id} was not found." });
            }

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Category = updatedProduct.Category;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.Stock = updatedProduct.Stock;

            return NoContent();
        }

        // DELETE: api/products/1
        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                return NotFound(new { Message = $"Product with ID {id} was not found." });
            }

            Products.Remove(product);
            return NoContent();
        }
    }
}
