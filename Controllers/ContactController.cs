using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InAndOut.Controllers
{
    [Route("Admin/[controller]")]
    public class ContactController : Controller
    {
        [Route("Main")]
        public IActionResult Index()
        {
            //return View();
            return Ok("This is main!!!");
        }

        [Route("Detail/{id?}")]
        public IActionResult Detail(int id)
        {
            //return View();
            return Ok($"This is details {id}!!!");
        }

        [Route("Get_1/{id}")]
        [HttpGet]
        public IActionResult Get_1(int id)
        {
            //return View();
            return Ok($"Get id: {id}!!!");
        }

        [Route("Get_2/{id}")]
        [HttpGet]
        public IActionResult Get_2([FromRoute] int id)
        {
            //return View();
            return Ok($"Get id: {id}!!!");
        }
    }
}
