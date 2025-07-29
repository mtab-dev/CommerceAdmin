using CommerceAdmin.Application.Abstractions;
using CommerceAdmin.Application.DTO.Request;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CommerceAdmin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpPost]
        public async Task<IActionResult> GetProducts(RegisterProductDTO dto)
        {
            // This is a placeholder for the actual implementation
            var result = await _productService.RegisterProductAsync(dto) ;

            return Ok(result);
        }
    }
}
