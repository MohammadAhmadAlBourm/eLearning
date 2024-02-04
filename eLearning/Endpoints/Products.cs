using eLearning.DTO;
using System.Text.Json;

namespace eLearning.Endpoints;

public static class Products
{
    public static void RegisterProductsEndpoints(this IEndpointRouteBuilder routes)
    {
        var products = routes.MapGroup("/api/v1/products");

        products.MapGet("", async (IHttpClientFactory httpClient) =>
        {
            var client = httpClient.CreateClient();

            var response = await client.GetAsync("https://fakestoreapi.com/products");

            response.EnsureSuccessStatusCode();

            var jsonContent = await response.Content.ReadAsStringAsync();
            var productsList = JsonSerializer.Deserialize<ProductDto[]>(jsonContent, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return Results.Ok(productsList);
        });
    }
}