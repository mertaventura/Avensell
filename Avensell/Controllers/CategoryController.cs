using Avensell.Concrete;
using Avensell.Model;
using Microsoft.AspNetCore.Mvc;

namespace Avensell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : BaseController<Category>
    {
        public CategoryController(AvensellContext context) : base(context) { }
    }
}
