using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EapExample.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EapExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly EapExampleContext _context;

        public SearchController(EapExampleContext context)
        {
            _context = context;
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> SearchName([FromRoute] string name)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var employees =  _context.Employee.Where(e => e.Department == name).ToList();
            if (employees == null || employees.Count == 0)
            {
                return NotFound();
            }

            return Ok(employees);
        }
    }
}