using PersonWebApi.Data;
using Microsoft.AspNetCore.Mvc;
using PersonWebApi.Model;

namespace PersonWebApi.Manager
{
    public interface IPersonManager
    {
      
        public JsonResult GetPersonList();

        public JsonResult GetPeopleByFirstName(string firstName);

        public JsonResult CreatePerson(Person person);
    }
}
