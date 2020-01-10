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
        public async Task<IActionResult> GetValues()
        {
          var values = await _context.Items.ToListAsync();  
          return Ok(values);
        }


         [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
          var value = await _context.Items.FirstOrDefaultAsync(v => v.Id == id);
          
          return Ok(value);
        }
    }
}
