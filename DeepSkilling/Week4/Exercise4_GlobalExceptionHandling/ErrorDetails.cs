using System.Text.Json;

namespace InventoryApi.Middleware
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; } = string.Empty;
        public string? Detail { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        public override string ToString() => JsonSerializer.Serialize(this);
    }
}
