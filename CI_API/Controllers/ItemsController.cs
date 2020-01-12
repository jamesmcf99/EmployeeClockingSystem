using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CI_DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace CI_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemsController : ControllerBase
    {
      private readonly ApplicationDbContext _context;

      public ItemsController(ApplicationDbContext context)
      {
        _context = context; 

      }



        //http://localhost:500/api/values
        [HttpGet]
        public async Task<IActionResult> GetItems()
        {
          var items = await _context.Items.ToListAsync();  
          return Ok(items);
        }


         [HttpGet("{id}")]
        public async Task<IActionResult> GetItem(int id)
        {
          var item = await _context.Items.FirstOrDefaultAsync(v => v.Id == id);
          
          return Ok(item);
        }
    }
}
