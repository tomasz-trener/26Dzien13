using Microsoft.AspNetCore.Mvc;
using P06Shop.Shared;

namespace P05Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
       public async Task<ActionResult<List<Product>>> GetProducts()
       {
            //try
            //{
            //    // pobranie danych z Serwisu 
            //    //var products = await _productService.GetProducts();
            //}
            //catch (Exception ex)
            //{
            //    return StatusCode(StatusCodes.Status500InternalServerError,
            //                           $"Error retrieving data from the database {ex.Message}");
            //}

            var result = new ServiceReponse<List<Product>>();

            if(result.Success)
            {
                return Ok(result);
            }
            else
            {
                return StatusCode(500, $"Internal server error {result.Message}");
            }
       }
    }


}
