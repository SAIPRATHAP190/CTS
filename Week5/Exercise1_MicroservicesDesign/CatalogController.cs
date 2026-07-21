using Microsoft.AspNetCore.Mvc;

namespace CatalogService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CatalogController : ControllerBase
    {
        private static readonly List<CatalogItem> CatalogItems = new()
        {
            new CatalogItem { Id = 101, Name = "Microservice Architecture Book", Price = 49.99m, QuantityInStock = 20 },
            new CatalogItem { Id = 102, Name = "Docker & Kubernetes Handbook", Price = 39.99m, QuantityInStock = 50 }
        };

        [HttpGet]
        public IActionResult GetItems() => Ok(CatalogItems);

        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var item = CatalogItems.FirstOrDefault(x => x.Id == id);
            return item == null ? NotFound() : Ok(item);
        }
    }

    public class CatalogItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
