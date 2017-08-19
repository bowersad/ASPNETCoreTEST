using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace PhilameterAPI.Controllers
{
    [Route("/")]
    public class RootController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var result = new
            {
                href = "https://www.google.com" 
            };

            return Ok(result);
        }
    }
}
