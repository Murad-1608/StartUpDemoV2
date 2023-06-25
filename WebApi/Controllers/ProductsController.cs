using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsToSalesService productsToSalesService;
        public ProductsController(IProductsToSalesService productsToSalesService)
        {
            this.productsToSalesService = productsToSalesService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var products = productsToSalesService.GetProductsToSales();

            return Ok(products);
        }
    }
}
