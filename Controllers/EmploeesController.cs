using Emploees.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emploees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploeesController : ControllerBase
    {
        private readonly Context _db;


        EmploeesController(Context _db)
        {
            _db = _db;
        }


        [HttpPost("create")]
        IActionResult CreateEmploees([FromBody] object emploee)
        {
            if (emploee !== null)
            {
              Emploees  e = newEmploee = 
                return Ok();
            }
            return BadRequest();    
        }


    }
}
