using Microsoft.AspNetCore.Mvc;
using PersonWebApi.Manager;
using PersonWebApi.Data;
using System.Net;
using PersonWebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {

        readonly IPersonManager _personManager;


        public PersonController(IPersonManager personManager)
        {
            _personManager = personManager;
        }

        /// <summary>
        /// returns list of the types
        /// </summary>
        [HttpGet("GetPersonList")]
        public IActionResult GetPersonList()
        {
            return _personManager.GetPersonList();
        }

        [HttpGet("GetPersonListByName")]
        public IActionResult GetPersonListByName(string firstName)
        {
            return _personManager.GetPeopleByFirstName(firstName);
        }


        [HttpPost("CreatePerson")]
        public IActionResult CreatePerson([FromBody] Person person)
        {
            if (ModelState.IsValid)
            {
                return _personManager.CreatePerson(person);
               
            }
            else
            {
                return new JsonResult(HttpStatusCode.BadRequest);
            }
        }


    }
}
