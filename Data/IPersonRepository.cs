using PersonWebApi.Model;

namespace PersonWebApi.Data
{
    public interface IPersonRepository
    {
        public List<Person> GetListOfPeople();
        public List<Person> GetPeopleByFirstName(string firstName);
        public bool CreatePerson(Person person);

    }
}
