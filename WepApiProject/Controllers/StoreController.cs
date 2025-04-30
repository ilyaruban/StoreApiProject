using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiProject.DataContext;

namespace WepApiProject.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        protected readonly AppDbContext Context;

        public StoreController(AppDbContext context)
        {
            this.Context = context;
        }
    }
}
