using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sipay.Bootcamp.GamzeNurMadan.Assignment1.Models;

namespace Sipay.Bootcamp.GamzeNurMadan.Assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        public PersonController() { }


        [HttpPost]
        public Person Post([FromBody] Person person)
        {
            return person;
        }
    }
}
