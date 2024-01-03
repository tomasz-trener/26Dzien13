using P06Shop.Shared;

namespace P05Shop.API.Services
{
    public class ProductService
    {
        public async Task<ServiceReponse<List<Product>>> GetProductsAsync()
        {
            var result = new ServiceReponse<List<Product>>();

            try
            {
                result.Data= new List<Product>()
                {
                    new Product() { Id=1, Title="Product 1", Description="Description 1" },
                };
            }
            catch (Exception ex)
            {
                result.Message = $"Error retrieving data from the database {ex.Message}";
                result.Success = false;
            }

            return result;
        }
    }
}
