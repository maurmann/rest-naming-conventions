using Microsoft.AspNetCore.Mvc;
using RestNamingConventions.DTO;

namespace RestNamingConventions.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult Get(int id)
        {
            return Ok("Get simples");
        }

        [HttpGet]
        [Route("")]     
        public IActionResult Get([FromQuery]ProductQueryRequestDTO request)
        {
            return Ok("Get full");
        }




    }

 
}
