using Emploees.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emploees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {

        // тестовый запрос
        [HttpGet("test")]
        public IActionResult Test()
        {
            string t = $"";
            return Ok($"Привет! Сервер запущен {DateTime.Now.ToString("D")} в {DateTime.Now.ToString("t")}");
        }

        private readonly Context _db;


        StaffController(Context _db)
        {
            _db = _db;
        }


        //[HttpPost("create")]
        //IActionResult CreateEmploees([FromBody] Staff staff)
        //{
        //    if (staff != null)
        //    {
        //        Staff newPerson = new Staff(staff.SureName, staff.Name, staff.ThirdName, staff.BirthDay, staff.EmploymentDate, staff.Salary); 
        //        _db.Emploees.Add(newPerson);
        //        _db.SaveChanges();
        //        return Ok();
        //    }
        //    return BadRequest();    
        //}


    }
}
