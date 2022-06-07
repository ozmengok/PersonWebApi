using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using PersonWebApı.Data;



namespace PersonWebApı.Manager
{
    public class PersonManager : IPersonManager
    {
        private readonly IPersonRepository _personRepository;

        public PersonManager(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public JsonResult GetPersonList()
        {
            var personList = _personRepository.GetListOfPeople();
            return new JsonResult( personList);
        }

        public JsonResult GetPeopleByFirstName(string firstName)
        {
            var personList = _personRepository.GetPeopleByFirstName(firstName);
            return new JsonResult(personList);
        }


        public JsonResult CreatePerson(Person person)
        {
            var saveResult = _personRepository.CreatePerson(person);
            if (saveResult )
            {
                return new JsonResult(HttpStatusCode.ServiceUnavailable);
            }

            return new JsonResult(person);

           

        }








    }
}
