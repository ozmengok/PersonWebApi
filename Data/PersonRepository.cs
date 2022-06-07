

namespace PersonWebApı.Data
{


    public class Person
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }

    }


    public class PersonRepository : IPersonRepository
    {

        


        List<Person> m_ContextPeople = new List<Person>
        {

            new Person {  FirstName = "Jack", SurName = "AAA" },
            new Person { FirstName = "Yasar", SurName = "BBBB" },
            new Person { FirstName = "Ozmen", SurName = "CCC" },
            new Person { FirstName = "XXXXX", SurName = "DDDD" },
            new Person { FirstName = "YYYY", SurName = "EEEE" },
        };


        public List<Person> GetListOfPeople()
        {
            return m_ContextPeople.ToList();
        }

        public List<Person> GetPeopleByFirstName(string firstName)
        {
            return m_ContextPeople.Where(x => x.FirstName == firstName).ToList();

        }
        public bool CreatePerson(Person person)
        {
            try
            {
                m_ContextPeople.Add(person);
                return true;
            }
            catch
            {
                return false;
              
            }
          

        }

    }

  
}
