using Microsoft.AspNetCore.Mvc;
using WebbilirProductAPI.Interfaces;
using WebbilirProductAPI.Models;

namespace WebbilirProductAPI.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class ProductController : ControllerBase 
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(string id)
        {
            var product = await _productService.GetProductByIdAsync(id);

            if (product == null)
                return NotFound();

            return Ok(product); 
        }
    }
}