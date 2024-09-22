

using PersonWebApi.Model;

namespace PersonWebApi.Data
{


    public class PersonRepository : IPersonRepository
    {
        private readonly DatabaseContext m_Context;


        public PersonRepository(DatabaseContext context)
        {
            m_Context = context;
        }

        public List<Person> GetListOfPeople()
        {
            return m_Context.Person.ToList();
        }

        public List<Person> GetPeopleByFirstName(string firstName)
        {
            return m_Context.Person.Where(x => x.FirstName == firstName).ToList();

        }
        public bool CreatePerson(Person person)
        {
            try
            {
                m_Context.Person.Add(person);
                return true;
            }
            catch
            {
                return false;
              
            }
          

        }

    }

  
}
