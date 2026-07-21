using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private static readonly List<CustomerOrder> Orders = new();

        [HttpGet]
        public IActionResult GetOrders() => Ok(Orders);

        [HttpPost]
        public IActionResult CreateOrder([FromBody] CreateOrderDto dto)
        {
            var order = new CustomerOrder
            {
                OrderId = Guid.NewGuid(),
                ProductId = dto.ProductId,
                Quantity = dto.Quantity,
                OrderDate = DateTime.UtcNow,
                Status = "Placed"
            };

            Orders.Add(order);
            return CreatedAtAction(nameof(GetOrders), new { id = order.OrderId }, order);
        }
    }

    public class CustomerOrder
    {
        public Guid OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    public class CreateOrderDto
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
