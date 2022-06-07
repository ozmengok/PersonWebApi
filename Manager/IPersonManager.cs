using PersonWebApı.Data;
using Microsoft.AspNetCore.Mvc;

namespace PersonWebApı.Manager
{
    public interface IPersonManager
    {
      
        public JsonResult GetPersonList();

        public JsonResult GetPeopleByFirstName(string firstName);

        public JsonResult CreatePerson(Person person);
    }
}
