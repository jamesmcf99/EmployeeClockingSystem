using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CI_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {


        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
          return new string[] {"item1", "item2"};
        }
    }
}
