using Avensell.Concrete;
using Avensell.Model;
using Microsoft.AspNetCore.Mvc;

namespace Avensell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : BaseController<Product>
    {
        public ProductController(AvensellContext context) : base(context) { }
    }
}
