using Avensell.Concrete;
using Avensell.Model;
using Microsoft.AspNetCore.Mvc;

namespace Avensell.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : BaseController<Customer>
    {
        public CustomerController(AvensellContext context) : base(context) { }
    }
}
