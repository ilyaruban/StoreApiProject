using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WepApiProject.DataContext;

namespace WepApiProject.Controllers
{
    public class ProductController : StoreController
    {
        public ProductController(AppDbContext context):base(context)
        {
            
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(Context.Products.ToList());
        }
    }
}
