using System.Net.Http.Json;

namespace OrderService.Services
{
    public class CatalogHttpClient
    {
        private readonly HttpClient _httpClient;

        public CatalogHttpClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CatalogProductDto?> GetProductByIdAsync(int productId)
        {
            try
            {
                var response = await _httpClient.GetAsync($"/api/catalog/{productId}");
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CatalogProductDto>();
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }

    public class CatalogProductDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }
    }
}
