using Local_Gaccha.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Local_Gaccha.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ShopContext _context;

        public ProductsController(ShopContext context)
        {
            _context = context;

            _context.Database.EnsureCreated();
        }

        /// <summary>
        /// List all Products
        /// </summary>
        /// <param></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAllProducts()
        {
            var products = await _context.Products.ToArrayAsync();
            if(products == null)
            {
                return Ok(new ResponseHttp(false, "Error when retrieving Product list!", null));
            }
            return Ok(new ResponseHttp(true, "", products));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null)
            {
                return Ok(new ResponseHttp(false, "Product not found!", null));
            }
            return Ok(new ResponseHttp(true, "", product));
        }

        [HttpPost]
        public async Task<ActionResult<ResponseHttp>> CreateProduct([FromBody] Product bodyData)
        {
            if (!ModelState.IsValid)
            {
                return Ok(new ResponseHttp(false, "Invalid data for Product creation!", null));
            }
            _context.Products.Add(bodyData);
            await _context.SaveChangesAsync();

            return Ok(new ResponseHttp(true, "", CreatedAtAction(
                "GetProduct",
                new { id = bodyData.Id },
                bodyData).Value)); 

        }
    }
}
